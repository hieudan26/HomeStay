using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStay.Class
{
    class Setting
    {
        public static int needed_emp;
        public static int emps;
        public static int days;
        public static int shifts;
        public static int[,,] shift_needed_emp;
        public static int[,,] res;
        public static int[] list_id_emps;
        Employee emp = new Employee();
        SqlCommand com = new SqlCommand();
        public int numOfSetting()
        {
            com.Parameters.Clear();

            com.CommandText = "dbo.func_getNumOfSetting";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = My_DB.getConnection;
            My_DB.openConnection();
            com.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            int num = Convert.ToInt32(com.Parameters["@num"].Value);
            My_DB.closeConnection();

            com.Parameters.Clear();
            com.CommandType = CommandType.Text;
            return num;
        }
        public bool addShift(int set_num, string name, TimeSpan time_start, TimeSpan time_end, int no_manager, int no_recept, int no_janitor)
        {

            SqlCommand com = new SqlCommand("addNewSetting", My_DB.getConnection);
            com.CommandType = CommandType.StoredProcedure;
            int shift_num = this.getShiftNumWithSetNum(set_num) + 1;

            com.Parameters.Add("@set_id", SqlDbType.Int).Value = set_num;
            com.Parameters.Add("@sid", SqlDbType.Int).Value = shift_num;
            com.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            com.Parameters.Add("@tstart", SqlDbType.Time).Value = time_start;
            com.Parameters.Add("@tend", SqlDbType.Time).Value = time_end;
            com.Parameters.Add("@no_manager", SqlDbType.Int).Value = no_manager;
            com.Parameters.Add("@no_recept", SqlDbType.Int).Value = no_recept;
            com.Parameters.Add("@no_janitor", SqlDbType.Int).Value = no_janitor;
            My_DB.openConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                com.Parameters.Clear();
                My_DB.closeConnection();
                return true;
            }
            else
            {
                com.Parameters.Clear();
                My_DB.closeConnection();
                return false;
            }
        }
        public int getShiftNumWithSetNum(int set_num)
        {
            com.Parameters.Clear();

            com.CommandText = "dbo.func_getShiftNumWithSetNum";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = My_DB.getConnection;
            My_DB.openConnection();
            com.Parameters.Add("@set_id", SqlDbType.Int).Value = set_num;
            com.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();
            int num = Convert.ToInt32(com.Parameters["@num"].Value);
            My_DB.closeConnection();

            com.Parameters.Clear();
            com.CommandType = CommandType.Text;
            return num;
        }

        public DataTable getAllSettingId()
        {
            com.CommandText = "dbo.proc_allSettingId";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            com.CommandType = CommandType.Text;
            return dt;
        }
        public DataTable getInfoSetById(int set_id, int shift_id)
        {
            com.CommandText = "dbo.proc_settingInfoById";
            com.CommandType = CommandType.StoredProcedure;
            /*if (shift_id != -1)
            {
                // tam thoi
                com.CommandText = "Select * From Settings Where @set_id = set_id AND @shid = shift_id";
                com.Parameters.Add("@shid", SqlDbType.Int).Value = shift_id;
            }
            else
            {
                com.CommandText = "Select * From dbo.settingInfoById(@set_id)";

            }*/
            com.Parameters.Add("@shid", SqlDbType.Int).Value = shift_id;
            com.Parameters.Add("@set_id", SqlDbType.Int).Value = set_id;
            com.Connection = My_DB.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            com.Parameters.Clear();
            com.CommandType = CommandType.Text;
            return dt;
        }
        public DataTable automaticShift(string title, int needEmp, int num_employees, string shift_name, int idx_start)
        {
            days = 7;
            shifts = 1;
            needed_emp = needEmp;
            emps = num_employees;
            shift_needed_emp = new int[needed_emp, shifts, days];
            res = new int[shifts, days, needed_emp];
            com.Parameters.Clear();
            com.CommandText = $"Select * FROM empInfoByTitle(@title)";
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
            DataTable dt_empInfo = emp.getEmployees(com);
            list_id_emps = new int[emps];
            for (var i = 0; i < dt_empInfo.Rows.Count; i++)
                list_id_emps[i] = Convert.ToInt32(dt_empInfo.Rows[i][0]);
            int idx = idx_start;
            for (int i = 0; i < needed_emp; i++)
            {
                algorithm(emps, days, shifts, idx);
                int pre_idx = idx;
                idx = (idx + shifts) % emps;
                if (idx == pre_idx)
                    idx = (idx + 1) % emps;
            }

            for (int i = 0; i < shifts; i++)
            {
                for (int j = 0; j < days; j++)
                {
                    for (int k = 0; k < needed_emp; k++)
                    {
                        res[i, j, k] = shift_needed_emp[k, i, j];
                    }
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Employee ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Title");
            string[] day_of_week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < days; i++)
            {
                dt.Columns.Add(day_of_week[i]);
            }

            /*for (var i = 0; i < shifts; ++i)
            {
                DataRow row = dt.NewRow();
                for (var j = 0; j < days; ++j)
                {

                    for (var k = 0; k < needed_emp - 1; k++)
                    {
                        row[j] += res[i, j, k].ToString() + ", ";
                    }
                    row[j] += res[i, j, needed_emp - 1].ToString();
                }
                dt.Rows.Add(row);
            }*/

            for (var i = 0; i < dt_empInfo.Rows.Count; i++)
            {
                DataRow row = dt.NewRow();
                for (var j = 0; j < dt_empInfo.Columns.Count; j++)
                {
                    row[j] = dt_empInfo.Rows[i][j];
                }
                for (var k = 0; k < shifts; k++)
                {
                    for (var l = 4; l < days + 4; l++)
                    {
                        for (var m = 0; m < needed_emp; m++)
                        {
                            if (res[k, l - 4, m].ToString() == dt_empInfo.Rows[i]["emp_id"].ToString())
                                row[l] = shift_name;
                            //(shifts_name.Rows[k][0].ToString() + "\n");
                            // shift_name
                        }

                    }
                }
                dt.Rows.Add(row);
            }
            com.Parameters.Clear();
            return dt;
        }
        public void algorithm(int emps, int days, int shifts, int emp)
        {
            int n = days;
            int m = shifts;
            int[,] arr = new int[m, n];
            int cons_emp = emp;
            int row_begin = 0;
            int col_begin = 0;
            for (int day = 0; day < n + 1; day++)
            {
                int row = row_begin;
                int col = col_begin;
                while (row < m && col < n)
                {
                    arr[row, col] = list_id_emps[emp];
                    row += 1;
                    col += 1;
                }
                emp = (emp + 1) % (emps);
                col_begin += 1;
            }
            row_begin = 1;
            col_begin = 0;
            emp = (cons_emp + 1) % (emps);
            for (int day = 0; day < m - 1; day++)
            {
                int row = row_begin;
                int col = col_begin;
                while (row < m && col < n)
                {
                    arr[row, col] = list_id_emps[emp];
                    row += 1;
                    col += 1;
                }
                emp = (emp + 1) % (emps);
                row_begin += 1;
            }
            for (int i = 1; i < needed_emp; i++)
            {
                for (int j = 0; j < shifts; j++)
                {
                    for (int k = 0; k < days; k++)
                    {
                        shift_needed_emp[i - 1, j, k] = shift_needed_emp[i, j, k];
                    }
                }
            }
            for (int j = 0; j < shifts; j++)
            {
                for (int k = 0; k < days; k++)
                {
                    shift_needed_emp[needed_emp - 1, j, k] = arr[j, k];
                }
            }
        }

    }
}
