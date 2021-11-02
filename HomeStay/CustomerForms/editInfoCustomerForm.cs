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

namespace HomeStay.CustomerForms
{
    public partial class editInfoCustomerForm : Form
    {
        Customer customer = new Customer();
        DataTable dt;
        public editInfoCustomerForm()
        {
            InitializeComponent();
        }

        private void editInfoCustomerForm_Load(object sender, EventArgs e)
        {
            dt = GuestForm.dt;
            fnameT2_TB.Text = dt.Rows[0][1].ToString();
            lnameT2_TB.Text = dt.Rows[0][2].ToString();
            phoneT2_TB.Text = dt.Rows[0][4].ToString();
            usernameT2_TB.Text = dt.Rows[0][5].ToString();
            passwordT2_TB.Text = dt.Rows[0][6].ToString();

            if (!Convert.IsDBNull(dt.Rows[0][3]))
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0][3];
                MemoryStream picture = new MemoryStream(pic);
                this.photoT2_PB.Image = Image.FromStream(picture);
            }
            else
            {
                this.photoT2_PB.Image = null;
            }

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
        public MemoryStream GetResponseStream()
        {
            return (null);
        }
        private void edit_BT_Click(object sender, EventArgs e)
        {
            string username = usernameT2_TB.Text.Trim();
            string pass = passwordT2_TB.Text.Trim();
            string phone = phoneT2_TB.Text.Trim();
            string fname = fnameT2_TB.Text.Trim();
            string lname = lnameT2_TB.Text.Trim();
            int customer_id = Globals.GlobalUserId;
            MemoryStream picture = new MemoryStream();
            if (photoT2_PB.Image != null)
            {
                photoT2_PB.Image.Save(picture, photoT2_PB.Image.RawFormat);
            }
            else
            {
                picture = GetResponseStream();
            }

            bool UsernameExisted = this.customer.customerName_Existed(username);
            if (!UsernameExisted)
            {
                MessageBox.Show("Your username has been used!", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (this.customer.editCustomer(customer_id, fname, lname, picture, phone, username, pass))
                    {
                        MessageBox.Show("Your Info has been updated!", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
