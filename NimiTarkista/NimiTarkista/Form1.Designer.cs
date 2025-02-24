namespace NimiTarkista
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
            NimiTB = new TextBox();
            VastausLB = new Label();
            TarkastaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(833, 40);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa: ";
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(870, 47);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(269, 42);
            NimiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(31, 116);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(120, 40);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Location = new Point(870, 111);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(269, 51);
            TarkastaBT.TabIndex = 3;
            TarkastaBT.Text = "Tarkasta";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 266);
            Controls.Add(TarkastaBT);
            Controls.Add(VastausLB);
            Controls.Add(NimiTB);
            Controls.Add(label1);
            Font = new Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Onko nimesi suosittujen joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NimiTB;
        private Label VastausLB;
        private Button TarkastaBT;
    }
}
