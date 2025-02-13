namespace DiceRollerApp
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
            label2 = new Label();
            Noppa01PB = new PictureBox();
            Noppa02PB = new PictureBox();
            HeitäBT = new Button();
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20F);
            label2.Location = new Point(95, 45);
            label2.Name = "label2";
            label2.Size = new Size(264, 43);
            label2.TabIndex = 1;
            label2.Text = "Nopan heitto";
            // 
            // Noppa01PB
            // 
            Noppa01PB.Image = Properties.Resources.dice1;
            Noppa01PB.Location = new Point(77, 110);
            Noppa01PB.Name = "Noppa01PB";
            Noppa01PB.Size = new Size(125, 120);
            Noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa01PB.TabIndex = 2;
            Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            Noppa02PB.Image = Properties.Resources.dice1;
            Noppa02PB.Location = new Point(234, 110);
            Noppa02PB.Name = "Noppa02PB";
            Noppa02PB.Size = new Size(125, 120);
            Noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa02PB.TabIndex = 3;
            Noppa02PB.TabStop = false;
            // 
            // HeitäBT
            // 
            HeitäBT.Location = new Point(77, 262);
            HeitäBT.Name = "HeitäBT";
            HeitäBT.Size = new Size(282, 53);
            HeitäBT.TabIndex = 4;
            HeitäBT.Text = "Heitä";
            HeitäBT.UseVisualStyleBackColor = true;
            HeitäBT.Click += HeitäBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 417);
            Controls.Add(HeitäBT);
            Controls.Add(Noppa02PB);
            Controls.Add(Noppa01PB);
            Controls.Add(label2);
            Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
        private Button HeitäBT;
    }
}
