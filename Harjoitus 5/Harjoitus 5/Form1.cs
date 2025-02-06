using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Harjoitus_5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();

        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    jono.Sort();
                    foreach (var jasen in jono)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                    uusiLukuTB.Clear();
                }
                else
                {
                    if (int.TryParse(uusiLukuTB.Text, out int luku))
                    {
                        jono.Add(luku);
                        uusiLukuTB.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Virheellinen syöte. Anna luku.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }

        private void TyhjaaLomake()
        {
            uusiLukuTB.Clear();
        }
    }
}