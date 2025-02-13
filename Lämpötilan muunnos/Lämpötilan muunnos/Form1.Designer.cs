namespace Lämpötilan_muunnos
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
            AsteetTB = new TextBox();
            groupBox1 = new GroupBox();
            FahrenheitRB = new RadioButton();
            CelsiusRB = new RadioButton();
            MuunnaBT = new Button();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 115);
            label1.Name = "label1";
            label1.Size = new Size(203, 50);
            label1.TabIndex = 0;
            label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(228, 112);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(125, 48);
            AsteetTB.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FahrenheitRB);
            groupBox1.Controls.Add(CelsiusRB);
            groupBox1.Location = new Point(374, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 219);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunnat?";
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Location = new Point(15, 107);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(198, 54);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Location = new Point(15, 47);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(147, 54);
            CelsiusRB.TabIndex = 0;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            MuunnaBT.Location = new Point(694, 135);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(174, 56);
            MuunnaBT.TabIndex = 3;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Poppins SemiBold", 24F, FontStyle.Bold);
            VastausLB.Location = new Point(24, 196);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(198, 70);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 330);
            Controls.Add(VastausLB);
            Controls.Add(MuunnaBT);
            Controls.Add(groupBox1);
            Controls.Add(AsteetTB);
            Controls.Add(label1);
            Font = new Font("Poppins SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Lämpötilan muunnos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AsteetTB;
        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelsiusRB;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}
