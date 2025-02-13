namespace Autokululaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutuksetTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            energia = Convert.ToDouble(PolttonNesteTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + energia + muut) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometria kohti ovat: " + kustannukset;
            VastausLB.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
