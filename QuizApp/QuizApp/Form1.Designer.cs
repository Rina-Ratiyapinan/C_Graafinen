namespace QuizApp
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
            QuestionLB = new Label();
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbD = new RadioButton();
            rbC = new RadioButton();
            rbHidden = new RadioButton();
            NextBT = new Button();
            ResultLB = new Label();
            SuspendLayout();
            // 
            // QuestionLB
            // 
            QuestionLB.AutoSize = true;
            QuestionLB.Location = new Point(52, 41);
            QuestionLB.Name = "QuestionLB";
            QuestionLB.Size = new Size(156, 50);
            QuestionLB.TabIndex = 0;
            QuestionLB.Text = "Kysymus";
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(62, 131);
            rbA.Name = "rbA";
            rbA.Size = new Size(79, 54);
            rbA.TabIndex = 1;
            rbA.TabStop = true;
            rbA.Text = "A)";
            rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Location = new Point(62, 191);
            rbB.Name = "rbB";
            rbB.Size = new Size(77, 54);
            rbB.TabIndex = 2;
            rbB.TabStop = true;
            rbB.Text = "B)";
            rbB.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            rbD.AutoSize = true;
            rbD.Location = new Point(62, 311);
            rbD.Name = "rbD";
            rbD.Size = new Size(79, 54);
            rbD.TabIndex = 4;
            rbD.TabStop = true;
            rbD.Text = "D)";
            rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(62, 251);
            rbC.Name = "rbC";
            rbC.Size = new Size(81, 54);
            rbC.TabIndex = 3;
            rbC.TabStop = true;
            rbC.Text = "C)";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbHidden
            // 
            rbHidden.AutoCheck = false;
            rbHidden.AutoSize = true;
            rbHidden.Location = new Point(62, 361);
            rbHidden.Name = "rbHidden";
            rbHidden.Size = new Size(125, 54);
            rbHidden.TabIndex = 5;
            rbHidden.TabStop = true;
            rbHidden.Text = "Reset";
            rbHidden.UseVisualStyleBackColor = true;
            rbHidden.Visible = false;
            // 
            // NextBT
            // 
            NextBT.Location = new Point(204, 426);
            NextBT.Name = "NextBT";
            NextBT.Size = new Size(363, 61);
            NextBT.TabIndex = 6;
            NextBT.Text = "Seuraava kysymys";
            NextBT.UseVisualStyleBackColor = true;
            NextBT.Click += NextBT_Click;
            // 
            // ResultLB
            // 
            ResultLB.AutoSize = true;
            ResultLB.Location = new Point(52, 515);
            ResultLB.Name = "ResultLB";
            ResultLB.Size = new Size(0, 50);
            ResultLB.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 574);
            Controls.Add(ResultLB);
            Controls.Add(NextBT);
            Controls.Add(rbHidden);
            Controls.Add(rbD);
            Controls.Add(rbC);
            Controls.Add(rbB);
            Controls.Add(rbA);
            Controls.Add(QuestionLB);
            Font = new Font("Poppins Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Quiz game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionLB;
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbD;
        private RadioButton rbC;
        private RadioButton rbHidden;
        private Button NextBT;
        private Label ResultLB;
    }
}
