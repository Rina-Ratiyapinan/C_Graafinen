namespace IänLaskin
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
            synttariDT = new DateTimePicker();
            LaskeBT = new Button();
            VuodetLB = new Label();
            KuukaudetLB = new Label();
            PaivatLB = new Label();
            SekunnitLB = new Label();
            MinuutitLB = new Label();
            TunnitLB = new Label();
            SuspendLayout();
            // 
            // synttariDT
            // 
            synttariDT.Font = new Font("Segoe UI", 16F);
            synttariDT.Location = new Point(261, 141);
            synttariDT.Name = "synttariDT";
            synttariDT.Size = new Size(468, 43);
            synttariDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI", 16F);
            LaskeBT.Location = new Point(772, 141);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(101, 43);
            LaskeBT.TabIndex = 1;
            LaskeBT.Text = "Laske ikä";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VuodetLB
            // 
            VuodetLB.AutoSize = true;
            VuodetLB.Font = new Font("Segoe UI", 16F);
            VuodetLB.Location = new Point(261, 217);
            VuodetLB.Name = "VuodetLB";
            VuodetLB.Size = new Size(162, 37);
            VuodetLB.TabIndex = 2;
            VuodetLB.Text = "Ikä vuosina: ";
            VuodetLB.Visible = false;
            // 
            // KuukaudetLB
            // 
            KuukaudetLB.AutoSize = true;
            KuukaudetLB.Font = new Font("Segoe UI", 16F);
            KuukaudetLB.Location = new Point(261, 268);
            KuukaudetLB.Name = "KuukaudetLB";
            KuukaudetLB.Size = new Size(196, 37);
            KuukaudetLB.TabIndex = 3;
            KuukaudetLB.Text = "Ikä kuukausina:";
            KuukaudetLB.Visible = false;
            // 
            // PaivatLB
            // 
            PaivatLB.AutoSize = true;
            PaivatLB.Font = new Font("Segoe UI", 16F);
            PaivatLB.Location = new Point(261, 316);
            PaivatLB.Name = "PaivatLB";
            PaivatLB.Size = new Size(150, 37);
            PaivatLB.TabIndex = 4;
            PaivatLB.Text = "Ikä päivinä:";
            PaivatLB.Visible = false;
            // 
            // SekunnitLB
            // 
            SekunnitLB.AutoSize = true;
            SekunnitLB.Font = new Font("Segoe UI", 16F);
            SekunnitLB.Location = new Point(261, 460);
            SekunnitLB.Name = "SekunnitLB";
            SekunnitLB.Size = new Size(191, 37);
            SekunnitLB.TabIndex = 7;
            SekunnitLB.Text = "Ikä sekunteina:";
            SekunnitLB.Visible = false;
            // 
            // MinuutitLB
            // 
            MinuutitLB.AutoSize = true;
            MinuutitLB.Font = new Font("Segoe UI", 16F);
            MinuutitLB.Location = new Point(261, 414);
            MinuutitLB.Name = "MinuutitLB";
            MinuutitLB.Size = new Size(207, 37);
            MinuutitLB.TabIndex = 6;
            MinuutitLB.Text = "Ikä minuutteina:";
            MinuutitLB.Visible = false;
            // 
            // TunnitLB
            // 
            TunnitLB.AutoSize = true;
            TunnitLB.Font = new Font("Segoe UI", 16F);
            TunnitLB.Location = new Point(261, 364);
            TunnitLB.Name = "TunnitLB";
            TunnitLB.Size = new Size(169, 37);
            TunnitLB.TabIndex = 5;
            TunnitLB.Text = "Ikä tunteina: ";
            TunnitLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 702);
            Controls.Add(SekunnitLB);
            Controls.Add(MinuutitLB);
            Controls.Add(TunnitLB);
            Controls.Add(PaivatLB);
            Controls.Add(KuukaudetLB);
            Controls.Add(VuodetLB);
            Controls.Add(LaskeBT);
            Controls.Add(synttariDT);
            Name = "Form1";
            Text = "Iän laskeminen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker synttariDT;
        private Button LaskeBT;
        private Label VuodetLB;
        private Label KuukaudetLB;
        private Label PaivatLB;
        private Label SekunnitLB;
        private Label MinuutitLB;
        private Label TunnitLB;
    }
}
