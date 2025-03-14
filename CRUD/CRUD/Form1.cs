using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class YllapitoForm : Form
    {
        OPISKELIJAT opiskelijat = new OPISKELIJAT();

        public YllapitoForm()
        {
            InitializeComponent();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            etunimiTB.Text = "";
            sukunimiTB.Text = "";
            puhelinTB.Text = "";
            sahkopostiTB.Text = "";
            opiskelijanroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puh = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || opiskelijanroTB.Text.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Puhelin, Sähköposti ja Opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaOpiskelija = opiskelijat.LisaaOpiskelija(enimi, snimi, puh, email, oNro);
                if (lisaaOpiskelija)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Tietotaulu.DataSource = opiskelijat.HaeOpiskelijat();
        }

        private void paivitaTB_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puh = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int oNro = Int32.Parse(opiskelijanroTB.Text);
            int oid = Int32.Parse(idTB.Text);

            if (idTB.Text.Trim().Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || opiskelijanroTB.Text.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - OID, Etu- ja sukunimi, Puhelin, Sähköposti ja Opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaOpiskelija = opiskelijat.PaivitaOpiskelija(oid, enimi, snimi, puh, email, oNro);
                if (muokkaaOpiskelija)
                {
                    MessageBox.Show("Opiskelija muokattu onnistuneesti", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty muokkaamaan", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Tietotaulu.DataSource = opiskelijat.HaeOpiskelijat();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            int oid = Int32.Parse(idTB.Text);
            if (opiskelijat.PoistaOpiskelija(oid))
            {
                Tietotaulu.DataSource = opiskelijat.HaeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaTB.PerformClick();
        }

        private void YllapitoForm_Load(object sender, EventArgs e)
        {
            Tietotaulu.DataSource = opiskelijat.HaeOpiskelijat();
            Tietotaulu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }

        private void Tietotaulu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tietotaulu.CurrentRow != null)
            {
                etunimiTB.Text = Tietotaulu.CurrentRow.Cells[1].Value.ToString();
                sukunimiTB.Text = Tietotaulu.CurrentRow.Cells[2].Value.ToString();
                puhelinTB.Text = Tietotaulu.CurrentRow.Cells[3].Value.ToString();
                sahkopostiTB.Text = Tietotaulu.CurrentRow.Cells[4].Value.ToString();
                opiskelijanroTB.Text = Tietotaulu.CurrentRow.Cells[5].Value.ToString();
                idTB.Text = Tietotaulu.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
