using HomeStay.Class;
using HomeStay.ManagerForms;
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

namespace HomeStay.JanitorForms
{
    public partial class JanitorForm : Form
    {
        Employee emp = new Employee();
        Booking booking = new Booking();
        Account acc = new Account();
        public JanitorForm()
        {
            InitializeComponent();
        }
        private void JanitorForm_Load(object sender, EventArgs e)
        {
            DataTable dt = acc.getNameAndPhoto(Globals.GlobalUserId, "Janitor");
            welcome_LB.Text = "Welcome Back " + dt.Rows[0][0].ToString();
            if (!Convert.IsDBNull(dt.Rows[0][1]))
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0][1];
                MemoryStream picture = new MemoryStream(pic);
                avatar_PB.Image = Image.FromStream(picture);
            }
            else
                avatar_PB.Image = null;
        }

        private void mngCleanRoom_BT_Click(object sender, EventArgs e)
        {
            CleanRoom frm = new CleanRoom();
            this.Width = 860;
            this.Height = 250;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.mngCleanRoom_BT.FillColor == Color.Transparent && this.mngCleanRoom_BT.FillColor2 == Color.Transparent)
            {
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;

                this.mngCleanRoom_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngCleanRoom_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngCleanRoom_BT.FillColor = Color.Transparent;
                this.mngCleanRoom_BT.FillColor2 = Color.Transparent;
            }
        }

        private void Check_in_out_BT_Click(object sender, EventArgs e)
        {
            Check_in_outForm frm = new Check_in_outForm();
            this.Width = 1340;
            this.Height = 700;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.Check_in_out_BT.FillColor == Color.Transparent && this.Check_in_out_BT.FillColor2 == Color.Transparent)
            {
                this.mngCleanRoom_BT.FillColor = Color.Transparent;
                this.mngCleanRoom_BT.FillColor2 = Color.Transparent;

                this.Check_in_out_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.Check_in_out_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
            }
        }

        private void edit_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editInfoForm frm = new editInfoForm();
            frm.FormClosing += new FormClosingEventHandler(this.editInfoCustomerForm_Form_Closing);
            frm.Show();
        }
        private void editInfoCustomerForm_Form_Closing(object sender, FormClosingEventArgs e)
        {
            this.JanitorForm_Load(sender, e);
        }

        private void logOut_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            Application.Restart();
        }


    }
}
