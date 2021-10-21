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

namespace HomeStay.ManagerForms
{
    
    public partial class ManageEmployeesForm : Form
    {
        Employee employee = new Employee();
        /*Account acc = new Account();*/
        SqlCommand com;
        SqlConnection con;
        public ManageEmployeesForm()
        {
            InitializeComponent();
           /* com = new SqlCommand();
            con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DB_HomeStay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
*/
        }
        private void ManageEmployeesForm_Load(object sender, EventArgs e)
        {
            ///////////////
            ///
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

        private void chophoto_BT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages[0])
                    photo_PB.Image = new Bitmap(opnfd.FileName);
                else
                    photoT2_PB.Image = new Bitmap(opnfd.FileName);
            }
        }
        public MemoryStream GetResponseStream()
        {
            return (null);
        }
        private void add_BT_Click(object sender, EventArgs e)
        {
            /*string fname = fname_TB.Text;
            string lname = lname_TB.Text;
            string email = email_TB.Text;
            string title = title_CBO.SelectedItem.ToString();
            string gender = gender_CBO.SelectedItem.ToString();
            DateTime bdate = bdate_DTP.Value;
            string phone = phone_TB.Text;
            MemoryStream pic = new MemoryStream();

            if (photo_PB.Image != null) {
                photo_PB.Image.Save(pic, photo_PB.Image.RawFormat);
            }
            else
            {
                pic = GetResponseStream();
            }
            string username = username_TB.Text;
            string password = password_TB.Text;
            string password2 = password2_TB.Text;
            int born_year = bdate_DTP.Value.Year;
            int this_year = DateTime.Now.Year;

            if (this_year - born_year < 18 || this_year - born_year > 60)
            {
                MessageBox.Show("The Employee Age Must Be Between 18 and 60", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                try
                {
                    emp.insertEmployee(fname, lname, email, title, gender, bdate, phone, pic, username, password, password2);

                }
                catch (SqlException ex)
                {
                    if (ex.Errors[0].Class == 16)
                        MessageBox.Show(ex.Errors[0].Message, "Error Add Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Employee Added!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
*/
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
/*                this.ParentForm.Width = 1080;
                this.ParentForm.Height = 610;*/

                /*this.Width = 1080;
                this.Height = 610;
                bdateT2_DTP.Format = DateTimePickerFormat.Custom;
                bdateT2_DTP.CustomFormat = "dd/MM/yyyy";
                com.CommandText = "Select * From dbo.func_getAllEmployees()";
                employee_DGV.ReadOnly = true;
                employee_DGV.DataSource = emp.getEmployees(com);
                employee_DGV.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                employee_DGV.BackgroundColor = System.Drawing.SystemColors.Control;
                employee_DGV.Columns[0].HeaderText = "Employee ID";
                employee_DGV.Columns[1].HeaderText = "First Name";
                employee_DGV.Columns[2].HeaderText = "Last Name";
                employee_DGV.Columns[3].HeaderText = "Email";
                employee_DGV.Columns[4].HeaderText = "Birth Date";
                employee_DGV.Columns[5].HeaderText = "Gender";
                employee_DGV.Columns[6].HeaderText = "Title";
                employee_DGV.Columns[7].HeaderText = "Photo";
                employee_DGV.Columns[8].HeaderText = "Phone";
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)employee_DGV.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                employee_DGV.AllowUserToAddRows = false;
                employee_DGV_CellClick(null, null);*/
            }
            else
            {
/*                this.ParentForm.Width = 780;
                this.ParentForm.Height = 480;*/

                this.Width = 780;
                this.Height = 480;
            }
        }


        private void clear_BT_Click(object sender, EventArgs e)
        {
            /*fname_TB.Text = "";
            lname_TB.Text = "";
            email_TB.Text = "";
            title_CBO.Text = "";
            gender_CBO.Text = "";
            bdate_DTP.Value = DateTime.Now;
            phone_TB.Text = "";
            photo_PB.Image = null;
            username_TB.Text = "";
            password_TB.Text = "";
            password2_TB.Text = "";*/
        }

        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_TB_TextChanged(null, null);
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

        private void search_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string colName = this.filter_CBO.SelectedItem.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show("Pls choose what you want to filter by", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void searchData(string colName, string valueToFind)
        {
            this.employee_DGV.DataSource = this.employee.searchData(colName, valueToFind);
        }

/*        private bool verif()
        {
            if ((fnameT2_TB.Text.Trim() == "")
                || (lnameT2_TB.Text.Trim() == "")
                || (emailT2_TB.Text.Trim() == "")
                || (titleT2_CBO.Text.Trim() == "")
                || (genderT2_CBO.Text.Trim() == "")
                || (addressT2_TB.Text.Trim() == "")
                || (phoneT2_TB.Text.Trim() == "")
                || (photoT2_PB.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/

        private void edit_BT_Click(object sender, EventArgs e)
        {
            /*int acc_id = int.Parse(accID_TB.Text);
            string user = usernameT2_TB.Text;
            string pass = passwordT2_TB.Text;

            int id = int.Parse(empID_TB.Text);
            string fname = fnameT2_TB.Text;
            string lname = lnameT2_TB.Text;
            string email = emailT2_TB.Text;
            string title = titleT2_CBO.Text;
            string gender = genderT2_CBO.Text;
            DateTime bdate = bdateT2_DTP.Value;
            string phone = phoneT2_TB.Text;
            Console.WriteLine(acc_id);
            Console.WriteLine(id);
            MemoryStream pic = new MemoryStream();
            int born_year = bdateT2_DTP.Value.Year;
            int this_year = DateTime.Now.Year;
            if (this_year - born_year < 18 || this_year - born_year > 60)
            {
                MessageBox.Show("The Employee Age Must Be Between 10 and 60 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (photoT2_PB.Image != null)
                    {
                        photoT2_PB.Image.Save(pic, photoT2_PB.Image.RawFormat);
                    }
                    else
                    {
                        pic = GetResponseStream();
                    }

                    if (emp.updateEmployee(id, fname, lname, email, title, gender, bdate, phone, pic) && acc.updateAccount(acc_id, user, pass))
                    {
                        MessageBox.Show("Employee Infomation Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabControl1_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Errors[0].Message, "Error Edited", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
/*            else
            {
                MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }

        private void delete_BT_Click(object sender, EventArgs e)
        {
            /*try
            {
                int empID = Convert.ToInt32(empID_TB.Text.Trim());
                int accID = Convert.ToInt32(accID_TB.Text.Trim());
                if (MessageBox.Show("Are You Sure You Want To Delete This Employee", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (emp.delEmployee(empID, accID))
                    {
                        MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        empID_TB.Text = "";
                        fnameT2_TB.Text = "";
                        lnameT2_TB.Text = "";
                        emailT2_TB.Text = "";
                        titleT2_CBO.SelectedItem = null;
                        genderT2_CBO.SelectedItem = null;
                        bdateT2_DTP.Value = DateTime.Now;
                        phoneT2_TB.Text = "";
                        photoT2_PB.Image = null;
                        tabControl1_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

    }
}
