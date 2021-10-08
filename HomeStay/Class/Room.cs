using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.Class
{
    class Room : My_DB
    { 
        public decimal getPriceofRoom_byTypeId(int room_type_id)
        {
            decimal num = -1;
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT dbo.Function_getPriceRoom_byTypeId(@room_type_id)";
                com.Connection = this.getConnection;
                com.Parameters.Add("@room_type_id", SqlDbType.Int).Value = room_type_id;
                this.openConnection();
                num = (decimal)com.ExecuteScalar();
                this.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error can't get price\n" + e.Message, "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            com.Parameters.Clear();
            this.closeConnection();
            return num;
        }

        public int getRoomtype_byRoomID(int room_id)
        {
            int result = -1;
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT dbo.Function_getRoomtype_byRoomID(@room_id)";
                com.Connection = this.getConnection;
                com.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
                this.openConnection();
                result = (int)com.ExecuteScalar();
                this.closeConnection();
            }
            catch (Exception e)
            {
                this.closeConnection();
                com.Parameters.Clear();
                MessageBox.Show("Error can't get roomtype" + e.Message, "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool updateStatus(int room_id, bool room_status)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "dbo.Procedure_updateStatusofRoom";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
                com.Parameters.Add("@room_status", SqlDbType.Bit).Value = room_status;
                this.openConnection();

                if (com.ExecuteNonQuery() == 1)
                {
                    com.Parameters.Clear();
                    this.closeConnection();
                    return true;
                }
                else
                {
                    com.Parameters.Clear();
                    this.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                this.closeConnection();
                com.Parameters.Clear();
                MessageBox.Show("Error can't update status of room" + e.Message, "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable getAllRoomsByType(int room_type_id)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM dbo.Function_getAllRooms_byTypes(@room_type_id)";//And Rooms.room_status = RoomStats.room_status and Rooms.room_status=0
                com.Parameters.Add("@room_type_id", SqlDbType.Int).Value = room_type_id;
                com.Connection = this.getConnection;
                openConnection();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.closeConnection();
                com.Parameters.Clear();
                return dt;
            }
            catch
            {
                this.closeConnection();
                com.Parameters.Clear();
                MessageBox.Show("Error can't get all room have type: " + room_type_id, "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable getAllRooms()
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM dbo.Function_getAllRooms()";
                com.Connection = this.getConnection;
                this.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.closeConnection();
                com.Parameters.Clear();
                return dt;
            }
            catch (Exception ex)
            {
                this.closeConnection();
                com.Parameters.Clear();
                MessageBox.Show("Error can't get all room\n" + ex.Message, "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable getRoomType()
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM dbo.Function_getRoomType()";
                com.Connection = this.getConnection;
                this.openConnection();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.closeConnection();
                com.Parameters.Clear();
                return dt;
            }
            catch
            {
                this.closeConnection();
                com.Parameters.Clear();
                MessageBox.Show("Error can't get all type have already in system", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
