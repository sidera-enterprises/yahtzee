using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class MainForm : Form
    {
        #region Initialization
        private FileSystem _fs;

        private bool _exitOnClose;

        private Random _random;
        private Die[] _dice;

        private string[] _players;
        private ScoreSheet _scoreSheet;

        private int _rolls;
                    //_yahtzeesRolled;

        private bool _touchMode;
        //private int[] _turnsLeft;
        public MainForm(string[] players)
        {
            InitializeComponent();

            _fs = new FileSystem();

            _exitOnClose = true;

            _random = new Random();
            _dice = new Die[] { die1, die2, die3, die4, die5 };

            _players = players;

            //_yahtzeesRolled = 0;
            
            _scoreSheet = new ScoreSheet(_players);
            pnlMain.Controls.Add(_scoreSheet);
            _scoreSheet.Margin = new Padding(3);
            _scoreSheet.Location = new Point(_scoreSheet.Margin.Left,
                                             _scoreSheet.Margin.Top);

            InitializeRolls();
            lblStatusMessage.Text = (_players.Length > 1) ? "Okay, " + _scoreSheet.CurrentPlayer
                                                          + ", it's your turn. To begin, please "
                                                          + "roll the dice."
                                                          : "To begin, please roll the dice.";

            _scoreSheet.TurnChanged += ScoreSheet_TurnChanged;
        }
        #endregion

        #region Private properties
        private bool TouchMode
        {
            get { return _touchMode; }
            set
            {
                _touchMode = value;

                // TODO add code here
            }
        }
        #endregion

        #region Private methods
        private void CenterControlInParent(Control c)
        {
            c.Location = new Point((c.Parent.Width - c.Width) / 2,
                                   (c.Parent.Height - c.Height) / 2);
        }

        private void InitializeRolls()
        {
            _rolls = 3;

            SetGraphicalRollEffects();
        }

        private void DecreaseRolls()
        {
            if (_rolls < 0) _rolls = 3;
            else _rolls--;

            SetGraphicalRollEffects();
        }

        private void SetGraphicalRollEffects()
        {
            btnRollDice.Enabled = (_rolls > 0);
            btnRollDice.Text = "Roll (" + _rolls + ")";

            btnSelectCategory.Enabled = (_rolls < 3);

            lblStatusMessage.Text = (_rolls > 0) ? "You now have " + _rolls + " "
                                                 + (_rolls == 1 ? "roll" : "rolls") + " "
                                                 + "left. You can roll again or click "
                                                 + "any of the above suggested scores."
                                                 : "You are out of rolls. Please click "
                                                 + "one of the above suggested scores "
                                                 + "to continue.";
        }

        //

        private int[] GetValues(bool sort)
        {
            int[] values = new int[_dice.Length];
            for (int i = 0; i < _dice.Length; i++)
                values[i] = _dice[i].Value;

            if (sort) Array.Sort(values);

            return values;
        }

        //

        private int CalculateScore(string category)
        {
            int points = 0;

            switch (category.ToUpper())
            {
                // Upper Section
                case "ACES":
                case "ONES":
                    points = SumDiceOfValue(1);
                    break;
                case "TWOS":
                    points = SumDiceOfValue(2);
                    break;
                case "THREES":
                    points = SumDiceOfValue(3);
                    break;
                case "FOURS":
                    points = SumDiceOfValue(4);
                    break;
                case "FIVES":
                    points = SumDiceOfValue(5);
                    break;
                case "SIXES":
                    points = SumDiceOfValue(6);
                    break;

                // Lower Section
                case "3 OF A KIND":
                    points = Get3OfAKind();
                    break;
                case "4 OF A KIND":
                    points = Get4OfAKind();
                    break;
                case "FULL HOUSE":
                    points = GetFullHouse();
                    break;
                case "SM. STRAIGHT":
                case "SMALL STRAIGHT":
                    points = GetSmallStraight();
                    break;
                case "LG. STRAIGHT":
                case "LARGE STRAIGHT":
                    points = GetLargeStraight();
                    break;
                case "YAHTZEE":
                    points = GetYahtzee();
                    break;
                case "CHANCE":
                    points = GetChance();
                    break;
            }

            return points;
        }

        private int CountDiceOfValue(int value)
        {
            int count = 0;
            foreach (Die d in _dice)
                if (d.Value == value) count++;

            return count;
        }

        private int SumDiceOfValue(int value)
        {
            int sum = 0;
            foreach (Die d in _dice)
                if (d.Value == value) sum += value;

            return sum;
        }

        private int SumDice()
        {
            int sum = 0;
            foreach (Die d in _dice)
                sum += d.Value;

            return sum;
        }

        private int Get3OfAKind()
        {
            int points = 0;

            for (int i = 1; i <= 6; i++)
                if (CountDiceOfValue(i) >= 3) points = SumDice();

            return points;
        }

        private int Get4OfAKind()
        {
            int points = 0;

            for (int i = 1; i <= 6; i++)
                if (CountDiceOfValue(i) >= 4) points = SumDice();

            return points;
        }

        private int GetFullHouse()
        {
            int points = 0;

            bool twoKind = false,
                 threeKind = false;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (CountDiceOfValue(j) == 2)
                    {
                        twoKind = true;
                        break;
                    }
                }
                
                if (CountDiceOfValue(i) == 3)
                {
                    threeKind = true;
                    break;
                }
            }

            points = (twoKind && threeKind) ? 25 : 0;

            return points;
        }

        private int GetSmallStraight()
        {
            int points = 0;
            int[] v = GetValues(true);

            if (v.Contains(3) && v.Contains(4))
            {
                if ((v.Contains(1) && v.Contains(2))
                 || (v.Contains(2) && v.Contains(5))
                 || (v.Contains(5) && v.Contains(6))) points = 30;
            }

            return points;
        }

        private int GetLargeStraight()
        {
            int points = 0;
            int[] v = GetValues(true);

            if (((v[0] == 1)
              && (v[1] == 2)
              && (v[2] == 3)
              && (v[3] == 4)
              && (v[4] == 5)) ||
                ((v[0] == 2)
              && (v[1] == 3)
              && (v[2] == 4)
              && (v[3] == 5)
              && (v[4] == 6))) points = 40;

            return points;
        }

        private int GetYahtzee()
        {
            int points = 0;

            for (int i = 1; i <= 6; i++)
                if (CountDiceOfValue(i) >= 5) points = 50;

            return points;
        }

        private int GetChance()
        {
            int points = 0;

            foreach (Die d in _dice) points += d.Value;

            return points;
        }

        private bool GameOver()
        {
            return _scoreSheet.GameOver();
        }
        #endregion

        #region Private events
        private void MainForm_Load(object sender, EventArgs e)
        {
            //CenterControlInParent(pnlDiceLayout);

            //Hide();

            //Show();

            //

            CenterControlInParent(_scoreSheet);

            /*
            *** INCLUDE IN A FUTURE UPDATE ***
            // Create directories
            _fs.CreateDirectories();
            if (!_fs.ConfigFileExists("highscore.txt"))
                _fs.WriteConfigFile("highscore.txt", "0");
            */
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                //CenterControlInParent(pnlDiceLayout);
                CenterControlInParent(_scoreSheet);
            } catch { /* Do nothing if unable to handle this event */ }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_exitOnClose)
            {
                string message = "Are you sure you want to leave the "
                               + "game?";

                if (!GameOver())
                {
                    DialogResult dr = MessageBox.Show(message,
                                                      "",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                    e.Cancel = (dr == DialogResult.No);

                    // Shut down the program if the user wants to
                    // leave the game
                    if (dr == DialogResult.Yes) Program.Exit();
                }
                else Program.Exit();
            }
        }

        //

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // Check whether all dice are "held"
            int numHeldDice = 0;
            foreach (Die d in _dice)
                if (d.Checked) numHeldDice++;

            if (numHeldDice == _dice.Length)
            {
                MessageBox.Show("All your dice are held. Please unhold "
                              + "one or more dice to roll.",
                                "Cannot roll dice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                // Roll all unselected dice
                foreach (Die d in _dice)
                {
                    if (!d.Checked)
                        d.Value = _random.Next(1, 7);
                }

                DecreaseRolls();

                // Preview potential points awardable
                foreach (string s in ScoreSheet.UpperSectionLabels)
                    _scoreSheet.PreviewPoints(s, CalculateScore(s));
                foreach (string s in ScoreSheet.LowerSectionLabels)
                    _scoreSheet.PreviewPoints(s, CalculateScore(s));
            }
        }

        private void btnSelectCategory_Click(object sender, EventArgs e)
        {
            CategoryDialog c = new CategoryDialog(_scoreSheet.Categories[_scoreSheet.Turn]);
            DialogResult drc = c.ShowDialog();

            if (drc == DialogResult.OK)
            {
                string category = c.Value;
                int points = 0;

                points = CalculateScore(category);

                /*if (category.ToUpper() == "YAHTZEE")
                    _yahtzeesRolled++;
                else*/

                _scoreSheet.AwardPoints(category, _scoreSheet.Turn, points);
            }
        }

        private void ScoreSheet_TurnChanged(object sender, EventArgs e)
        {
            InitializeRolls();

            foreach (Die d in _dice) d.Value = 0;

            // Indicate whose turn it is in the status bar
            string name = _scoreSheet.CurrentPlayer;
            lblStatusMessage.Text = (_scoreSheet.Players.Length > 1) ?
                                        "Okay, " + name + ", it's your turn."
                                      : "Please roll the dice to continue, "
                                      + name + ".";
            
            // Determine whether to switch turns or to declare game over
            if (GameOver())
            {
                // Block further input once game is finished
                btnRollDice.Enabled = btnSelectCategory.Enabled = false;
                btnRollDice.Text = "Roll";

                // Announce the winner(s)
                int highScore = _scoreSheet.GetWinningScore();
                string message;
                if (_scoreSheet.Players.Length > 1)
                {
                    string[] winners = _scoreSheet.GetWinningPlayers();
                    string winnersString = "";

                    // Decide how to display the list of winning players
                    if (winners.Length == 1)
                        winnersString = winners[0];
                    else if (winners.Length == 2)
                        winnersString = winners[0] + " and " + winners[1];
                    else
                    {
                        for (int i = 0; i < winners.Length - 1; i++)
                            winnersString += winners[i] + ", ";

                        winnersString += "and " + winners[winners.Length - 1];
                    }

                    message = winnersString + ((winners.Length > 1) ? " are tied"
                                                                    : " is the winner");

                    message += ", with a final score of " + highScore + " points!";
                }
                else
                {
                    message = "You have finished with a final score of " + highScore + " points.";
                }

                lblStatusMessage.Text = message;

                DialogResult drgo = MessageBox.Show(message + (char)13 + (char)13 +
                                                    "Would you like to play another game?",
                                                    "Game over",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

                if (drgo == DialogResult.Yes)
                {
                    _exitOnClose = false;
                    Close();
                }
            }
        }

        //

        private void mnuGame_New_Click(object sender, EventArgs e)
        {
            _exitOnClose = false;

            if (!GameOver())
            {
                DialogResult dr = MessageBox.Show("Are you sure you want "
                                                + "to start a new game session?",
                                                  "New game?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (dr == DialogResult.Yes) Close();
            }
            else Close();

            // If the user opts not to start a new game, reset the
            // exitOnClose value to its default state.
            _exitOnClose = true;
        }

        private void mnuGame_Load_Click(object sender, EventArgs e)
        {
            // Not yet available in this stage
        }

        private void mnuGame_Save_Click(object sender, EventArgs e)
        {
            // Not yet available in this stage
        }

        private void mnuGame_HighScores_Click(object sender, EventArgs e)
        {
            // Not yet available in this stage
        }

        private void mnuGame_Options_Click(object sender, EventArgs e)
        {
            // Not yet available in this stage
        }

        private void mnuGame_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuView_TouchMode_CheckedChanged(object sender, EventArgs e)
        {
            TouchMode = mnuView_TouchMode.Checked;
        }

        private void mnuHelp_Help_Click(object sender, EventArgs e)
        {
            if (!_fs.AppFileExists("help.html"))
                _fs.WriteFile("help.html", Properties.Resources.HelpManual);

            System.Diagnostics.Process.Start(_fs.AppDir + "\\help.html");
        }

        private void mnuHelp_Rules_Click(object sender, EventArgs e)
        {
            // Not yet available in this stage
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            AboutDialog d = new AboutDialog();
            d.ShowDialog();
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mnuHelp_Help.Enabled = btnHelp.Enabled = true;
        }
        #endregion
    }
}
