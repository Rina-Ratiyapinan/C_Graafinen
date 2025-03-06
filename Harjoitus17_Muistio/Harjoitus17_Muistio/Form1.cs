using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Harjoitus17_Muistio
{
    public partial class Form1 : Form
    {
        private string tiedostoPolku = "";

        public Form1()
        {
            InitializeComponent();
        }
        // Tiedosto menu
        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TekstilaatikkoRTB.Rtf != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                TekstilaatikkoRTB.Rtf = "";
            }
            else 
            {
                TekstilaatikkoRTB.Rtf = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "Text Documents|*.txt|Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        //only read Rtf not txt file
                        TekstilaatikkoRTB.Rtf = teksti.Result;
                    }
                }
            }
        }
        private async void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostoPolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        tiedostoPolku = ttk.FileName;
                        using (StreamWriter tiedosto = new StreamWriter(ttk.FileName, false))
                        {
                            await tiedosto.WriteAsync(this.TekstilaatikkoRTB.Rtf);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostoPolku, false))
                {
                    await vk.WriteAsync(TekstilaatikkoRTB.Rtf);
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt|RichTextFormat|*.rtf", ValidateNames = true})
            { 
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja =  new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLine(TekstilaatikkoRTB.Rtf);
                    }
                }
            }
        }

        private void tulostuksenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            TekstilaatikkoRTB.Clear();
        }
        // Muokkaa menu
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Cut();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }
        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectAll();
        }

        //Muotoile menu
        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKotostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.SelectionLength > 0)
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        TekstilaatikkoRTB.SelectionBackColor = colorDialog.Color;
                    }
                }
            }
            else
            {
                MessageBox.Show("Valitse ensin teksti, jonka haluat korostaa.", "Ei valittua tekstiä", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tekstinRivittysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivittysToolStripMenuItem.Checked == true)
            {
                tekstinRivittysToolStripMenuItem.Checked = false;
                TekstilaatikkoRTB.WordWrap = false;
            }
            else
            {
                tekstinRivittysToolStripMenuItem.Checked = true;
                TekstilaatikkoRTB.WordWrap = true;
            }
        }
        //Apua menu
        private void tietoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tietoa tietoa = new Tietoa();
            tietoa.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstilaatikkoRTB.Rtf, TekstilaatikkoRTB.Font, Brushes.Black, 12, 10);
        }

        private void TekstilaatikkoRTB_TextChanged(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.Rtf.Length > 0)
            {
                copyToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }
    }
}
