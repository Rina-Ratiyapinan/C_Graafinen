namespace Autokululaskuri
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
            label3 = new Label();
            label4 = new Label();
            VastausLB = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            LainaTB = new TextBox();
            NesteetTB = new TextBox();
            VakuutuksetTB = new TextBox();
            MuutKulutTB = new TextBox();
            PolttonNesteTB = new TextBox();
            RenkaatTB = new TextBox();
            HuollotTB = new TextBox();
            PesutTB = new TextBox();
            KilometritCB = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 37);
            label1.TabIndex = 0;
            label1.Text = "Auton kustannuslaskuri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 18F);
            label2.Location = new Point(170, 173);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(360, 37);
            label2.TabIndex = 1;
            label2.Text = "Lainan lyhennys korkoineen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 18F);
            label3.Location = new Point(170, 245);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(334, 37);
            label3.TabIndex = 3;
            label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ink Free", 18F);
            label4.Location = new Point(170, 316);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(224, 37);
            label4.TabIndex = 5;
            label4.Text = "Vakutusmaksut:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Ink Free", 18F);
            VastausLB.Location = new Point(170, 529);
            VastausLB.Margin = new Padding(5, 0, 5, 0);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(121, 37);
            VastausLB.TabIndex = 11;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ink Free", 18F);
            label6.Location = new Point(170, 458);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(172, 37);
            label6.TabIndex = 9;
            label6.Text = "Polttoneste:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ink Free", 18F);
            label7.Location = new Point(170, 386);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(167, 37);
            label7.TabIndex = 7;
            label7.Text = "Muut kulut:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ink Free", 18F);
            label8.Location = new Point(735, 389);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(226, 37);
            label8.TabIndex = 18;
            label8.Text = "Kilometrit/vuosi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Ink Free", 18F);
            label9.Location = new Point(735, 320);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(132, 37);
            label9.TabIndex = 16;
            label9.Text = "Renkaat:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Ink Free", 18F);
            label10.Location = new Point(735, 249);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 37);
            label10.TabIndex = 14;
            label10.Text = "Huollot:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Ink Free", 18F);
            label11.Location = new Point(735, 176);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(97, 37);
            label11.TabIndex = 12;
            label11.Text = "Pesut:";
            // 
            // LainaTB
            // 
            LainaTB.Location = new Point(545, 179);
            LainaTB.Name = "LainaTB";
            LainaTB.Size = new Size(125, 36);
            LainaTB.TabIndex = 20;
            // 
            // NesteetTB
            // 
            NesteetTB.Location = new Point(545, 246);
            NesteetTB.Name = "NesteetTB";
            NesteetTB.Size = new Size(125, 36);
            NesteetTB.TabIndex = 21;
            // 
            // VakuutuksetTB
            // 
            VakuutuksetTB.Location = new Point(545, 317);
            VakuutuksetTB.Name = "VakuutuksetTB";
            VakuutuksetTB.Size = new Size(125, 36);
            VakuutuksetTB.TabIndex = 22;
            // 
            // MuutKulutTB
            // 
            MuutKulutTB.Location = new Point(545, 389);
            MuutKulutTB.Name = "MuutKulutTB";
            MuutKulutTB.Size = new Size(125, 36);
            MuutKulutTB.TabIndex = 23;
            // 
            // PolttonNesteTB
            // 
            PolttonNesteTB.Location = new Point(545, 458);
            PolttonNesteTB.Name = "PolttonNesteTB";
            PolttonNesteTB.Size = new Size(125, 36);
            PolttonNesteTB.TabIndex = 24;
            // 
            // RenkaatTB
            // 
            RenkaatTB.Location = new Point(1004, 321);
            RenkaatTB.Name = "RenkaatTB";
            RenkaatTB.Size = new Size(125, 36);
            RenkaatTB.TabIndex = 27;
            // 
            // HuollotTB
            // 
            HuollotTB.Location = new Point(1004, 250);
            HuollotTB.Name = "HuollotTB";
            HuollotTB.Size = new Size(125, 36);
            HuollotTB.TabIndex = 26;
            // 
            // PesutTB
            // 
            PesutTB.Location = new Point(1004, 183);
            PesutTB.Name = "PesutTB";
            PesutTB.Size = new Size(125, 36);
            PesutTB.TabIndex = 25;
            // 
            // KilometritCB
            // 
            KilometritCB.FormattingEnabled = true;
            KilometritCB.Items.AddRange(new object[] { "5000", "10000", "15000", "20000", "25000", "30000", "35000", "40000", "45000", "50000", "55000", "60000", "65000", "70000", "75000", "80000", "85000", "90000", "95000", "100000", "", "", "" });
            KilometritCB.Location = new Point(1006, 389);
            KilometritCB.Name = "KilometritCB";
            KilometritCB.Size = new Size(168, 37);
            KilometritCB.TabIndex = 28;
            KilometritCB.SelectedIndexChanged += KilometritCB_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 652);
            Controls.Add(KilometritCB);
            Controls.Add(RenkaatTB);
            Controls.Add(HuollotTB);
            Controls.Add(PesutTB);
            Controls.Add(PolttonNesteTB);
            Controls.Add(MuutKulutTB);
            Controls.Add(VakuutuksetTB);
            Controls.Add(NesteetTB);
            Controls.Add(LainaTB);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(VastausLB);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Ink Free", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Kilometrikulutuslaskuri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox LainaTB;
        private TextBox NesteetTB;
        private TextBox VakuutuksetTB;
        private TextBox MuutKulutTB;
        private TextBox PolttonNesteTB;
        private TextBox RenkaatTB;
        private TextBox HuollotTB;
        private TextBox PesutTB;
        private ComboBox KilometritCB;
        private Label VastausLB;
    }
}
