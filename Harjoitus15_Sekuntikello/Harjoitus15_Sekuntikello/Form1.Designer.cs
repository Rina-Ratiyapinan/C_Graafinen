namespace Harjoitus15_Sekuntikello
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
            components = new System.ComponentModel.Container();
            AikaLB = new Label();
            StartBT = new Button();
            ResetBT = new Button();
            StopBT = new Button();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold);
            AikaLB.Location = new Point(109, 87);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(419, 89);
            AikaLB.TabIndex = 0;
            AikaLB.Text = "00:00:00.000";
            // 
            // StartBT
            // 
            StartBT.Location = new Point(109, 217);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(106, 46);
            StartBT.TabIndex = 1;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // ResetBT
            // 
            ResetBT.Location = new Point(422, 217);
            ResetBT.Name = "ResetBT";
            ResetBT.Size = new Size(106, 46);
            ResetBT.TabIndex = 2;
            ResetBT.Text = "Reset";
            ResetBT.UseVisualStyleBackColor = true;
            ResetBT.Click += ResetBT_Click;
            // 
            // StopBT
            // 
            StopBT.Location = new Point(268, 217);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(106, 46);
            StopBT.TabIndex = 3;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // AjastinTM
            // 
            AjastinTM.Enabled = true;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 336);
            Controls.Add(StopBT);
            Controls.Add(ResetBT);
            Controls.Add(StartBT);
            Controls.Add(AikaLB);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Sekuntikello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AikaLB;
        private Button StartBT;
        private Button ResetBT;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
