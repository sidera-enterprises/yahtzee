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
    public partial class Die : UserControl
    {
        #region Initialization
        private Color _backColor,
                      _checkedColor;

        private bool _checked;
        private int _value;
        public Die()
        {
            InitializeComponent();

            BackColor = Color.White;
            CheckedColor = SystemColors.Highlight; // Color.FromArgb(255, 255, 192);

            Checked = false;

            pnlBorder.BackColor = pnlFace.BackColor = Color.Transparent;
            pnlFace.BackgroundImage = null;

            Value = 0;
            // Roll(); // Value = 1;
        }
        #endregion
        
        #region Public properties
        public new Color BackColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                if (!Checked) pnlFace.BackColor = value;
            }
        }

        public Color CheckedColor
        {
            get { return _checkedColor; }
            set
            {
                _checkedColor = value;
                if (Checked) pnlFace.BackColor = value;
            }
        }

        public bool Checked
        {
            get { return _checked; }
            set
            {
                bool old = _checked;

                _checked = (Value > 0) && value;
                pnlFace.BackColor = (Value > 0) ? (_checked ? CheckedColor : BackColor)
                                                : Color.Transparent;

                if (old != value) OnCheckedChanged(EventArgs.Empty);
            }
        }

        public int Value
        {
            get { return _value; }
            set
            {
                if (value >= 0 && value <= 6)
                {
                    _value = value;

                    if (value == 0)
                    {
                        Checked = false;

                        pnlBorder.BackColor = Color.Transparent;
                        pnlFace.BackColor = Color.Transparent;
                        pnlFace.BackgroundImage = null;
                        pnlFace.Cursor = Cursors.Default;
                    }
                    else
                    {
                        pnlBorder.BackColor = Color.Black;
                        pnlFace.BackColor = Checked ? CheckedColor : BackColor;
                        pnlFace.Cursor = Cursors.Hand;

                        SetFaceImage();
                    }
                }
                else throw new Exception("Value must be between 0 and 6.");

                OnValueChanged(EventArgs.Empty);
            }
        }
        #endregion

        #region Public methods
        /*public void Roll()
        {
            Random rand = new Random();
            Value = rand.Next(1, 7);
        }*/
        #endregion

        #region Private methods
        private void SetFaceImage()
        {
            Color bgcolor = pnlFace.BackColor;
            int value = Value;
            bool white = (bgcolor == Color.White);

            Image one = white ? Properties.Resources.BlackOne : Properties.Resources.WhiteOne,
                  two = white ? Properties.Resources.BlackTwo : Properties.Resources.WhiteTwo,
                  three = white ? Properties.Resources.BlackThree : Properties.Resources.WhiteThree,
                  four = white ? Properties.Resources.BlackFour : Properties.Resources.WhiteFour,
                  five = white ? Properties.Resources.BlackFive : Properties.Resources.WhiteFive,
                  six = white ? Properties.Resources.BlackSix : Properties.Resources.WhiteSix;

            switch (value)
            {
                case 1:
                    pnlFace.BackgroundImage = one;
                    break;
                case 2:
                    pnlFace.BackgroundImage = two;
                    break;
                case 3:
                    pnlFace.BackgroundImage = three;
                    break;
                case 4:
                    pnlFace.BackgroundImage = four;
                    break;
                case 5:
                    pnlFace.BackgroundImage = five;
                    break;
                case 6:
                    pnlFace.BackgroundImage = six;
                    break;
                //default:
                    //throw new Exception("Value must be between 1 and 6.");
            }
        }
        #endregion

        #region Public event handlers
        public delegate void CheckedChangedEventHandler(object sender, EventArgs e);
        public event CheckedChangedEventHandler CheckedChanged;
        protected virtual void OnCheckedChanged(EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }

        public delegate void ValueChangedEventHandler(object sender, EventArgs e);
        public event ValueChangedEventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
        #endregion

        #region Private events
        private void pnlFace_BackColorChanged(object sender, EventArgs e)
        {
            SetFaceImage();
        }

        private void pnlFace_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Checked = !Checked;
        }
        #endregion
    }
}
