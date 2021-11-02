using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.CustomerForms
{
    public partial class CustomerInfoForm : Form
    {
        private Customer customer = new Customer();
        private int room_id;
        public CustomerInfoForm(int room_id)
        {
            InitializeComponent();
            this.room_id = room_id;
        }

        private void CustomerInforForm_Load(object sender, EventArgs e)
        {

            this.cin_DTP.Format = DateTimePickerFormat.Custom;
            this.cin_DTP.CustomFormat = "dd/MM/yyyy";
            this.cout_DTP.Format = DateTimePickerFormat.Custom;
            this.cout_DTP.CustomFormat = "dd/MM/yyyy";

            DataTable dt = this.customer.getInfoCustomerByRoomID(this.room_id);
            this.usernameT2_TB.Text = dt.Rows[0][5].ToString();
            this.passwordT2_TB.Text = dt.Rows[0][6].ToString();
            this.guestID_TB.Text = dt.Rows[0][0].ToString();
            this.fnameT2_TB.Text = dt.Rows[0][1].ToString();
            this.lnameT2_TB.Text = dt.Rows[0][2].ToString();
            this.phoneT2_TB.Text = dt.Rows[0][4].ToString();
            this.cin_DTP.Value = DateTime.ParseExact(DateTime.Parse(dt.Rows[0][7].ToString()).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.cout_DTP.Value = DateTime.ParseExact(DateTime.Parse(dt.Rows[0][8].ToString()).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            byte[] pic;
            pic = (byte[])dt.Rows[0][3];
            MemoryStream picture = new MemoryStream(pic);
            photoT2_PB.Image = Image.FromStream(picture);
        }
    }
}
