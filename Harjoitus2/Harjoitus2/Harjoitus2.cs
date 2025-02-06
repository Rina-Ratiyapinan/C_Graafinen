using System;
using System.Windows.Forms;

namespace Harjoitus2
{
    public partial class Harjoitus2 : Form
    {
        public Harjoitus2()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            TulostusLB.Text = ViestiTB.Text;
            TulostusLB.Visible = true;
        }
    }
}
