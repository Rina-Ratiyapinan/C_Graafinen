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
    public partial class ManageClientsForm: Form
    {
        CLIENT client = new CLIENT();
        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            phoneTB.Text = "";
            countryTB.Text = "";
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            String fname = firstNameTB.Text;
            String lname = lastNameTB.Text;
            String phone = phoneTB.Text;
            String country = countryTB.Text;

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("You have left a required field empty.", "Field is required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertClient = client.insertClient(fname, lname, phone, country);

                if (insertClient)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("New Client Inserted Successfully.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Inserted.", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            int id;
            String fname = firstNameTB.Text;
            String lname = lastNameTB.Text;
            String phone = phoneTB.Text;
            String country = countryTB.Text;

            try
            {
                id = Convert.ToInt32(idTB.Text);

                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("You have left a required field empty.", "Field is required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = client.editClient(id, fname, lname, phone, country);

                    if (insertClient)
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("New Client Updated Successfully.", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Not Updated.", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //display the selected client data from datagridview to textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            firstNameTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastNameTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            phoneTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            countryTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void removeBT_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTB.Text);

                if (client.removeClient(id))
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("Client Deleted Successfully.", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //calling clear button to clear the fields after deletion
                    clearBT.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Deleted.", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
