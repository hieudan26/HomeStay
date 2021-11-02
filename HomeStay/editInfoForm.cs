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

namespace HomeStay
{
    public partial class editInfoForm : Form
    {
        public editInfoForm()
        {
            InitializeComponent();
        }
        Employee emp = new Employee();
        Account acc = new Account();
        SqlCommand com = new SqlCommand();
        private void editInfoForm_Load(object sender, EventArgs e)
        {
            this.Width = 355;
            this.Height = 560;
            bdateT2_DTP.Format = DateTimePickerFormat.Custom;
            bdateT2_DTP.CustomFormat = "dd/MM/yyyy";
            int empID = Globals.GlobalUserId;
            com.CommandText = $"SELECT * FROM func_getAccById({empID})";
            DataTable dt = acc.getAccounts(com);
            com.CommandText = $"SELECT * FROM func_getAnEmployeeById({empID})";
            DataTable dt2 = emp.getEmployees(com);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dt2);

            accID_TB.Text = ds.Tables[0].Rows[0]["acc_id"].ToString();
            usernameT2_TB.Text = ds.Tables[0].Rows[0]["username"].ToString();
            passwordT2_TB.Text = ds.Tables[0].Rows[0]["password"].ToString();
            empID_TB.Text = ds.Tables[1].Rows[0]["emp_id"].ToString();
            fnameT2_TB.Text = ds.Tables[1].Rows[0]["firstname"].ToString();
            lnameT2_TB.Text = ds.Tables[1].Rows[0]["lastname"].ToString();
            emailT2_TB.Text = ds.Tables[1].Rows[0]["email"].ToString();
            genderT2_CBO.SelectedItem = ds.Tables[1].Rows[0]["gender"].ToString();
            bdateT2_DTP.Value = (DateTime)ds.Tables[1].Rows[0]["bdate"];
            titleT2_CBO.SelectedItem = ds.Tables[1].Rows[0]["title"].ToString();
            phoneT2_TB.Text = ds.Tables[1].Rows[0]["phone"].ToString();
            if (!Convert.IsDBNull(ds.Tables[1].Rows[0]["photo"]))
            {
                byte[] pic;
                pic = (byte[])ds.Tables[1].Rows[0]["photo"];
                MemoryStream picture = new MemoryStream(pic);
                photoT2_PB.Image = Image.FromStream(picture);
            }
            else
                photoT2_PB.Image = null;
        }
        public MemoryStream GetResponseStream()
        {
            return (null);
        }
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
                        this.Close();
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
        }

        private void chophotoT2_BT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                    photoT2_PB.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
