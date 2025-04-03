using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();
        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
            // Populate room type combobox with the room types
            roomTpReserveCB.DataSource = room.roomTypeList();
            roomTpReserveCB.DisplayMember = "label";
            roomTpReserveCB.ValueMember = "category_id";

            // Populate the room number combobox with the room numbers
            int type = Convert.ToInt32(roomTpReserveCB.SelectedValue.ToString());
            roomNoCB.DataSource = room.roomByType(type);
            roomNoCB.DisplayMember = "number";
            roomNoCB.ValueMember = "number";

            // Display all reservations in data grid view
            dataGridViewReserve.DataSource = reservation.getAllReserve();

        }

        private void clearReserveBT_Click(object sender, EventArgs e)
        {
            clientIdTB.Text = "";
            reserveIdTB.Text = "";
            //roomTpReserveCB.SelectedIndex = 0;
            //roomNoCB.SelectedIndex = 0;
            dateInDTP.Value = DateTime.Now;
            dateOutDTP.Value = DateTime.Now;
        }

        private void roomTpReserveCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // display the room numbers based on the selected room type
            try
            {
                int type = Convert.ToInt32(roomTpReserveCB.SelectedValue.ToString());
                roomNoCB.DataSource = room.roomByType(type);
                roomNoCB.DisplayMember = "number";
                roomNoCB.ValueMember = "number";
            }
            catch (Exception)
            {

            }
        }

        private void addReserveBT_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = Convert.ToInt32(clientIdTB.Text);
                int roomNumber = Convert.ToInt32(roomNoCB.SelectedValue.ToString());
                DateTime dateIn = dateInDTP.Value.Date;
                DateTime dateOut = dateOutDTP.Value.Date;

                // Check if Client ID exists
                if (!reservation.isClientExists(clientId))
                {
                    MessageBox.Show("Client ID does not exist. Please enter a valid Client ID.", "Invalid Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Prevent dateOut from being before dateIn
                if (dateOut <= dateIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (reservation.isRoomAvailable(roomNumber, dateIn, dateOut))
                {
                    if (reservation.addReservation(roomNumber, clientId, dateIn, dateOut))
                    {
                        dataGridViewReserve.DataSource = reservation.getAllReserve();
                        MessageBox.Show("New Reservation Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Reservation Not Added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Room is not available for the selected dates.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editReserveBT_Click(object sender, EventArgs e)
        {
            try
            {
                int reserveId = Convert.ToInt32(reserveIdTB.Text);
                int clientId = Convert.ToInt32(clientIdTB.Text);
                int roomNumber = Convert.ToInt32(roomNoCB.SelectedValue.ToString());
                DateTime dateIn = dateInDTP.Value;
                DateTime dateOut = dateOutDTP.Value;

                if (dateIn >= dateOut)
                {
                    MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (reservation.isRoomAvailable(roomNumber, dateIn, dateOut) || reservation.editReservation(reserveId, roomNumber, clientId, dateIn, dateOut))
                {
                    dataGridViewReserve.DataSource = reservation.getAllReserve();
                    MessageBox.Show("Reservation Updated Successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room is already booked for the selected dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeReserveBT_Click(object sender, EventArgs e)
        {
            try
            {
                int reserveId = Convert.ToInt32(reserveIdTB.Text);

                if (MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (reservation.removeReservation(reserveId))
                    {
                        dataGridViewReserve.DataSource = reservation.getAllReserve();
                        MessageBox.Show("Reservation Deleted Successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Reservation Not Deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewReserve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reserveIdTB.Text = dataGridViewReserve.CurrentRow.Cells[0].Value.ToString();
            clientIdTB.Text = dataGridViewReserve.CurrentRow.Cells[2].Value.ToString();
            roomNoCB.SelectedValue = dataGridViewReserve.CurrentRow.Cells[1].Value;
            dateInDTP.Value = Convert.ToDateTime(dataGridViewReserve.CurrentRow.Cells[3].Value);
            dateOutDTP.Value = Convert.ToDateTime(dataGridViewReserve.CurrentRow.Cells[4].Value);
        }
    }
}
