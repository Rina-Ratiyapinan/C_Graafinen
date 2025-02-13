using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceRollerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Heit‰BT_Click(object sender, EventArgs e)
        {
            piirraNoppa(Noppa01PB);
            piirraNoppa(Noppa02PB);
        }
        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch (noppa) 
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice1;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice2;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice3;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice4;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice5;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice6;
                    break;
            }
        }
    }
}
