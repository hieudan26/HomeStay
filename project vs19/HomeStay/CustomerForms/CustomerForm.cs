﻿using HomeStay.Class;
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

namespace HomeStay.CustomerForms
{
    public partial class CustomerForm : Form
    {
        private Customer customer = new Customer();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void book_BT_Click(object sender, EventArgs e)
        {
            this.Width = 1050;
            this.Height = 580;
            BookRoomForm frm = new BookRoomForm();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.book_BT.FillColor == Color.Transparent && this.book_BT.FillColor2 == Color.Transparent)
            {
                this.mngHis_BT.FillColor = Color.Transparent;
                this.mngHis_BT.FillColor2 = Color.Transparent;
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;

                this.book_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.book_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.book_BT.FillColor = Color.Transparent;
                this.book_BT.FillColor2 = Color.Transparent;
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //Warning: set cứng///////
            Globals.SetGlobalUserId(2165);
            //////////////////////////
            ///
            DataTable dt = this.customer.getInfoCustomers(Globals.GlobalUserId);
            this.welcome_LB.Text = "Welcome Back " + dt.Rows[0][1].ToString() + dt.Rows[0][2].ToString();
            byte[] pic;
            pic = (byte[])dt.Rows[0][3];
            MemoryStream picture = new MemoryStream(pic);
            this.avatar_PB.Image = Image.FromStream(picture);
        }

        private void Check_in_out_BT_Click(object sender, EventArgs e)
        {
            this.Width = 850;
            this.Height = 270;
            CheckInCheckOutForm frm = new CheckInCheckOutForm();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.Check_in_out_BT.FillColor == Color.Transparent && this.Check_in_out_BT.FillColor2 == Color.Transparent)
            {
                this.mngHis_BT.FillColor = Color.Transparent;
                this.mngHis_BT.FillColor2 = Color.Transparent;
                this.book_BT.FillColor = Color.Transparent;
                this.book_BT.FillColor2 = Color.Transparent;

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

        private void mngHis_BT_Click(object sender, EventArgs e)
        {
            this.Width = 1025;
            this.Height = 330;
            HistoryBookingForm frm = new HistoryBookingForm();
            frm.MdiParent = this.ParentForm;
            frm.TopLevel = false;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            if (this.mngHis_BT.FillColor == Color.Transparent && this.mngHis_BT.FillColor2 == Color.Transparent)
            {
                this.Check_in_out_BT.FillColor = Color.Transparent;
                this.Check_in_out_BT.FillColor2 = Color.Transparent;
                this.book_BT.FillColor = Color.Transparent;
                this.book_BT.FillColor2 = Color.Transparent;

                this.mngHis_BT.FillColor = Color.FromArgb(0, 192, 192);
                this.mngHis_BT.FillColor2 = Color.Teal;
                frm.Show();
            }
            else
            {
                this.mngHis_BT.FillColor = Color.Transparent;
                this.mngHis_BT.FillColor2 = Color.Transparent;
            }
        }

        private void edit_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void logOut_LLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
