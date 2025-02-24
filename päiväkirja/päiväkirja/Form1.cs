using System;
using System.IO;
using System.Windows.Forms;

namespace päiväkirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\rinar\\source\\repos\\C_Graafinen\\päiväkirja\\demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\rinar\\source\\repos\\C_Graafinen\\päiväkirja\\demo.txt");
            text.WriteLine(teksti);
            MessageBox.Show("Päiväkirjamerkintä tallennettu!");
            text.Close();
            Application.Exit();
        }
    }
}
