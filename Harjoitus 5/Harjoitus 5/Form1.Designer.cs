namespace Harjoitus_5
{
    partial class LukujenJarjestys
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            VastausLB = new Label();
            uusiLukuTB = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(82, 109);
            label1.Name = "label1";
            label1.Size = new Size(350, 41);
            label1.TabIndex = 0;
            label1.Text = "Anna luku (-999 lopetus):";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 18F);
            VastausLB.Location = new Point(82, 177);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(97, 41);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "label1";
            VastausLB.Visible = false;
            // 
            // uusiLukuTB
            // 
            uusiLukuTB.Font = new Font("Segoe UI", 18F);
            uusiLukuTB.Location = new Point(438, 109);
            uusiLukuTB.Name = "uusiLukuTB";
            uusiLukuTB.Size = new Size(164, 47);
            uusiLukuTB.TabIndex = 2;
            uusiLukuTB.KeyPress += uusiLukuTB_KeyPress;
            // 
            // LukujenJarjestys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uusiLukuTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Name = "LukujenJarjestys";
            Text = "Lukujen järjestys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox uusiLukuTB;
    }
}
