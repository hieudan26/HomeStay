using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HomeStay.Class
{
    class Schedule: My_DB
    {
        My_DB mydb = new My_DB();
        SqlCommand com = new SqlCommand();
        // da sua
        public int getNumScheduleGenBySet(int set_id)
        {
            com.Parameters.Clear();
            com.CommandText = "dbo.func_getNumScheduleGenBySet";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@set_id", SqlDbType.Int).Value = set_id;

            com.Connection = mydb.getConnection;
            mydb.openConnection();
            com.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            int num = Convert.ToInt32(com.Parameters["@num"].Value); 
            mydb.closeConnection();

            com.Parameters.Clear();
            com.CommandType = CommandType.Text;
            return num;
        }
        // da sua
        public int numOfSchedule()
        {
            com.Parameters.Clear();

            com.CommandText = "dbo.func_getNumOfSchedule";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = mydb.getConnection;
            mydb.openConnection();
            com.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            int num = Convert.ToInt32(com.Parameters["@num"].Value);
            mydb.closeConnection();

            com.Parameters.Clear();
            com.CommandType = CommandType.Text;
            return num;
        }
        // tam thoi
/*        public bool isExist(DateTime dstart, DateTime dend)
        {
            if (this.numOfSchedule() == 0)
                return false;
            com.CommandText = "Select Count(*) From Schedules Where @dend >= date_start AND @dstart <= date_end";
            com.Parameters.Add("@dstart", SqlDbType.DateTime).Value = dstart;
            com.Parameters.Add("@dend", SqlDbType.DateTime).Value = dend;
            com.Connection = mydb.getConnection;
            mydb.openConnection();
            int num = (int)com.ExecuteScalar();
            mydb.closeConnection();
            com.Parameters.Clear();
            if (num > 0)
                return true;
            return false;
        }*/
        // tam thoi
        public bool addSchedule(int id, int set_id, int emp_id, DateTime date_start, DateTime date_end,
                        string Monday, string Tuesday, string Wednesday, string Thursday, string Friday, string Saturday, string Sunday)
        {
            com.CommandText = "dbo.proc_addSchedule";
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = mydb.getConnection;
            com.Parameters.Add("@sch_id", SqlDbType.Int).Value = id;
            com.Parameters.Add("@set_id", SqlDbType.Int).Value = set_id;
            com.Parameters.Add("@eid", SqlDbType.Int).Value = emp_id;
            com.Parameters.Add("@dstart", SqlDbType.DateTime).Value = date_start;
            com.Parameters.Add("@dend", SqlDbType.DateTime).Value = date_end;
            com.Parameters.Add("@mday", SqlDbType.NVarChar).Value = Monday;
            com.Parameters.Add("@tday", SqlDbType.NVarChar).Value = Tuesday;
            com.Parameters.Add("@wday", SqlDbType.NVarChar).Value = Wednesday;
            com.Parameters.Add("@thday", SqlDbType.NVarChar).Value = Thursday;
            com.Parameters.Add("@fday", SqlDbType.NVarChar).Value = Friday;
            com.Parameters.Add("@satday", SqlDbType.NVarChar).Value = Saturday;
            com.Parameters.Add("@sunday", SqlDbType.NVarChar).Value = Sunday;
            mydb.openConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                com.CommandType = CommandType.Text;
                return true;
            }
            else
            {
                com.Parameters.Clear();
                mydb.closeConnection();
                com.CommandType = CommandType.Text;
                return false;
            }
        }

        public DataTable getTimeSchedule(DateTime date)
        {
            com.CommandText = "dbo.proc_getTimeSchedule";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            com.CommandType = CommandType.Text;
            return dt;
        }

        public DataTable getScheduleInfoByDate(DateTime date)
        {
            com.CommandText = "Select * FROM ScheduleInfoByDate(@date)";
            com.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }

        public DataTable getScheduleInfoToday(DateTime date, string dayName)
        {
            com.CommandText = "getScheduleInfoToday";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            com.Parameters.Add("@dayName", SqlDbType.NVarChar).Value = dayName;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();

            com.CommandType = CommandType.Text;
            return dt;
        }
        //$"SELECT * FROM Employees WHERE  {colName} LIKE '%" + valueToFind + "%'"
        public DataTable searchData(DateTime date, string colName, string valueToFind)
        {
            com.CommandText = $"Select * FROM ScheduleInfoByDate(@date) WHERE {colName} LIKE '%" + valueToFind + "%'";
            com.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            return dt;
        }
        public DataTable getScheduleByUserId(DateTime tnow, int emp_id)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = "select * from [dbo].[Function_getScheduleByUserId](@tnow, @emp_id)";
                command.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp_id;
                command.Parameters.Add("@tnow", SqlDbType.DateTime).Value = tnow;
                command.Connection = this.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                command.Parameters.Clear();
                this.closeConnection();
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error can't get schedule by user id\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return null;
        }
        public DataTable getDateStartEnd(DateTime tnow)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = "Select * from [dbo].[Function_getDateStartEnd](@tnow)";
                command.Parameters.Add("@tnow", SqlDbType.DateTime).Value = tnow;
                command.Connection = this.getConnection;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                command.Parameters.Clear();
                this.closeConnection();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error can't get date start end\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return null;
        }
        public DataTable getShiftInfoBySetId(DateTime tnow)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "proc_getSettingInfoWithSetIdFromSchedule";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@tnow", SqlDbType.DateTime).Value = tnow;
            command.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            command.Parameters.Clear();
            this.closeConnection();
            return table;
        }
    }
}
