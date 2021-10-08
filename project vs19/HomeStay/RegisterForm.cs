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
    public partial class RegisterForm : Form
    {
        private My_DB my_DB = new My_DB();
        private Customer customer = new Customer();
        private SqlConnection conn = new SqlConnection();

        public RegisterForm()
        {
            InitializeComponent();
            this.conn = this.my_DB.getConnection;
        }

        public bool verify()
        {
            if (this.usernameT2_TB.Text.Trim() == "" |
                this.passwordT2_TB.Text.Trim() == "" |
                this.fnameT2_TB.Text.Trim() == "" |
                this.lnameT2_TB.Text.Trim() == "" |
                this.phoneT2_TB.Text.Trim() == "" |
                this.photoT2_PB.Image == null)
                return false;
            return true;
        }

        private void chophotoT2_BT_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                this.photoT2_PB.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.guestID_TB.Text = (this.customer.getNumOfCustomer() + 1).ToString().Trim();
        }

        private void Log_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LoginForm frm = new LoginForm();
            //frm.Show();
            this.Close();
        }

        private void reg_BT_Click(object sender, EventArgs e)
        {
            if (!this.verify())
            {
                MessageBox.Show("Missing Fields. Cannot Sign Up, Please Try Again", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand com = new SqlCommand();
                string username = usernameT2_TB.Text.Trim();
                string pass = passwordT2_TB.Text.Trim();
                string phone = phoneT2_TB.Text.Trim();
                string fname = fnameT2_TB.Text.Trim();
                string lname = lnameT2_TB.Text.Trim();
                MemoryStream picture = new MemoryStream();
                photoT2_PB.Image.Save(picture, photoT2_PB.Image.RawFormat);
                try
                {
                    bool UsernameExisted = this.customer.customerName_Existed(username);
                    if (!UsernameExisted)
                    {
                        MessageBox.Show("Your username has been used!", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            this.customer.createCustomer(fname, lname, picture, phone, username, pass);
                            MessageBox.Show("Your account has been created!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Check Username of Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
