using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.Class
{
    class CheckInOut: My_DB
    {
        My_DB mydb = new My_DB();
        SqlCommand com = new SqlCommand();

        public DataTable getDataCheckInCheckOut(DateTime dstart, DateTime dend)
        {
            com.Parameters.Clear();
            com.CommandText = "proc_getCheckInOutHistory";
            com.CommandType = CommandType.StoredProcedure;
                
            com.Parameters.Add("@dstart", SqlDbType.Date).Value = dstart.Date;
            com.Parameters.Add("@dend", SqlDbType.Date).Value = dend.Date;
            com.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getDataCheckInCheckOut(int emp_id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from [dbo].[Function_getDataCheckInCheckOut](@emp_id)";
            command.Connection = this.getConnection;
            command.Parameters.Add("@emp_id", SqlDbType.Int).Value = emp_id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Parameters.Clear();
            this.closeConnection();
            return dt;
        }
        public bool insertCheckInData(int eid, DateTime date_name, string shift_name, TimeSpan tstart, TimeSpan tend, TimeSpan tin)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "[dbo].[Procedure_insertCheckInData]";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@emp_id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@day", SqlDbType.Date).Value = date_name;
            command.Parameters.Add("@shift_name", SqlDbType.NVarChar).Value = shift_name;
            command.Parameters.Add("@time_start", SqlDbType.Time).Value = tstart;
            command.Parameters.Add("@time_end", SqlDbType.Time).Value = tend;
            command.Parameters.Add("@time_in", SqlDbType.Time).Value = tin;
            this.openConnection();
            command.Connection = this.getConnection;
            if (command.ExecuteNonQuery() == -1)
            {
                command.Parameters.Clear();
                this.closeConnection();
                return true;
            }
            else
            {
                command.Parameters.Clear();
                this.closeConnection();
                return false;
            }
        }
        public bool insertCheckOutData(int id, DateTime dname, string sname, TimeSpan tout, TimeSpan twork)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Procedure_insertCheckOutData";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@day", SqlDbType.Date).Value = dname;
            command.Parameters.Add("@shift_name", SqlDbType.NVarChar).Value = sname;
            command.Parameters.Add("@time_out", SqlDbType.Time).Value = tout;
            command.Parameters.Add("@time_worked", SqlDbType.Time).Value = twork;
            this.openConnection();
            command.Connection = this.getConnection;
            if (command.ExecuteNonQuery() == 1)
            {
                command.Parameters.Clear();
                this.closeConnection();
                return true;
            }
            else
            {
                command.Parameters.Clear();
                this.closeConnection();
                return false;
            }
        }
        public bool isExist(int id, DateTime dname, string sname)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select dbo.Function_isExistCheckInOut(@eid, @dname, @sname)";
            command.Parameters.Add("@eid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@dname", SqlDbType.Date).Value = dname;
            command.Parameters.Add("@sname", SqlDbType.NVarChar).Value = sname;
            command.Connection = this.getConnection;
            this.openConnection();
            int num = (int)command.ExecuteScalar();
            this.closeConnection();
            command.Parameters.Clear();
            if (num > 0)
                return true;
            return false;
        }
        public DataTable getDataCheckInCheckOutWith(int id, DateTime dname)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from [dbo].[Function_getDataCheckInCheckOutWith](@emp_id, @day)";
            this.openConnection();
            command.Connection = this.getConnection;
            command.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@day", SqlDbType.Date).Value = dname;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            command.Parameters.Clear();
            this.closeConnection();
            return dt;
        }
    }
}
