using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.ReceptionistForm
{
    public partial class ManagerJanitorForm : Form
    {
        Employee employee = new Employee();

        public ManagerJanitorForm()
        {
            InitializeComponent();
        }

        private void ManagerJanitorForm_Load(object sender, EventArgs e)
        {
            /*this.ParentForm.Width = 1080;
            this.ParentForm.Height = 560;*/
            this.bdateT2_DTP.Format = DateTimePickerFormat.Custom;
            this.bdateT2_DTP.CustomFormat = "dd/MM/yyyy";
     
            this.employee_DGV.ReadOnly = true;
            this.employee_DGV.DataSource = this.employee.getEmployees();
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

            if (this.employee_DGV.DataSource != null)
            {
                this.loadDataCellZero();
            }
        }

        private void loadDataCellZero()
        {
            this.empID_TB.Text = this.employee_DGV.Rows[0].Cells[0].Value.ToString();
            this.fnameT2_TB.Text = this.employee_DGV.Rows[0].Cells[1].Value.ToString();
            this.lnameT2_TB.Text = this.employee_DGV.Rows[0].Cells[2].Value.ToString();
            this.emailT2_TB.Text = this.employee_DGV.Rows[0].Cells[3].Value.ToString();
            this.genderT2_CBO.SelectedItem = this.employee_DGV.Rows[0].Cells[5].Value;
            this.bdateT2_DTP.Value = (DateTime)this.employee_DGV.Rows[0].Cells[4].Value;

            this.titleT2_CBO.SelectedItem = this.employee_DGV.Rows[0].Cells[6].Value;
            this.phoneT2_TB.Text = employee_DGV.Rows[0].Cells[8].Value.ToString();

            //này mở ra khi có ảnh t chỉ check thôi nên ko add đc ảnh
            byte[] pic;
            //pic = (byte[])employee_DGV.CurrentRow.Cells[7].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //this.photoT2_PB.Image = Image.FromStream(picture);
        }

        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.search_TB_TextChanged(null, null);
        }

        private void search_TB_TextChanged(object sender, EventArgs e)
        {
            string colName = filter_CBO.SelectedItem.ToString();
            if (colName == "Employee ID")
                colName = "emp_id";
            else if (colName == "Birth Date")
                colName = "bdate";
            else if (colName == "First Name")
                colName = "firstname";
            else if (colName == "Last Name")
                colName = "lastname";
            else if (colName == "Email")
                colName = "email";
            else if (colName == "Gender")
                colName = "gender";
            else if (colName == "Phone")
                colName = "phone";
            this.searchData(colName, this.search_TB.Text.Trim());
        }

        public void searchData(string colName, string valueToFind)
        {
            this.employee_DGV.DataSource = this.employee.searchData(colName, valueToFind);
        }

        private void employee_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int empID = int.Parse(employee_DGV.CurrentRow.Cells[0].Value.ToString());
            DataTable dt2 = emp.getEmployees(com);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt2);
*/
            this.empID_TB.Text = this.employee_DGV.CurrentRow.Cells[0].Value.ToString();
            this.fnameT2_TB.Text = this.employee_DGV.CurrentRow.Cells[1].Value.ToString();
            this.lnameT2_TB.Text = this.employee_DGV.CurrentRow.Cells[2].Value.ToString();
            this.emailT2_TB.Text = this.employee_DGV.CurrentRow.Cells[3].Value.ToString();
            this.genderT2_CBO.SelectedItem = this.employee_DGV.CurrentRow.Cells[5].Value;
            this.bdateT2_DTP.Value = (DateTime)this.employee_DGV.CurrentRow.Cells[4].Value;
            
            this.titleT2_CBO.SelectedItem = this.employee_DGV.CurrentRow.Cells[6].Value;
            this.phoneT2_TB.Text = employee_DGV.CurrentRow.Cells[8].Value.ToString();

            //này mở ra khi có ảnh t chỉ check thôi nên ko add đc ảnh
            byte[] pic;
            //pic = (byte[])employee_DGV.CurrentRow.Cells[7].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //this.photoT2_PB.Image = Image.FromStream(picture);
        }
    }
}
