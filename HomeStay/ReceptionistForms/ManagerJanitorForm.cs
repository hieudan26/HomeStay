using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.ReceptionistForms
{
    public partial class ManagerJanitorForm : Form
    {
        Employee employee = new Employee();
        Account acc = new Account();
        public ManagerJanitorForm()
        {
            InitializeComponent();
        }

        private void ManagerJanitorForm_Load(object sender, EventArgs e)
        {
            this.ParentForm.Width = 1070;
            this.ParentForm.Height = 490;
            this.bdateT2_DTP.Format = DateTimePickerFormat.Custom;
            this.bdateT2_DTP.CustomFormat = "dd/MM/yyyy";
     
            this.employee_DGV.ReadOnly = true;
            SqlCommand com = new SqlCommand();
            com.CommandText = $"select * from function_getAllJanitor()";
            this.employee_DGV.DataSource = this.employee.getEmployees(com);
            this.employee_DGV.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.employee_DGV.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.employee_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employee_DGV.Columns[0].HeaderText = "Employee ID";
            this.employee_DGV.Columns[1].HeaderText = "First Name";
            this.employee_DGV.Columns[2].HeaderText = "Last Name";

            this.employee_DGV.Columns[3].HeaderText = "Email";
            this.employee_DGV.Columns[5].HeaderText = "Gender";
            this.employee_DGV.Columns[4].HeaderText = "Birth Date";
            this.employee_DGV.Columns[6].HeaderText = "Title";
            this.employee_DGV.Columns[7].HeaderText = "Photo";
            this.employee_DGV.Columns[8].HeaderText = "Phone";
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)this.employee_DGV.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.employee_DGV.AllowUserToAddRows = false;
            if (employee_DGV.RowCount > 0)
                employee_DGV_CellClick(null, null);
        }



        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.search_TB_TextChanged(null, null);
        }

        private void search_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (filter_CBO.Text.Trim() != "")
                {
                    string colName = filter_CBO.SelectedItem.ToString();
                    Console.WriteLine(colName);
                    searchData(colName, search_TB.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void searchData(string colName, string valueToFind)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = $"SELECT * FROM func_getAnEmployeeByKeyandValue (\'{colName}\',\'{valueToFind}\') WHERE title = @title ";
            com.Parameters.Add("@title", SqlDbType.NVarChar).Value = "Janitor";
            employee_DGV.DataSource = employee.getEmployees(com);
        }

        private void employee_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employee_DGV.CurrentRow != null)
            {
                SqlCommand com = new SqlCommand();
                int empID = int.Parse(employee_DGV.CurrentRow.Cells[0].Value.ToString());
                com.CommandText = $"SELECT * FROM func_getAccById({empID})";
                DataTable dt = acc.getAccounts(com);
                com.CommandText = $"SELECT * FROM func_getAnEmployeeById({empID})";
                DataTable dt2 = employee.getEmployees(com);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                ds.Tables.Add(dt2);
                empID_TB.Text = employee_DGV.CurrentRow.Cells[0].Value.ToString();
                fnameT2_TB.Text = employee_DGV.CurrentRow.Cells[1].Value.ToString();
                lnameT2_TB.Text = employee_DGV.CurrentRow.Cells[2].Value.ToString();
                emailT2_TB.Text = employee_DGV.CurrentRow.Cells[3].Value.ToString();
                bdateT2_DTP.Value = (DateTime)employee_DGV.CurrentRow.Cells[4].Value;
                genderT2_CBO.SelectedItem = employee_DGV.CurrentRow.Cells[5].Value;
                titleT2_CBO.SelectedItem = employee_DGV.CurrentRow.Cells[6].Value;
                phoneT2_TB.Text = employee_DGV.CurrentRow.Cells[8].Value.ToString();

                if (!Convert.IsDBNull(employee_DGV.CurrentRow.Cells[7].Value))
                {
                    byte[] pic;
                    pic = (byte[])employee_DGV.CurrentRow.Cells[7].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    photoT2_PB.Image = Image.FromStream(picture);
                }
                else
                    photoT2_PB.Image = null;
            }
            else
            {
                MessageBox.Show("not found", "Find Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
