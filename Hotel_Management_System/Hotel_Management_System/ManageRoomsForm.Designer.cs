namespace Hotel_Management_System
{
    partial class ManageRoomsForm
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
            this.roomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noRB = new System.Windows.Forms.RadioButton();
            this.yesRB = new System.Windows.Forms.RadioButton();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.clearBT = new System.Windows.Forms.Button();
            this.removeRoomBT = new System.Windows.Forms.Button();
            this.editRoomBT = new System.Windows.Forms.Button();
            this.addRoomBT = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneNoTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomNoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomPanel
            // 
            this.roomPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.roomPanel.Controls.Add(this.panel1);
            this.roomPanel.Controls.Add(this.roomTypeCB);
            this.roomPanel.Controls.Add(this.clearBT);
            this.roomPanel.Controls.Add(this.removeRoomBT);
            this.roomPanel.Controls.Add(this.editRoomBT);
            this.roomPanel.Controls.Add(this.addRoomBT);
            this.roomPanel.Controls.Add(this.dataGridViewRooms);
            this.roomPanel.Controls.Add(this.label6);
            this.roomPanel.Controls.Add(this.phoneNoTB);
            this.roomPanel.Controls.Add(this.label4);
            this.roomPanel.Controls.Add(this.label3);
            this.roomPanel.Controls.Add(this.roomNoTB);
            this.roomPanel.Controls.Add(this.label2);
            this.roomPanel.Controls.Add(this.panel2);
            this.roomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomPanel.Location = new System.Drawing.Point(0, 0);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(1301, 650);
            this.roomPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.noRB);
            this.panel1.Controls.Add(this.yesRB);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(202, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 87);
            this.panel1.TabIndex = 19;
            // 
            // noRB
            // 
            this.noRB.AutoSize = true;
            this.noRB.Font = new System.Drawing.Font("Poppins Medium", 14F, System.Drawing.FontStyle.Bold);
            this.noRB.ForeColor = System.Drawing.Color.DarkRed;
            this.noRB.Location = new System.Drawing.Point(118, 22);
            this.noRB.Name = "noRB";
            this.noRB.Size = new System.Drawing.Size(77, 46);
            this.noRB.TabIndex = 17;
            this.noRB.TabStop = true;
            this.noRB.Text = "NO";
            this.noRB.UseVisualStyleBackColor = true;
            // 
            // yesRB
            // 
            this.yesRB.AutoSize = true;
            this.yesRB.Font = new System.Drawing.Font("Poppins Medium", 14F, System.Drawing.FontStyle.Bold);
            this.yesRB.ForeColor = System.Drawing.Color.DarkGreen;
            this.yesRB.Location = new System.Drawing.Point(23, 22);
            this.yesRB.Name = "yesRB";
            this.yesRB.Size = new System.Drawing.Size(84, 46);
            this.yesRB.TabIndex = 16;
            this.yesRB.TabStop = true;
            this.yesRB.Text = "YES";
            this.yesRB.UseVisualStyleBackColor = true;
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Location = new System.Drawing.Point(202, 161);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(221, 44);
            this.roomTypeCB.TabIndex = 15;
            // 
            // clearBT
            // 
            this.clearBT.BackColor = System.Drawing.Color.DarkRed;
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
            // removeRoomBT
            // 
            this.removeRoomBT.BackColor = System.Drawing.Color.DarkRed;
            this.removeRoomBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeRoomBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.removeRoomBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeRoomBT.Location = new System.Drawing.Point(339, 465);
            this.removeRoomBT.Name = "removeRoomBT";
            this.removeRoomBT.Size = new System.Drawing.Size(115, 47);
            this.removeRoomBT.TabIndex = 13;
            this.removeRoomBT.Text = "Remove";
            this.removeRoomBT.UseVisualStyleBackColor = false;
            this.removeRoomBT.Click += new System.EventHandler(this.removeRoomBT_Click);
            // 
            // editRoomBT
            // 
            this.editRoomBT.BackColor = System.Drawing.Color.DarkRed;
            this.editRoomBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoomBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.editRoomBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editRoomBT.Location = new System.Drawing.Point(237, 465);
            this.editRoomBT.Name = "editRoomBT";
            this.editRoomBT.Size = new System.Drawing.Size(83, 47);
            this.editRoomBT.TabIndex = 12;
            this.editRoomBT.Text = "Edit";
            this.editRoomBT.UseVisualStyleBackColor = false;
            this.editRoomBT.Click += new System.EventHandler(this.editRoomBT_Click);
            // 
            // addRoomBT
            // 
            this.addRoomBT.BackColor = System.Drawing.Color.DarkRed;
            this.addRoomBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.addRoomBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addRoomBT.Location = new System.Drawing.Point(38, 465);
            this.addRoomBT.Name = "addRoomBT";
            this.addRoomBT.Size = new System.Drawing.Size(177, 47);
            this.addRoomBT.TabIndex = 1;
            this.addRoomBT.Text = "Add New Room";
            this.addRoomBT.UseVisualStyleBackColor = false;
            this.addRoomBT.Click += new System.EventHandler(this.addRoomBT_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(493, 109);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.Size = new System.Drawing.Size(795, 513);
            this.dataGridViewRooms.TabIndex = 11;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "FREE:";
            // 
            // phoneNoTB
            // 
            this.phoneNoTB.Location = new System.Drawing.Point(202, 224);
            this.phoneNoTB.Name = "phoneNoTB";
            this.phoneNoTB.Size = new System.Drawing.Size(221, 37);
            this.phoneNoTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Type:";
            // 
            // roomNoTB
            // 
            this.roomNoTB.Location = new System.Drawing.Point(202, 109);
            this.roomNoTB.Name = "roomNoTB";
            this.roomNoTB.Size = new System.Drawing.Size(221, 37);
            this.roomNoTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room No.:";
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
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1300, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 650);
            this.Controls.Add(this.roomPanel);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Rooms Form";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.roomPanel.ResumeLayout(false);
            this.roomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button removeRoomBT;
        private System.Windows.Forms.Button editRoomBT;
        private System.Windows.Forms.Button addRoomBT;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneNoTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomNoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roomTypeCB;
        private System.Windows.Forms.RadioButton noRB;
        private System.Windows.Forms.RadioButton yesRB;
        private System.Windows.Forms.Panel panel1;
    }
}