using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class ScoreSheet : UserControl
    {
        #region Initialization
        private List<string> _sectionList;
        private List<string>[] _categories;

        private string[][] _sectionArray;
        private string[] _players;

        private int[] _turnsLeft;

        private int _turn;
        
        private Color _sheetBgColor,
                      _sheetFgColor,
                      _turnBgColor,
                      _turnFgColor,
                      _prvwFgColor;

        private int _yahtzeesRolled;

        //public OldScoreSheet() : this(new string[] { "P1" }) { }
        public ScoreSheet(string[] players)
        {
            InitializeComponent();

            Font = new Font("Consolas", 12F);

            // Create/initialize local variables

            // Initialize class-scope variables
            _sectionArray = new string[][]
            {
                UpperSectionLabels,
                UpperSubtotalLabels,
                LowerSectionLabels,
                LowerSubtotalLabels,
                TotalSectionLabels
            };

            _sectionList = new List<string>();
            foreach (string[] s in _sectionArray)
            {
                foreach (string t in s)
                {
                    _sectionList.Add(t.ToUpper());
                }
            }

            _players = players;
            _turn = 0;

            _categories = new List<string>[players.Length];
            for (int i = 0; i < _categories.Length; i++)
            {
                _categories[i] = new List<string>();

                foreach (string s in UpperSectionLabels) _categories[i].Add(s.ToUpper());
                foreach (string s in LowerSectionLabels) _categories[i].Add(s.ToUpper());
            }

            BackColor = SystemColors.Control;
            ForeColor = SystemColors.WindowText;
            TurnBackColor = Color.LightYellow;
            PreviewForeColor = Color.Red;

            _yahtzeesRolled = 0;

            InitializeScoreSheet(pnlScoreTable);

            // Create player labels
            pnlScoreTable.ColumnCount = 2 + _players.Length;
            for (int i = 0; i < _players.Length; i++)
            {
                for (int j = 0; j <= pnlScoreTable.RowCount; j++)
                {
                    string name = _players[i];
                    bool header = (j == 0);
                    //int length = 12;

                    Label l = new Label()
                    {
                        Anchor = AnchorStyles.None,
                        AutoSize = true,
                        BorderStyle = header ? BorderStyle.None : BorderStyle.Fixed3D,
                        Dock = header ? DockStyle.None : DockStyle.Fill,
                        Margin = new Padding(header ? 3 : 0),
                        MinimumSize = new Size(header ? 0 : 120, 0),
                        Text = header ? name.ToUpper() : "", //.ToUpper().Substring(0, (name.Length < length) ? name.Length : length) : "",
                        TextAlign = ContentAlignment.MiddleRight
                    };

                    pnlScoreTable.Controls.Add(l, 2 + i, j);

                    if (!header) l.MouseClick += lblScoreBox_MouseClick;
                }
            }
            
            pnlScoreTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            HighlightPlayerWithTurn();

            // Subscribe controls to event handlers
            for (int i = 0; i < Players.Length; i++)
            {

            }

            // Create player columns
            /*int columns = 2 + _players.Length;
            pnlScoreTable.ColumnCount = columns;
            for (int i = 0; i < _players.Length; i++)
            {
                Label l = new Label();
                l.AutoSize = true;
                l.Text = _players[i].ToUpper();
                l.TextAlign = ContentAlignment.MiddleLeft;

                pnlScoreTable.Controls.Add(l, 2 + i, 0);

                for (int j = 1; j < pnlScoreTable.RowCount - 1; i++)
                {
                    Label m = new Label();
                    m.BorderStyle = BorderStyle.Fixed3D;
                    m.Dock = DockStyle.Fill;
                    m.Margin = new Padding(0);
                }
            }/**/
        }
        #endregion

        #region Public enums
        #endregion

        #region Public properties
        public List<string>[] Categories { get { return _categories; } }

        public string[] Players
        {
            get { return _players; }
            /*set
            {
                var p = (_players != null) ? _players : new string[] { };
                _players = value;
            }*/
        }

        public string CurrentPlayer
        {
            get { return Players[Turn]; }
        }

        public int Turn
        {
            get { return _turn; }
            /*set
            {
                _turn = value;

                for (int i = 1; i <= pnlScoreTable.RowCount; i++)
                {
                    for (int j = 0; j < pnlScoreTable.ColumnCount - 2; j++)
                    {
                        pnlScoreTable.GetControlFromPosition(2 + j, i).BackColor = (j == value) ? TurnColor
                                                                                                : SystemColors.Control;
                    }
                }
            }*/
        }

        public new Color BackColor
        {
            get { return _sheetBgColor; }
            set { base.BackColor = _sheetBgColor = value; }
        }

        public new Color ForeColor
        {
            get { return _sheetFgColor; }
            set { base.ForeColor = _sheetFgColor = value; }
        }

        public Color TurnBackColor
        {
            get { return _turnBgColor; }
            set
            {
                Color old = _turnBgColor;

                _turnBgColor = value;

                foreach (Control c in pnlScoreTable.Controls)
                {
                    if (c.BackColor == old)
                        c.BackColor = _turnBgColor;
                }
            }
        }

        public Color TurnForeColor
        {
            get { return _turnFgColor; }
            set
            {
                Color old = _turnFgColor;

                _turnFgColor = value;

                foreach (Control c in pnlScoreTable.Controls)
                {
                    if (c.ForeColor == old)
                        c.ForeColor = _turnFgColor;
                }
            }
        }

        public Color PreviewForeColor
        {
            get { return _prvwFgColor; }
            set
            {
                if (value == ForeColor)
                    throw new Exception("Preview color must be different from default foreground color.");

                Color old = _prvwFgColor;

                _prvwFgColor = value;

                foreach (Control c in pnlScoreTable.Controls)
                {
                    if (c.ForeColor == old)
                        c.ForeColor = _prvwFgColor;
                }
            }
        }
        #endregion

        #region Public static properties
        public static string[] UpperSectionLabels
        {
            get
            {
                return new string[]
                {
                    "Aces",
                    "Twos",
                    "Threes",
                    "Fours",
                    "Fives",
                    "Sixes"
                };
            }
        }

        public static string[] LowerSectionLabels
        {
            get
            {
                return new string[]
                {
                    "3 of a Kind",
                    "4 of a Kind",
                    "Full House",
                    "Small Straight",
                    "Large Straight",
                    "Yahtzee",
                    "Chance"
                };
            }
        }

        public static string[] UpperSubtotalLabels
        {
            get
            {
                return new string[]
                {
                    "Upper Subtotal",
                    "Upper Bonus",

                    "Upper Total"
                };
            }
        }

        public static string[] LowerSubtotalLabels
        {
            get
            {
                return new string[]
                {
                    /*"Lower Subtotal",
                    "Yahtzee Bonus",*/

                    "Lower Total"
                };
            }
        }

        public static string[] TotalSectionLabels
        {
            get
            {
                return new string[]
                {
                    "Grand Total"
                };
            }
        }

        /*public string[] Winners
        {
            get
            {
                string[] names = new string[Players.Length];
                int[] totalScores = new int[Players.Length];
                int max;

                for (int i = 0; i < Players.Length; i++)
                    totalScores[i] = Int32.Parse(pnlScoreTable.GetControlFromPosition(2 + i, pnlScoreTable.RowCount - 1).Text);

                max = totalScores.Max();

                for (int i = 0; i < Players.Length; i++)
                {
                    //if (totalScores[i] == max) names[i] = 
                }

                return names;
            }
        }*/
        #endregion

        #region Public static methods

        #endregion

        #region Public methods
        /// <summary>
        /// Awards a specified score to the player's score table and rotates
        /// the player's turn to the next player in the queue.
        /// </summary>
        /// <param name="categoryName">The category to search along the score table's left axis.</param>
        /// <param name="playerIndex">The index of the player who has earned the score.</param>
        /// <param name="points">The score to award the player.</param>
        public void AwardPoints(string categoryName, int playerIndex, int points)
        {
            ClearPreviews();
            Categories[Turn].Remove(categoryName);

            //

            Label scoreBox;
            
            int usSubtotalRowIndex, usBonusRowIndex, usTotalRowIndex,
                /*lsSubtotalRowIndex, lsBonusRowIndex,*/ lsTotalRowIndex,
                grandTotalRowIndex;

            int score;
            int upperTotal;//, lowerTotal;
            //int row = 0,
            //    col = 0;
            int col = 2 + playerIndex;

            //for (int i = 1; i < pnlScoreTable.RowCount; i++)
            //{
            //    Control c = pnlScoreTable.GetControlFromPosition(1, i);

            //    if (categoryName.ToUpper() == c.Text.ToUpper())
            //    {
            //        /*if (categoryName.ToUpper().Contains("TOTAL")
            //         || categoryName.ToUpper().Contains("BONUS"))
            //            row = -1;
            //        else*/
            //        row = i;
            //    }
            //    //else row = -1;
            //}
            //col = 2 + playerIndex;

            ////*if (row == -1) throw new Exception("Category name must be a value listed "
            //                                 + "under the UPPER or LOWER sections.");*/

            ////

            //scoreBox = pnlScoreTable.GetControlFromPosition(col, row) as Label;

            scoreBox = GetScoreSlot(categoryName, playerIndex);

            usSubtotalRowIndex = 1 + _sectionList.IndexOf(UpperSubtotalLabels[0].ToUpper());
            usBonusRowIndex = 1 + _sectionList.IndexOf(UpperSubtotalLabels[1].ToUpper());
            usTotalRowIndex = 1 + _sectionList.IndexOf(UpperSubtotalLabels[2].ToUpper());

            //lsSubtotalRowIndex = 1 + _sectionList.IndexOf(LowerSubtotalLabels[0].ToUpper());
            //lsBonusRowIndex = 1 + _sectionList.IndexOf(LowerSubtotalLabels[1].ToUpper());
            lsTotalRowIndex = 1 + _sectionList.IndexOf(LowerSubtotalLabels[0].ToUpper());

            grandTotalRowIndex = 1 + _sectionList.IndexOf("GRAND TOTAL");

            score = (scoreBox.Text != "") ? Int32.Parse(scoreBox.Text) : 0;
            upperTotal = UpperSectionSubtotal(playerIndex);

            scoreBox.Cursor = Cursors.Default;
            scoreBox.Text = (score + points).ToString();

            #region Set total/bonus label text
            if (UpperSectionSubtotal(playerIndex) > 0)
            {
                Control c = pnlScoreTable.GetControlFromPosition(col, usSubtotalRowIndex);

                c.Font = new Font(c.Font, FontStyle.Bold);
                c.Text = UpperSectionSubtotal(playerIndex).ToString();
            }

            if (UpperSectionBonus(playerIndex) > 0)
            {
                Control c = pnlScoreTable.GetControlFromPosition(col, usBonusRowIndex);

                c.Font = new Font(c.Font, FontStyle.Bold);
                c.Text = UpperSectionBonus(playerIndex).ToString();
            }

            if (UpperSectionTotal(playerIndex) > 0)
            {
                Control c = pnlScoreTable.GetControlFromPosition(col, usTotalRowIndex);

                c.Font = new Font(c.Font, FontStyle.Bold);
                c.Text = UpperSectionTotal(playerIndex).ToString();
            }
            
            /*if (LowerSectionSubtotal(playerIndex) > 0)
            {
                Control c = pnlScoreTable.GetControlFromPosition(col, lsSubtotalRowIndex);

                c.Font = new Font(c.Font, FontStyle.Bold);
                c.Text = LowerSectionSubtotal(playerIndex).ToString();
            }

            if (LowerSectionBonus(playerIndex) > 0)
            {
                Control c = pnlScoreTable.GetControlFromPosition(col, lsBonusRowIndex);

                c.Font = new Font(c.Font, FontStyle.Bold);
                c.Text = LowerSectionBonus(playerIndex).ToString();
            }*/

            if (LowerSectionTotal(playerIndex) > 0)
            {
                Control c = pnlScoreTable.GetControlFromPosition(col, lsTotalRowIndex);

                c.Font = new Font(c.Font, FontStyle.Bold);
                c.Text = LowerSectionTotal(playerIndex).ToString();
            }

            if (GrandTotal(playerIndex) > 0)
            {
                Control c = pnlScoreTable.GetControlFromPosition(col, grandTotalRowIndex);

                c.Font = new Font(c.Font, FontStyle.Bold);
                c.Text = GrandTotal(playerIndex).ToString();
            }
            #endregion

            SwitchTurn();
        }

        public void PreviewPoints(string categoryName, int points)
        {
            Label scoreBox = GetScoreSlot(categoryName, _turn);

            if (String.IsNullOrWhiteSpace(scoreBox.Text) || scoreBox.ForeColor == PreviewForeColor)
            {
                scoreBox.Cursor = Cursors.Hand;
                scoreBox.ForeColor = PreviewForeColor;
                scoreBox.Text = points.ToString();
            }
        }

        public void ClearPreviews()
        {
            foreach (Control c in pnlScoreTable.Controls)
            {
                if (c.ForeColor == PreviewForeColor)
                {
                    c.Cursor = Cursors.Default;
                    c.ForeColor = ForeColor;
                    c.Text = "";
                }
            }
        }

        public bool GameOver()
        {
            foreach (List<string> l in Categories)
            {
                // If even one list of categories is not empty, do not
                // declare game over
                if (l.Count > 0) return false;
            }

            return true;
        }

        public int UpperSectionSubtotal(int playerIndex)
        {
            int sum = 0;
            for (int i = 0; i < UpperSectionLabels.Length; i++)
            {
                Control c = pnlScoreTable.GetControlFromPosition(2 + playerIndex, 1 + i);
                sum += (!String.IsNullOrWhiteSpace(c.Text)) ? Int32.Parse(c.Text) : 0;
            }

            return sum;
        }

        public int UpperSectionBonus(int playerIndex)
        {
            return (UpperSectionSubtotal(playerIndex) >= 63) ? 35 : 0;
        }

        public int UpperSectionTotal(int playerIndex)
        {
            return UpperSectionSubtotal(playerIndex) + UpperSectionBonus(playerIndex);
        }

        public int LowerSectionSubtotal(int playerIndex)
        {
            int sum = 0;

            int startIndex = _sectionList.IndexOf(LowerSectionLabels[0].ToUpper());
            for (int i = startIndex;
                 i < startIndex + LowerSectionLabels.Length;
                 i++)
            {
                Control c = pnlScoreTable.GetControlFromPosition(2 + playerIndex, 1 + i);
                sum += (!String.IsNullOrWhiteSpace(c.Text)) ? Int32.Parse(c.Text) : 0;
            }

            return sum;
        }

        public int LowerSectionBonus(int playerIndex)
        {
            return (_yahtzeesRolled > 1) ? _yahtzeesRolled * 100 : 0;
        }

        public int LowerSectionTotal(int playerIndex)
        {
            return LowerSectionSubtotal(playerIndex) + LowerSectionBonus(playerIndex);
        }

        public int GrandTotal(int playerIndex)
        {
            return UpperSectionTotal(playerIndex) + LowerSectionTotal(playerIndex);
        }

        public int GetPoints(string categoryName, int playerIndex)
        {
            int categoryIndex = 0,
                value = 0;

            for (categoryIndex = 0; categoryIndex < pnlScoreTable.RowCount; categoryIndex++)
            {
                Control c = pnlScoreTable.GetControlFromPosition(2 + playerIndex,
                                                                 1 + categoryIndex);

                if (pnlScoreTable.GetControlFromPosition(1, 1 + categoryIndex).Text == categoryName.Trim())
                {
                    value = (!String.IsNullOrEmpty(c.Text)) ? Int32.Parse(c.Text) : 0;
                    break;
                }
            }

            return value;
        }

        /*public int GetGrandTotal(int playerIndex)
        {
            return GetPoints("GRAND TOTAL", playerIndex);
        }

        public int[] GetWinningPlayerIndices()
        {
            int[] indices;

            // Get each player's score to find max score
            int[] scores = new int[Players.Length];
            for (int i = 0; i < scores.Length; i++)
                scores[i] = GetGrandTotal(i);

            // Find max score
            int max = scores.Max();
            int instsOfMax = 0;
            for (int i = 0; i < scores.Length; i++)
                if (scores[i] == max) instsOfMax++;

            indices = new int[instsOfMax];

            // Get indices of all players holding max score
            for (int i = 0; i < indices[i]; i++)
            {
                indices[i] = Array.IndexOf(scores, max, i);
                MessageBox.Show(indices[i].ToString());
            }

            return indices;
        }*/

        public int[] GetGrandTotals()
        {
            int[] grandTotals = new int[Players.Length];
            for (int i = 0; i < Players.Length; i++)
                grandTotals[i] = GrandTotal(i);

            return grandTotals;
        }

        public int GetWinningScore()
        {
            return GetGrandTotals().Max();
        }

        public string[] GetWinningPlayers()
        {
            /*int[] indices = GetWinningPlayerIndices();
            string[] winners = new string[indices.Length];
            foreach (int i in indices)
                winners[i] = Players[i];

            return winners;*/

            int highScore = GetWinningScore();

            // Add the name of each player with the high score
            // to the list of winners
            List<string> winners = new List<string>();
            for (int i = 0; i < Players.Length; i++)
            {
                if (GetGrandTotals()[i] == highScore)
                    winners.Add(Players[i]);
            }

            return winners.ToArray();
        }

        public void SwitchTurn()
        {
            _turn = (_turn == Players.Length - 1) ? 0 : _turn + 1;

            /*List<string> winners = GetWinningPlayers();
            ParentForm.Text = "[ ";
            foreach (string s in winners)
            {
                ParentForm.Text += s + " ";
            }
            ParentForm.Text += "] (" + winners.ToArray().Length + ")";*/

            HighlightPlayerWithTurn();

            OnTurnChanged(EventArgs.Empty);
        }
        #endregion

        #region Private methods
        private void InitializeScoreSheet(TableLayoutPanel p)
        {
            p.Controls.Clear();
            Hide();

            // Add rows and columns
            int rows = UpperSectionLabels.Length
                     + UpperSubtotalLabels.Length
                     + LowerSectionLabels.Length
                     + LowerSubtotalLabels.Length
                     + TotalSectionLabels.Length;

            p.RowCount = rows;
            p.ColumnCount = 2;

            // Add icons
            PictureBox up = new PictureBox(),
                       down = new PictureBox(),
                       sigma = new PictureBox();

            up.Anchor = AnchorStyles.None;
            up.Image = Properties.Resources.UpArrow;
            up.SizeMode = PictureBoxSizeMode.AutoSize;

            down.Anchor = AnchorStyles.None;
            down.Image = Properties.Resources.DownArrow;
            down.SizeMode = PictureBoxSizeMode.AutoSize;

            sigma.Anchor = AnchorStyles.None;
            sigma.Image = Properties.Resources.Sigma;
            sigma.SizeMode = PictureBoxSizeMode.AutoSize;

            p.Controls.Add(up, 0, 1);
            p.Controls.Add(down, 0, 1 + UpperSectionLabels.Length
                                      + UpperSubtotalLabels.Length);
            p.Controls.Add(sigma, 0, 1
                                   + UpperSectionLabels.Length
                                   + UpperSubtotalLabels.Length
                                   + LowerSectionLabels.Length
                                   + LowerSubtotalLabels.Length);

            // Add labels
            int row = 0;
            foreach (string[] section in _sectionArray)
            {
                foreach (string s in section)
                {
                    Label l = new Label()
                    {
                        Anchor = AnchorStyles.Right,
                        AutoSize = true,
                        Dock = DockStyle.None,
                        Text = s.ToUpper(),
                        TextAlign = ContentAlignment.MiddleRight
                    };

                    p.Controls.Add(l, 1, row + 1);

                    row++;
                }
            }

            // Format objects within table
            p.RowStyles.Clear();
            for (int i = 0; i < p.RowCount; i++)
                p.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            p.ColumnStyles.Clear();
            for (int i = 0; i < p.ColumnCount; i++)
                p.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            foreach (Control c in p.Controls)
            {
                c.Margin = new Padding(1);
                c.MinimumSize = new Size(0, 16);
                
                if (c is Label)
                {
                    Label l = c as Label;

                    bool total = l.Text.ToUpper().Contains("TOTAL"),
                         bonus = l.Text.ToUpper().Contains("BONUS");

                    if (total || bonus) l.Font = new Font(l.Font, FontStyle.Bold);
                }
            }

            Show();
        }

        private void HighlightPlayerWithTurn()
        {
            // Highlight the column representing the current player's
            // individual score sheet
            for (int i = 0; i < pnlScoreTable.RowCount; i++)
            {
                for (int j = 0; j < pnlScoreTable.ColumnCount - 2; j++)
                {
                    Control header = pnlScoreTable.GetControlFromPosition(2 + j, 0),
                            cell = pnlScoreTable.GetControlFromPosition(2 + j, i + 1);

                    header.Font = new Font(header.Font, (j == _turn) ? FontStyle.Bold
                                                                     : FontStyle.Regular);

                    //header.ForeColor = (j == _turn) ? Color.Red : SystemColors.ControlText;

                    if (!GameOver())
                    {
                        cell.BackColor = (j == _turn) ? TurnBackColor : BackColor;
                        cell.ForeColor = (j == _turn) ? TurnForeColor : ForeColor;
                    }
                    else
                    {
                        cell.BackColor = BackColor;
                        cell.ForeColor = ForeColor;
                    }
                }
            }
        }

        private Label GetScoreSlot(string categoryName, int playerIndex)
        {
            Label scoreBox = null;

            int row = 0,
                col = 0;

            for (int i = 1; i < pnlScoreTable.RowCount; i++)
            {
                scoreBox = pnlScoreTable.GetControlFromPosition(1, i) as Label;

                if (categoryName.ToUpper() == scoreBox.Text.ToUpper())
                {
                    row = i;
                    break;
                }

                scoreBox = null;
            }
            col = 2 + playerIndex;

            if (scoreBox == null)
                throw new Exception("Category name \"" + categoryName + "\" does not exist.");
            else if (playerIndex < 0 || playerIndex > Players.Length - 1)
                throw new Exception("Player index must be between 0 and " + (Players.Length - 1) + " inclusively.");
            else
                return pnlScoreTable.GetControlFromPosition(col, row) as Label;
        }
        #endregion

        #region Public event handlers
        public delegate void TurnChangedEventHandler(object sender, EventArgs e);
        public event TurnChangedEventHandler TurnChanged;
        protected virtual void OnTurnChanged(EventArgs e)
        {
            TurnChangedEventHandler handler = TurnChanged;
            if (handler != null) handler(this, e);
        }
        #endregion

        #region Private events
        private void UpperSectionLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void LowerSectionLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblScoreBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (sender is Label)
                {
                    Label l = sender as Label;

                    if (l.Cursor == Cursors.Hand)
                    {
                        int row = pnlScoreTable.GetCellPosition(l).Row;

                        string category = pnlScoreTable.GetControlFromPosition(1, row).Text;

                        AwardPoints(category, Turn, Int32.Parse(l.Text));
                    }
                }
            }
        }
        #endregion
    }
}
