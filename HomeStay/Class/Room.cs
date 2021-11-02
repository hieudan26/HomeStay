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

        public DataTable searchData(string colName, string valueToFind)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM [dbo].[Function_searchData_Room](@colName, @valueToFind)";
                com.Parameters.Add("@colName", SqlDbType.NVarChar).Value = colName;
                com.Parameters.Add("@valueToFind", SqlDbType.NVarChar).Value = valueToFind;
                com.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                com.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception e)
            {
                com.Parameters.Clear();
                this.closeConnection();
                MessageBox.Show("Error can't search data of room\n" + e.Message, "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public decimal getPriceofRoom_byTypeId(int room_type_id)
        {
            decimal num = -1;
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT dbo.Function_getPriceRoom_byTypeId(@room_type_id)";
            com.Connection = this.getConnection;
            com.Parameters.Add("@room_type_id", SqlDbType.Int).Value = room_type_id;
            this.openConnection();
            num = (decimal)com.ExecuteScalar();
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

        public bool updateStatus(int room_id, bool room_status, bool clean_status)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "dbo.Procedure_updateStatusofRoom";
                com.Connection = this.getConnection;
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@room_id", SqlDbType.Int).Value = room_id;
                com.Parameters.Add("@room_status", SqlDbType.Bit).Value = room_status;
                com.Parameters.Add("@clean_status", SqlDbType.Bit).Value = clean_status;
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

        public DataTable getAllRoomsByType(string rtype)
        {
            SqlCommand com = new SqlCommand();
            try
            {
                com.CommandText = "SELECT * FROM dbo.Function_getAllRooms_byTypes(@rtype)";//And Rooms.room_status = RoomStats.room_status and Rooms.room_status=0
                com.Parameters.Add("@rtype", SqlDbType.NVarChar).Value = rtype;
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
                MessageBox.Show("Error can't get all room have type: " + rtype, "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable getAllRoomsForBooking()
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT * FROM dbo.Function_getAllRooms()";
            com.Connection = this.getConnection;
            this.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.closeConnection();
            return dt;
        }
        public DataTable getAllRooms()
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT * FROM dbo.Function_getAllInfoRooms()";
            com.Connection = this.getConnection;
            this.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.closeConnection();
            return dt;
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
        public DataTable getInfoRoomByType(int rtid)
        {
            SqlCommand com = new SqlCommand();

            com.CommandText = "proc_getInfoRoomByType";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@rtid", SqlDbType.Int).Value = rtid;
            com.Connection = this.getConnection;
            this.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.closeConnection();
            return dt;
        }
        public bool insertRoom(int rtid)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "proc_insertRoom";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@rtid", SqlDbType.Int).Value = rtid;
            com.Connection = this.getConnection;
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
        public bool delRoom(int rid, string status_name)
        {
            SqlCommand com = new SqlCommand();

            com.CommandText = "proc_delRoom";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            com.Parameters.Add("@sttname", SqlDbType.NVarChar).Value = status_name;
            com.Connection = this.getConnection;
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
        public DataTable getAllRoomTypes()
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "proc_getAllRoomTypes";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = this.getConnection;
            this.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool addRoomType(string roomType, int capacity, int bed, int price)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "proc_addRoomType";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@rtn", SqlDbType.NVarChar).Value = roomType;
            com.Parameters.Add("@rc", SqlDbType.Int).Value = capacity;
            com.Parameters.Add("@rnb", SqlDbType.Int).Value = bed;
            com.Parameters.Add("@rp", SqlDbType.Int).Value = price;
            com.Connection = this.getConnection;
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
        public int numOfRoomType()
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "proc_numOfRoomType";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.Connection = this.getConnection;
            this.openConnection();
            int num = Convert.ToInt32(com.Parameters["@num"].Value);
            this.closeConnection();
            return num;

        }

        public bool delRoomType(string roomType)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = $"proc_deleteRoomType";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@rtn", SqlDbType.NVarChar).Value = roomType;
            com.Connection = this.getConnection;
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
        public DataTable getDirtyRoom()
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT * FROM func_getDirtyRoom()";
            com.Connection = this.getConnection;
            this.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool setJanitorCleanRoom(string action, int emp_id, int room_id)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "proc_setJanitorCleanRoom";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@action", SqlDbType.NVarChar).Value = action;
            com.Parameters.Add("@eid", SqlDbType.Int).Value = emp_id;
            com.Parameters.Add("@rid", SqlDbType.Int).Value = room_id;
            com.Connection = this.getConnection;
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
        public DataTable getDirtyRoomInfoWithJanitorID(int eid)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "SELECT * FROM func_getDirtyRoomInfoWithJanitorID(@eid)";
            com.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            com.Connection = this.getConnection;
            this.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
