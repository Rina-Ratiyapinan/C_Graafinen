using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Harjoitus2
{
    partial class Harjoitus2
    {
        // Auto-generated designer code...
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new System.Drawing.Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OtsikkoLB.Location = new Point(23, 111);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(375, 44);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new System.Drawing.Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TulostusLB.Location = new Point(23, 168);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(96, 44);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new System.Drawing.Font("Segoe UI", 16F);
            ViestiTB.Location = new Point(395, 112);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(393, 43);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Location = new Point(607, 173);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(181, 39);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Harjoitus2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Harjoitus2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}
