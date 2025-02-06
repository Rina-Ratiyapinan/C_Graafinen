namespace Projekti1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tekstiLB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (tekstiLB.Text == "Heippa maailma!")
                {
                    tekstiLB.Text = "Jotain uuttaa tekstia";
                }
                else
                {
                    tekstiLB.Text = "Heippa maailma!";
                }
            }

        }
    }
}
