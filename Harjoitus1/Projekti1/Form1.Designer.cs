namespace Projekti1
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
            tekstiLB = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tekstiLB
            // 
            tekstiLB.Location = new Point(252, 136);
            tekstiLB.Name = "tekstiLB";
            tekstiLB.Size = new Size(125, 27);
            tekstiLB.TabIndex = 0;
            tekstiLB.Text = "Jotain uuttaa tekstia";
            tekstiLB.TextChanged += tekstiLB_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(283, 229);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tekstiLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tekstiLB;
        private Button button1;
    }
}
