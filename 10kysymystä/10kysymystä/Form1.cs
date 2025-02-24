using System;
using System.Windows.Forms;

namespace _10kysymystä
{
    public partial class Form1 : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[11];
        public Form1()
        {
            InitializeComponent();
            ARB.CheckedChanged += new EventHandler(radioButton_CheckedChange);
            BRB.CheckedChanged += new EventHandler(radioButton_CheckedChange);
            CRB.CheckedChanged += new EventHandler(radioButton_CheckedChange);
            DRB.CheckedChanged += new EventHandler(radioButton_CheckedChange);
        }
        private void radioButton_CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "vastaus " + laskuri + ". kysymykseen:";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                ARB.Enabled = false;
                BRB.Enabled = false;
                CRB.Enabled = false;
                DRB.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;

            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if (ARB.Checked == true)
            {
                ARB.Checked = false;
                laskuri--;
            }
            if (BRB.Checked == true)
            {
                BRB.Checked = false;
                laskuri--;
            }
            if (CRB.Checked == true)
            {
                CRB.Checked = false;
                laskuri--;
            }
            if (DRB.Checked == true)
            {
                DRB.Checked = false;
                laskuri--;
            }
        }
    }
}
