using System.Diagnostics.CodeAnalysis;

namespace Lämpötilan_muunnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " °C  on " + vastaus + " °F";
                VastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked)
            {
                vastaus = (asteet + 32) / 1.8;
                VastausLB.Text = asteet + " °F on " + vastaus + " °C";
                VastausLB.Visible = true;
            }
            else 
            {
                VastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                VastausLB.Visible = true;
            }
        }
    }
}
