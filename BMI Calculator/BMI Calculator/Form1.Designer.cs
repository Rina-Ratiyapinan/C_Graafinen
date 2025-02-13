namespace BMI_Calculator
{
    partial class Form1
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
            label2 = new Label();
            VastausLB = new Label();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            LaskeBT = new Button();
            KuvastusLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 89);
            label1.Name = "label1";
            label1.Size = new Size(232, 40);
            label1.TabIndex = 0;
            label1.Text = "Anna paino (kg):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 159);
            label2.Name = "label2";
            label2.Size = new Size(232, 40);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus (m):";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(97, 298);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(120, 40);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // PainoTB
            // 
            PainoTB.Location = new Point(345, 86);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(125, 42);
            PainoTB.TabIndex = 3;
            // 
            // PituusTB
            // 
            PituusTB.Location = new Point(345, 156);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(125, 42);
            PituusTB.TabIndex = 4;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(97, 227);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(373, 49);
            LaskeBT.TabIndex = 5;
            LaskeBT.Text = "Laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // KuvastusLB
            // 
            KuvastusLB.AutoSize = true;
            KuvastusLB.Location = new Point(97, 338);
            KuvastusLB.Name = "KuvastusLB";
            KuvastusLB.Size = new Size(132, 40);
            KuvastusLB.TabIndex = 6;
            KuvastusLB.Text = "Kuvastus";
            KuvastusLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 421);
            Controls.Add(KuvastusLB);
            Controls.Add(LaskeBT);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(VastausLB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "BMI-Laskeri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label VastausLB;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button LaskeBT;
        private Label KuvastusLB;
    }
}
