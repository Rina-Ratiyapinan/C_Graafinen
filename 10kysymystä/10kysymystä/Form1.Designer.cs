namespace _10kysymystä
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
            KysymysLB = new Label();
            VastausLB = new Label();
            groupBox1 = new GroupBox();
            DRB = new RadioButton();
            CRB = new RadioButton();
            BRB = new RadioButton();
            ARB = new RadioButton();
            DummyRB = new RadioButton();
            ResultLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Location = new Point(40, 103);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(293, 36);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus 1. kysymykseen: ";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(40, 307);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(106, 36);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DRB);
            groupBox1.Controls.Add(CRB);
            groupBox1.Controls.Add(BRB);
            groupBox1.Controls.Add(ARB);
            groupBox1.Controls.Add(DummyRB);
            groupBox1.Location = new Point(352, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 249);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vastaus";
            // 
            // DRB
            // 
            DRB.AutoSize = true;
            DRB.Location = new Point(14, 183);
            DRB.Name = "DRB";
            DRB.Size = new Size(51, 40);
            DRB.TabIndex = 4;
            DRB.TabStop = true;
            DRB.Text = "D";
            DRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            CRB.AutoSize = true;
            CRB.Location = new Point(14, 137);
            CRB.Name = "CRB";
            CRB.Size = new Size(52, 40);
            CRB.TabIndex = 3;
            CRB.TabStop = true;
            CRB.Text = "C";
            CRB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            BRB.AutoSize = true;
            BRB.Location = new Point(14, 91);
            BRB.Name = "BRB";
            BRB.Size = new Size(50, 40);
            BRB.TabIndex = 2;
            BRB.TabStop = true;
            BRB.Text = "B";
            BRB.UseVisualStyleBackColor = true;
            // 
            // ARB
            // 
            ARB.AutoSize = true;
            ARB.Location = new Point(14, 45);
            ARB.Name = "ARB";
            ARB.Size = new Size(51, 40);
            ARB.TabIndex = 1;
            ARB.TabStop = true;
            ARB.Text = "A";
            ARB.UseVisualStyleBackColor = true;
            // 
            // DummyRB
            // 
            DummyRB.AutoCheck = false;
            DummyRB.AutoSize = true;
            DummyRB.Location = new Point(14, 45);
            DummyRB.Name = "DummyRB";
            DummyRB.Size = new Size(47, 40);
            DummyRB.TabIndex = 0;
            DummyRB.TabStop = true;
            DummyRB.Text = "E";
            DummyRB.UseVisualStyleBackColor = true;
            DummyRB.Visible = false;
            // 
            // ResultLB
            // 
            ResultLB.AutoSize = true;
            ResultLB.Location = new Point(49, 356);
            ResultLB.Name = "ResultLB";
            ResultLB.Size = new Size(0, 36);
            ResultLB.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 499);
            Controls.Add(ResultLB);
            Controls.Add(groupBox1);
            Controls.Add(VastausLB);
            Controls.Add(KysymysLB);
            Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox groupBox1;
        private RadioButton DummyRB;
        private RadioButton BRB;
        private RadioButton ARB;
        private RadioButton DRB;
        private RadioButton CRB;
        private Label ResultLB;
    }
}
