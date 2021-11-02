using HomeStay.Class;
using HomeStay.ManagerForms;
using HomeStay.ReceptionistForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.ReceptionistForms
{
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        Employee emp = new Employee();
        Booking booking = new Booking();
        Account acc = new Account();
        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            booking.updateOverDueBooking();

            DataTable dt = acc.getNameAndPhoto(Globals.GlobalUserId, "Receptionist");
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
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;

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
            this.ReceptionistForm_Load(sender, e);
        }

        private void logOut_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            Application.Restart();
        }

        private void mngJani_BT_Click(object sender, EventArgs e)
        {
            ManagerJanitorForm frm = new ManagerJanitorForm();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngJani_BT.FillColor == Color.Transparent && this.mngJani_BT.FillColor2 == Color.Transparent)
            {
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;

                this.mngJani_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngJani_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
            }
        }

        private void mngSchedules_BT_Click(object sender, EventArgs e)
        {
            ManageScheduleByReceptForm frm = new ManageScheduleByReceptForm();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.mngSchedules_BT.FillColor == Color.Transparent && this.mngSchedules_BT.FillColor2 == Color.Transparent)
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;

                this.mngSchedules_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngSchedules_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
            }
        }

        private void mngRooms_BT_Click(object sender, EventArgs e)
        {
            ManageRoomByReceptForm frm = new ManageRoomByReceptForm();

            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngRooms_BT.FillColor == Color.Transparent && this.mngRooms_BT.FillColor2 == Color.Transparent)
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;

                this.mngRooms_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngRooms_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;
            }
        }

        private void mngPayment_BT_Click(object sender, EventArgs e)
        {
            ManageReportForm frm = new ManageReportForm();
            this.Width = 920;
            this.Height = 555;
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngPayment_BT.FillColor == Color.Transparent && this.mngRooms_BT.FillColor2 == Color.Transparent)
            {
                this.mngJani_BT.FillColor = Color.Transparent;
                this.mngJani_BT.FillColor2 = Color.Transparent;
                this.mngSchedules_BT.FillColor = Color.Transparent;
                this.mngSchedules_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.mngRooms_BT.FillColor = Color.Transparent;
                this.mngRooms_BT.FillColor2 = Color.Transparent;

                this.mngPayment_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngPayment_BT.FillColor2 = Color.Teal;
                
                frm.Show();
            }
            else
            {
                this.mngPayment_BT.FillColor = Color.Transparent;
                this.mngPayment_BT.FillColor2 = Color.Transparent;
            }
        }
    }
}
