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
    class Check_in_out : My_DB
    {
        public DataTable getDataCheckInCheckOut(int emp_id)
        {
            SqlCommand command = new SqlCommand();
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error can't get data checkin check out\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return null;
        }

        public bool isExist(int id, DateTime dname, string sname)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = "select [dbo].[Function_isExist](@emp_id, @day, @shift_name)";
                command.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@day", SqlDbType.Date).Value = dname;
                command.Parameters.Add("@shift_name", SqlDbType.NVarChar).Value = sname;
                this.openConnection();
                command.Connection = this.getConnection;
                int num = (int)command.ExecuteScalar();
                command.Parameters.Clear();
                this.closeConnection();
                if (num > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error can't check existed\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return false;
        }

        public bool isCheckedin(int id, DateTime dname, string sname)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.CommandText = "select [dbo].[Function_isCheckedin](@emp_id, @day, @shift_name)";
                command.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@day", SqlDbType.Date).Value = dname;
                command.Parameters.Add("@shift_name", SqlDbType.NVarChar).Value = sname;
                this.openConnection();
                command.Connection = this.getConnection;
                int num = (int)command.ExecuteScalar();
                command.Parameters.Clear();
                this.closeConnection();
                if (num > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error can't check checkedin\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return false;
        }

        public bool insertCheckInData(int eid, DateTime date_name, string shift_name, TimeSpan tstart, TimeSpan tend, TimeSpan tin)
        {
            SqlCommand command = new SqlCommand();
            try
            {
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error can't insert check in data\n" + ex2.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return false;
        }

        public DataTable getDataCheckInCheckOutWith(int id, DateTime dname)
        {
            SqlCommand command = new SqlCommand();
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error can't get data checkin checkout with\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return null;
        }

        public bool insertCheckOutData(int id, DateTime dname, string sname, TimeSpan tout, TimeSpan twork)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.Parameters.Clear();
                command.CommandText = "[dbo].[Procedure_insertCheckOutData]";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@day", SqlDbType.Date).Value = dname;
                command.Parameters.Add("@shift_name", SqlDbType.NVarChar).Value = sname;
                command.Parameters.Add("@time_out", SqlDbType.Time).Value = tout;
                command.Parameters.Add("@time_worked", SqlDbType.Time).Value = twork;
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
            catch (SqlException ex)
            {
                MessageBox.Show("Error can't insert check out data\n" + ex.Message, "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command.Parameters.Clear();
            this.closeConnection();
            return false;
        }
    }
}
