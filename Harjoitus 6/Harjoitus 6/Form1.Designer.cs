namespace Harjoitus_6
{
    partial class SalasanaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            SalasanaPanel = new Panel();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SalasanaOikeinPanel = new Panel();
            tervetuloaLabel = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(label3);
            SalasanaPanel.Controls.Add(button1);
            SalasanaPanel.Controls.Add(textBox2);
            SalasanaPanel.Controls.Add(textBox1);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe UI", 18F);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(1004, 668);
            SalasanaPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 270);
            label3.Name = "label3";
            label3.Size = new Size(107, 48);
            label3.TabIndex = 5;
            label3.Text = "Virhe";
            label3.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(624, 196);
            button1.Name = "button1";
            button1.Size = new Size(180, 54);
            button1.TabIndex = 4;
            button1.Text = "Tarkista";
            button1.UseVisualStyleBackColor = false;
            button1.Click += TarkistaBT_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(489, 130);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(315, 47);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(489, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 47);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(284, 129);
            label2.Name = "label2";
            label2.Size = new Size(169, 48);
            label2.TabIndex = 1;
            label2.Text = "Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 69);
            label1.Name = "label1";
            label1.Size = new Size(273, 48);
            label1.TabIndex = 0;
            label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.DarkRed;
            SalasanaOikeinPanel.Controls.Add(tervetuloaLabel);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(1004, 668);
            SalasanaOikeinPanel.TabIndex = 6;
            SalasanaOikeinPanel.Visible = false;
            // 
            // tervetuloaLabel
            // 
            tervetuloaLabel.AutoSize = true;
            tervetuloaLabel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic);
            tervetuloaLabel.ForeColor = Color.Snow;
            tervetuloaLabel.Location = new Point(150, 161);
            tervetuloaLabel.Name = "tervetuloaLabel";
            tervetuloaLabel.Size = new Size(721, 99);
            tervetuloaLabel.TabIndex = 0;
            tervetuloaLabel.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 668);
            Controls.Add(SalasanaPanel);
            Controls.Add(SalasanaOikeinPanel);
            Name = "SalasanaForm";
            Text = "SalasananTarkastus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Panel SalasanaOikeinPanel;
        private Label tervetuloaLabel;
    }
}
