using HomeStay;
using HomeStay.Class;
using HomeStay.CustomerForms;
using HomeStay.JanitorForms;
using HomeStay.ManagerForms;
using HomeStay.ReceptionistForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay
{
    public partial class LoginForm : Form
    {
        Account acc = new Account();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../Image/icons8-business_building.png");
            pictureBox1.BackColor = Color.Transparent;

        }

        public void menu_role()
        {
            if(radioManager.Checked)
            {
                Application.Run(new ManagerForm());
            }
            else if(radioRecept.Checked)
            {
                Application.Run(new ReceptionistForm());
            }
            else if(radioJan.Checked)
            {
                Application.Run(new JanitorForm());
            }
            else if(radioGuest.Checked)
            {
                Application.Run(new GuestForm());
            }
        }
    

        private void login_BT_Click(object sender, EventArgs e)
        {
            string username = username_TB.Text;
            string password = password_TB.Text;
            string title;
            if (radioManager.Checked)
            {
                title = radioManager.Text;
            }
            else if (radioRecept.Checked)
            {
                title = radioRecept.Text;
            }
            else if (radioJan.Checked)
            {
                title = radioJan.Text;
            }
            else if (radioGuest.Checked)
            {
                title = radioGuest.Text;
            }
            else
            {
                MessageBox.Show("Please Choose Your Title", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int user_id = acc.Login(username, password, title);
            if (user_id > 0)
            {
                MessageBox.Show("Login Successful");
                try
                {
                    My_DB.grantPermission(username, password, title);
                    My_DB.con = new SqlConnection(My_DB.makeURL(username, password));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Globals.SetGlobalUserId(user_id);
                this.Hide();

                if (radioManager.Checked)
                {
                    ManagerForm frm = new ManagerForm();
                    
                    frm.ShowDialog();
                }
                else if (radioRecept.Checked)
                {
                    ReceptionistForm frm = new ReceptionistForm();
                    frm.ShowDialog();

                }
                else if (radioJan.Checked)
                    {
                    JanitorForm frm = new JanitorForm();
                    frm.ShowDialog();

                }
                else if (radioGuest.Checked)
                    {
                    GuestForm frm = new GuestForm();
                    frm.ShowDialog();

                }
                this.Close();

            }
            else if(user_id == -1)
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(user_id == -2)
            {
                MessageBox.Show("Missing Field. Please Try Again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reg_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }
    }
}
