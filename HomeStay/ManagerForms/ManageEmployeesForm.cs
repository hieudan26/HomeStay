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
        Employee emp = new Employee();
        Account acc = new Account();
        SqlCommand com;
        SqlConnection con;
        public ManageEmployeesForm()
        {
            InitializeComponent();
            com = new SqlCommand();
            con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DB_HomeStay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        private void ManageEmployeesForm_Load(object sender, EventArgs e)
        {
            bdate_DTP.Format = DateTimePickerFormat.Custom;
            bdate_DTP.CustomFormat = "dd/MM/yyyy";
            title_CBO.SelectedIndex = 0;
            gender_CBO.SelectedIndex = 0;
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
            string fname = fname_TB.Text;
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

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                this.ParentForm.Width = 1080;
                this.ParentForm.Height = 610;

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
                if(employee_DGV.RowCount > 0)
                    employee_DGV_CellClick(null, null);
            }
            else
            {
                this.ParentForm.Width = 760;
                this.ParentForm.Height = 440;
            }
        }


        private void clear_BT_Click(object sender, EventArgs e)
        {
            fname_TB.Text = "";
            lname_TB.Text = "";
            email_TB.Text = "";
            title_CBO.Text = "";
            gender_CBO.Text = "";
            bdate_DTP.Value = DateTime.Now;
            phone_TB.Text = "";
            photo_PB.Image = null;
            username_TB.Text = "";
            password_TB.Text = "";
            password2_TB.Text = "";
        }

        private void filter_CBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_TB_TextChanged(null, null);
        }


        private void employee_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employee_DGV.CurrentRow != null)
            {
                int empID = int.Parse(employee_DGV.CurrentRow.Cells[0].Value.ToString());
                com.CommandText = $"SELECT * FROM func_getAccById({empID})";
                DataTable dt = acc.getAccounts(com);

                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                accID_TB.Text = dt.Rows[0]["acc_id"].ToString();
                usernameT2_TB.Text = dt.Rows[0]["username"].ToString();
                passwordT2_TB.Text = dt.Rows[0]["password"].ToString();
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

        private void search_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (filter_CBO.Text.Trim() != "")
                {
                    string colName = filter_CBO.SelectedItem.ToString();
                    searchData(colName, search_TB.Text);
                }
            }
            catch
            {
                MessageBox.Show("Choose Filter First", "Find Infomation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void searchData(string colName, string valueToFind)
        {
            com.CommandText = $"SELECT * FROM func_getAnEmployeeByKeyandValue (\'{colName}\',\'{valueToFind}\')";
            employee_DGV.DataSource = emp.getEmployees(com);
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
            int acc_id = int.Parse(accID_TB.Text);
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
            }
/*            else
            {
                MessageBox.Show("Empty Fields", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }

        private void delete_BT_Click(object sender, EventArgs e)
        {
            try
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
            }
        }

    }
}
