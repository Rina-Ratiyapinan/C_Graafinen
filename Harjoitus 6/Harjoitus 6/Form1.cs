using System;
using System.Windows.Forms;

namespace Harjoitus_6
{
    public partial class SalasanaForm : Form
    {
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "password123";

        public SalasanaForm()
        {
            InitializeComponent();
            SalasanaOikeinPanel.Visible = false; 
            label3.Visible = false;
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == CorrectUsername && textBox2.Text == CorrectPassword)
            {
                SalasanaPanel.Visible = false; 
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                label3.Text = "Käyttäjätunnus tai salasana virheellinen!"; 
                label3.Visible = true;
            }
        }
    }
}
