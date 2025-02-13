using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, painoindeksi;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            painoindeksi = Math.Round(paino / (pituus * pituus), 2);

            VastausLB.Visible = true;
            KuvastusLB.Visible = true;

            if (painoindeksi < 18.5)
            {
                VastausLB.Text = "Painoindeksi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Aqua;
                KuvastusLB.Text = "Alipaino";
                KuvastusLB.ForeColor = Color.Aqua;
            }
            else if (painoindeksi < 25)
            {
                VastausLB.Text = "Painoindeksi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Green;
                KuvastusLB.Text = "Normaalipaino";
                KuvastusLB.ForeColor = Color.Green;
            }
            else if (painoindeksi < 30)
            {
                VastausLB.Text = "Painoindeksi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Gold;
                KuvastusLB.Text = "Ylipaino";
                KuvastusLB.ForeColor = Color.Gold;
            }
            else
            {
                VastausLB.Text = "Painoindeksi on: " + painoindeksi;
                VastausLB.ForeColor = Color.Red;
                KuvastusLB.Text = "Huomattava ylipaino";
                KuvastusLB.ForeColor = Color.Red;
            }

        }
    }
}
