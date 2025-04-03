namespace Hotel_Management_System
{
    partial class ManageReservationsForm
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
            this.reservationPanel = new System.Windows.Forms.Panel();
            this.dateOutDTP = new System.Windows.Forms.DateTimePicker();
            this.dateInDTP = new System.Windows.Forms.DateTimePicker();
            this.roomTpReserveCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNoCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reserveIdTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientIdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearReserveBT = new System.Windows.Forms.Button();
            this.removeReserveBT = new System.Windows.Forms.Button();
            this.editReserveBT = new System.Windows.Forms.Button();
            this.addReserveBT = new System.Windows.Forms.Button();
            this.dataGridViewReserve = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserve)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservationPanel
            // 
            this.reservationPanel.AutoSize = true;
            this.reservationPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.reservationPanel.Controls.Add(this.dateOutDTP);
            this.reservationPanel.Controls.Add(this.dateInDTP);
            this.reservationPanel.Controls.Add(this.roomTpReserveCB);
            this.reservationPanel.Controls.Add(this.label4);
            this.reservationPanel.Controls.Add(this.roomNoCB);
            this.reservationPanel.Controls.Add(this.label7);
            this.reservationPanel.Controls.Add(this.label6);
            this.reservationPanel.Controls.Add(this.label5);
            this.reservationPanel.Controls.Add(this.reserveIdTB);
            this.reservationPanel.Controls.Add(this.label3);
            this.reservationPanel.Controls.Add(this.clientIdTB);
            this.reservationPanel.Controls.Add(this.label2);
            this.reservationPanel.Controls.Add(this.clearReserveBT);
            this.reservationPanel.Controls.Add(this.removeReserveBT);
            this.reservationPanel.Controls.Add(this.editReserveBT);
            this.reservationPanel.Controls.Add(this.addReserveBT);
            this.reservationPanel.Controls.Add(this.dataGridViewReserve);
            this.reservationPanel.Controls.Add(this.panel2);
            this.reservationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationPanel.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationPanel.Location = new System.Drawing.Point(0, 0);
            this.reservationPanel.Name = "reservationPanel";
            this.reservationPanel.Size = new System.Drawing.Size(1300, 683);
            this.reservationPanel.TabIndex = 1;
            // 
            // dateOutDTP
            // 
            this.dateOutDTP.CustomFormat = "dd/MM/yyyy";
            this.dateOutDTP.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.dateOutDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOutDTP.Location = new System.Drawing.Point(208, 410);
            this.dateOutDTP.Name = "dateOutDTP";
            this.dateOutDTP.Size = new System.Drawing.Size(221, 37);
            this.dateOutDTP.TabIndex = 32;
            // 
            // dateInDTP
            // 
            this.dateInDTP.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateInDTP.CustomFormat = "dd/MM/yyyy";
            this.dateInDTP.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.dateInDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInDTP.Location = new System.Drawing.Point(208, 350);
            this.dateInDTP.Name = "dateInDTP";
            this.dateInDTP.Size = new System.Drawing.Size(221, 37);
            this.dateInDTP.TabIndex = 31;
            // 
            // roomTpReserveCB
            // 
            this.roomTpReserveCB.FormattingEnabled = true;
            this.roomTpReserveCB.Location = new System.Drawing.Point(209, 225);
            this.roomTpReserveCB.Name = "roomTpReserveCB";
            this.roomTpReserveCB.Size = new System.Drawing.Size(221, 44);
            this.roomTpReserveCB.TabIndex = 30;
            this.roomTpReserveCB.SelectedIndexChanged += new System.EventHandler(this.roomTpReserveCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "Room Type:";
            // 
            // roomNoCB
            // 
            this.roomNoCB.FormattingEnabled = true;
            this.roomNoCB.Location = new System.Drawing.Point(208, 288);
            this.roomNoCB.Name = "roomNoCB";
            this.roomNoCB.Size = new System.Drawing.Size(221, 44);
            this.roomNoCB.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 36);
            this.label7.TabIndex = 25;
            this.label7.Text = "Room Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date OUT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "Date IN:";
            // 
            // reserveIdTB
            // 
            this.reserveIdTB.Location = new System.Drawing.Point(209, 109);
            this.reserveIdTB.Name = "reserveIdTB";
            this.reserveIdTB.ReadOnly = true;
            this.reserveIdTB.Size = new System.Drawing.Size(221, 37);
            this.reserveIdTB.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reservation ID:";
            // 
            // clientIdTB
            // 
            this.clientIdTB.Location = new System.Drawing.Point(208, 166);
            this.clientIdTB.Name = "clientIdTB";
            this.clientIdTB.Size = new System.Drawing.Size(221, 37);
            this.clientIdTB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Client ID:";
            // 
            // clearReserveBT
            // 
            this.clearReserveBT.BackColor = System.Drawing.Color.DarkGreen;
            this.clearReserveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearReserveBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.clearReserveBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearReserveBT.Location = new System.Drawing.Point(38, 577);
            this.clearReserveBT.Name = "clearReserveBT";
            this.clearReserveBT.Size = new System.Drawing.Size(416, 47);
            this.clearReserveBT.TabIndex = 14;
            this.clearReserveBT.Text = "Clear Fields";
            this.clearReserveBT.UseVisualStyleBackColor = false;
            this.clearReserveBT.Click += new System.EventHandler(this.clearReserveBT_Click);
            // 
            // removeReserveBT
            // 
            this.removeReserveBT.BackColor = System.Drawing.Color.DarkGreen;
            this.removeReserveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeReserveBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.removeReserveBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeReserveBT.Location = new System.Drawing.Point(326, 508);
            this.removeReserveBT.Name = "removeReserveBT";
            this.removeReserveBT.Size = new System.Drawing.Size(128, 47);
            this.removeReserveBT.TabIndex = 13;
            this.removeReserveBT.Text = "Remove";
            this.removeReserveBT.UseVisualStyleBackColor = false;
            this.removeReserveBT.Click += new System.EventHandler(this.removeReserveBT_Click);
            // 
            // editReserveBT
            // 
            this.editReserveBT.BackColor = System.Drawing.Color.DarkGreen;
            this.editReserveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editReserveBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.editReserveBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editReserveBT.Location = new System.Drawing.Point(237, 508);
            this.editReserveBT.Name = "editReserveBT";
            this.editReserveBT.Size = new System.Drawing.Size(83, 47);
            this.editReserveBT.TabIndex = 12;
            this.editReserveBT.Text = "Edit";
            this.editReserveBT.UseVisualStyleBackColor = false;
            this.editReserveBT.Click += new System.EventHandler(this.editReserveBT_Click);
            // 
            // addReserveBT
            // 
            this.addReserveBT.BackColor = System.Drawing.Color.DarkGreen;
            this.addReserveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReserveBT.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.addReserveBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addReserveBT.Location = new System.Drawing.Point(38, 508);
            this.addReserveBT.Name = "addReserveBT";
            this.addReserveBT.Size = new System.Drawing.Size(193, 47);
            this.addReserveBT.TabIndex = 1;
            this.addReserveBT.Text = "Add Reservation";
            this.addReserveBT.UseVisualStyleBackColor = false;
            this.addReserveBT.Click += new System.EventHandler(this.addReserveBT_Click);
            // 
            // dataGridViewReserve
            // 
            this.dataGridViewReserve.AllowUserToAddRows = false;
            this.dataGridViewReserve.AllowUserToDeleteRows = false;
            this.dataGridViewReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReserve.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserve.Location = new System.Drawing.Point(493, 109);
            this.dataGridViewReserve.Name = "dataGridViewReserve";
            this.dataGridViewReserve.ReadOnly = true;
            this.dataGridViewReserve.RowHeadersWidth = 51;
            this.dataGridViewReserve.RowTemplate.Height = 24;
            this.dataGridViewReserve.Size = new System.Drawing.Size(795, 513);
            this.dataGridViewReserve.TabIndex = 11;
            this.dataGridViewReserve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReserve_CellClick);
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
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1300, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 683);
            this.Controls.Add(this.reservationPanel);
            this.Name = "ManageReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Reservations Form";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            this.reservationPanel.ResumeLayout(false);
            this.reservationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserve)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel reservationPanel;
        private System.Windows.Forms.Button clearReserveBT;
        private System.Windows.Forms.Button removeReserveBT;
        private System.Windows.Forms.Button editReserveBT;
        private System.Windows.Forms.Button addReserveBT;
        private System.Windows.Forms.DataGridView dataGridViewReserve;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reserveIdTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientIdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomNoCB;
        private System.Windows.Forms.DateTimePicker dateInDTP;
        private System.Windows.Forms.ComboBox roomTpReserveCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOutDTP;
    }
}