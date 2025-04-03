using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        int selectedRoomId = -1; // Keep track of selected room ID

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            roomTypeCB.DataSource = room.roomTypeList();
            roomTypeCB.DisplayMember = "label";
            roomTypeCB.ValueMember = "category_id";

            dataGridViewRooms.DataSource = room.getRooms();
            dataGridViewRooms.Columns[0].Visible = false; // Hides 'id'
        }

        private void addRoomBT_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(roomNoTB.Text);
            int type = Convert.ToInt32(roomTypeCB.SelectedValue.ToString());
            string phone = phoneNoTB.Text;

            if (room.addRoom(number, type, phone, "YES"))
            {
                dataGridViewRooms.DataSource = room.getRooms();
                dataGridViewRooms.Columns[0].Visible = false;
                MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR - Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editRoomBT_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to edit", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int number = Convert.ToInt32(roomNoTB.Text);
            int type = Convert.ToInt32(roomTypeCB.SelectedValue.ToString());
            string phone = phoneNoTB.Text;
            string free = yesRB.Checked ? "YES" : "NO";

            if (room.editRoom(selectedRoomId, number, type, phone, free))
            {
                dataGridViewRooms.DataSource = room.getRooms();
                dataGridViewRooms.Columns[0].Visible = false;
                MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR - Room Data Not Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeRoomBT_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (room.removeRoomById(selectedRoomId))
            {
                dataGridViewRooms.DataSource = room.getRooms();
                dataGridViewRooms.Columns[0].Visible = false;
                MessageBox.Show("Room Data Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBT_Click(null, null); // Clear inputs
            }
            else
            {
                MessageBox.Show("ERROR - Room Data Not Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            roomNoTB.Text = "";
            roomTypeCB.SelectedIndex = 0;
            phoneNoTB.Text = "";
            yesRB.Checked = true;
            selectedRoomId = -1;
        }

        private void dataGridViewRooms_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRooms.Rows[e.RowIndex];

                selectedRoomId = Convert.ToInt32(row.Cells[0].Value); // ID column
                roomNoTB.Text = row.Cells[1].Value.ToString();        // number
                roomTypeCB.SelectedValue = row.Cells[2].Value;        // type
                phoneNoTB.Text = row.Cells[3].Value.ToString();       // phone

                string free = row.Cells[4].Value.ToString();
                if (free == "YES") yesRB.Checked = true;
                else noRB.Checked = true;
            }
        }
    }
}
