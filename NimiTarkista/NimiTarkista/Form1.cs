using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace NimiTarkista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;

            string[] pojat = File.ReadAllLines("C:/Users/rinar/source/repos/C_Graafinen/NimiTarkista/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/rinar/source/repos/C_Graafinen/NimiTarkista/tyt�t.txt");
            string nimi = NimiTB.Text;

            int laskurip = 1;
            int laskurit = 1;

            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = $"Nimesi on {laskurip}. suosituin poikien nimi vuonna 2023";
                    VastausLB.Visible = true;
                    return;
                }
                laskurip++;
            }

            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    VastausLB.Text = $"Nimesi on {laskurit}. suosituin tytt�jen nimi vuonna 2023";
                    VastausLB.Visible = true;
                    return;
                }
                laskurit++;  // Corrected counter increment
            }

            if (!VastausLB.Visible)
            {
                VastausLB.Text = "Nimesi ei l�ytynyt suosituimpien nimien joukosta! :-(";
                VastausLB.Visible = true;
            }
        }
    }
}
