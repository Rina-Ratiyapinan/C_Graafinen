namespace Roomalaiset_nrot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            TekstiTB = new TextBox();
            VastausLB = new Label();
            MuutaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(310, 29);
            label1.Name = "label1";
            label1.Size = new Size(842, 111);
            label1.TabIndex = 0;
            label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(311, 173);
            label2.Name = "label2";
            label2.Size = new Size(707, 32);
            label2.TabIndex = 1;
            label2.Text = "Annan numero välillä 1 - 3999, niin muutan sen roomaliaseksi:";
            // 
            // TekstiTB
            // 
            TekstiTB.Location = new Point(1027, 171);
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(125, 40);
            TekstiTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.BackColor = Color.Transparent;
            VastausLB.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VastausLB.ForeColor = SystemColors.ControlLightLight;
            VastausLB.Location = new Point(311, 228);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(173, 55);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            MuutaBT.BackColor = Color.White;
            MuutaBT.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MuutaBT.ForeColor = SystemColors.ActiveCaptionText;
            MuutaBT.Location = new Point(1028, 235);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(124, 42);
            MuutaBT.TabIndex = 4;
            MuutaBT.Text = "Muuta";
            MuutaBT.UseVisualStyleBackColor = false;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1400, 349);
            Controls.Add(MuutaBT);
            Controls.Add(VastausLB);
            Controls.Add(TekstiTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Numeroiden muutos arabialaisista roomalaisiksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TekstiTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}
