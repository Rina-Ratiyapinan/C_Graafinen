using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class RESERVATION
    {
        CONNECT conn = new CONNECT();

        public DataTable getAllReserve()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable getReservationById(int reservationId)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations` WHERE `id`=@id", conn.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = reservationId;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        // Function to check if the room is available
        public bool isRoomAvailable(int roomNumber, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            string query = "SELECT * FROM `reservations` WHERE `roomNumber`=@rnm AND ((`dateIn` < @dout) AND (`dateOut` > @din))";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count == 0; // If no overlapping reservation, room is available
        }

        // Function to check if the client exists
        public bool isClientExists(int clientId)
        {
            MySqlCommand command = new MySqlCommand();
            string query = "SELECT * FROM `clients` WHERE `id`=@cid";
            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count > 0; // If rows exist, client exists
        }

        // Function to add a new reservation
        public bool addReservation(int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientId`, `dateIn`, `dateOut`) VALUES (@rnm,@cid,@din,@dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                // After successful reservation, update the room's availability
                MySqlCommand updateCommand = new MySqlCommand("UPDATE `rooms` SET `free`='NO' WHERE `number`=@rnm", conn.getConnection());
                updateCommand.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
                updateCommand.ExecuteNonQuery();

                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        // Function to edit reservation
        public bool editReservation(int reserveId, int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            // Get the current room number before updating
            MySqlCommand getOldRoomCommand = new MySqlCommand("SELECT `roomNumber` FROM `reservations` WHERE `reserveId`=@rvid", conn.getConnection());
            getOldRoomCommand.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reserveId;

            conn.openConnection();
            object oldRoomObj = getOldRoomCommand.ExecuteScalar();
            conn.closeConnection();

            if (oldRoomObj == null) return false; // No reservation found

            int oldRoomNumber = Convert.ToInt32(oldRoomObj);

            // Update the reservation with new room details
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservations` SET `roomNumber`=@rnm, `clientId`=@cid, `dateIn`=@din, `dateOut`=@dout WHERE `reserveId`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reserveId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number; // Replacing newRoomNumber with number
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.Date).Value = dateOut;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                // If the room number has changed, update the availability of both rooms
                if (oldRoomNumber != number)
                {
                    // Mark the new room as occupied
                    MySqlCommand updateNewRoomCommand = new MySqlCommand("UPDATE `rooms` SET `free`='NO' WHERE `number`=@newRnm", conn.getConnection());
                    updateNewRoomCommand.Parameters.Add("@newRnm", MySqlDbType.Int32).Value = number;
                    updateNewRoomCommand.ExecuteNonQuery();

                    // Check if the old room still has reservations
                    MySqlCommand checkOldRoomCommand = new MySqlCommand("SELECT COUNT(*) FROM `reservations` WHERE `roomNumber`=@oldRnm", conn.getConnection());
                    checkOldRoomCommand.Parameters.Add("@oldRnm", MySqlDbType.Int32).Value = oldRoomNumber;

                    int count = Convert.ToInt32(checkOldRoomCommand.ExecuteScalar());

                    if (count == 0) // If no reservations exist, mark the old room as available
                    {
                        MySqlCommand updateOldRoomCommand = new MySqlCommand("UPDATE `rooms` SET `free`='YES' WHERE `number`=@oldRnm", conn.getConnection());
                        updateOldRoomCommand.Parameters.Add("@oldRnm", MySqlDbType.Int32).Value = oldRoomNumber;
                        updateOldRoomCommand.ExecuteNonQuery();
                    }
                }

                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        // function to remove the selected room
        public bool removeReservation(int rsvpId)
        {
            // Get the room number before deleting the reservation
            MySqlCommand getRoomCommand = new MySqlCommand("SELECT `roomNumber` FROM `reservations` WHERE `reserveId`=@rvid", conn.getConnection());
            getRoomCommand.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsvpId;

            conn.openConnection();
            object roomObj = getRoomCommand.ExecuteScalar();
            conn.closeConnection();

            if (roomObj == null)
            {
                return false; // Reservation ID not found
            }

            int roomNumber = Convert.ToInt32(roomObj);

            // Now remove the reservation
            MySqlCommand command = new MySqlCommand("DELETE FROM `reservations` WHERE `reserveId`=@rvid", conn.getConnection());
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsvpId;

            conn.openConnection();
            bool success = command.ExecuteNonQuery() == 1;
            conn.closeConnection();

            if (success)
            {
                // If reservation is deleted, update room status to 'YES' (available)
                MySqlCommand updateCommand = new MySqlCommand("UPDATE `rooms` SET `free`='YES' WHERE `number`=@rnm", conn.getConnection());
                updateCommand.Parameters.Add("@rnm", MySqlDbType.Int32).Value = roomNumber;

                conn.openConnection();
                updateCommand.ExecuteNonQuery();
                conn.closeConnection();
            }

            return success;
        }
    }
}
