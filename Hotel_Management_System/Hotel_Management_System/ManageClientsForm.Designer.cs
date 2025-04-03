namespace Hotel_Management_System
{
    partial class ManageClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientPanel = new System.Windows.Forms.Panel();
            this.clearBT = new System.Windows.Forms.Button();
            this.removeBT = new System.Windows.Forms.Button();
            this.editBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.clientPanel.Controls.Add(this.clearBT);
            this.clientPanel.Controls.Add(this.removeBT);
            this.clientPanel.Controls.Add(this.editBT);
            this.clientPanel.Controls.Add(this.addBT);
            this.clientPanel.Controls.Add(this.dataGridView1);
            this.clientPanel.Controls.Add(this.countryTB);
            this.clientPanel.Controls.Add(this.label6);
            this.clientPanel.Controls.Add(this.phoneTB);
            this.clientPanel.Controls.Add(this.label5);
            this.clientPanel.Controls.Add(this.lastNameTB);
            this.clientPanel.Controls.Add(this.label4);
            this.clientPanel.Controls.Add(this.firstNameTB);
            this.clientPanel.Controls.Add(this.label3);
            this.clientPanel.Controls.Add(this.idTB);
            this.clientPanel.Controls.Add(this.label2);
            this.clientPanel.Controls.Add(this.panel2);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(1298, 660);
            this.clientPanel.TabIndex = 0;
            // 
            // clearBT
            // 
            this.clearBT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.clearBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBT.Location = new System.Drawing.Point(38, 534);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(416, 47);
            this.clearBT.TabIndex = 14;
            this.clearBT.Text = "Clear Fields";
            this.clearBT.UseVisualStyleBackColor = false;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // removeBT
            // 
            this.removeBT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.removeBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.removeBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeBT.Location = new System.Drawing.Point(339, 465);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(115, 47);
            this.removeBT.TabIndex = 13;
            this.removeBT.Text = "Remove";
            this.removeBT.UseVisualStyleBackColor = false;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // editBT
            // 
            this.editBT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.editBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBT.Location = new System.Drawing.Point(237, 465);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(83, 47);
            this.editBT.TabIndex = 12;
            this.editBT.Text = "Edit";
            this.editBT.UseVisualStyleBackColor = false;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // addBT
            // 
            this.addBT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.addBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBT.Location = new System.Drawing.Point(38, 465);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(177, 47);
            this.addBT.TabIndex = 1;
            this.addBT.Text = "Add New Client";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 513);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(202, 342);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(221, 37);
            this.countryTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Country:";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(202, 282);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(221, 37);
            this.phoneTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "*Phone:";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(202, 224);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(221, 37);
            this.lastNameTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Last Name:";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(202, 166);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(221, 37);
            this.firstNameTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "*First Name:";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(202, 109);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(221, 37);
            this.idTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 76);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1300, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 660);
            this.Controls.Add(this.clientPanel);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Clients Form";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button removeBT;
        private System.Windows.Forms.Button editBT;
    }
}