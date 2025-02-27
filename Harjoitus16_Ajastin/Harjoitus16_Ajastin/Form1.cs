using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus16_Ajastin
{
    public partial class CountDownForm : Form
    {
        private int kokonaisaika;
        public CountDownForm()
        {
            InitializeComponent();
        }

        private void CountDownForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString());
                SekunnitCB.Items.Add(i.ToString());
            }
            MinuutitCB.SelectedIndex = 0;
            SekunnitCB.SelectedIndex = 10;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled =false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika % 60;
                AikaLB.Text = minuutit.ToString("D2") + ":" + sekunnit.ToString("D2");
            }
            else 
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
