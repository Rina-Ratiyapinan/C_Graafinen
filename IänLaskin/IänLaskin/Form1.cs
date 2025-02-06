namespace IänLaskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttari = synttariDT.Value;

            double erotus = Math.Round((nyt - synttari).TotalDays);
            double vuodet = Math.Floor(erotus / 365.25);
            double kuukaudet = Math.Floor(erotus / 30.44);
            double tunnit = erotus * 24;
            double minuutit = tunnit * 60;
            double sekunnit = minuutit * 60;

            VuodetLB.Text = "Ikä vuosina: " + vuodet + " vuotta";
            KuukaudetLB.Text = "Ikä kuukausina: " + kuukaudet + " kuukautta";
            PaivatLB.Text = "Ikä päivinä: " + erotus + " päivää";
            TunnitLB.Text = "Ikä tuneina: " + tunnit + " tuntia";
            MinuutitLB.Text = "Ikä minuutteina: " + minuutit + " minuuttia";
            SekunnitLB.Text = "Ikä sekunteina: " + sekunnit + " sekuntia";

            VuodetLB.Visible = true;
            KuukaudetLB.Visible= true;
            PaivatLB.Visible = true;
            TunnitLB.Visible = true;
            MinuutitLB.Visible = true;
            SekunnitLB.Visible = true;

        }
    }
}
