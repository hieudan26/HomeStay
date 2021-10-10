using HomeStay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStay.CustomerForms
{
    public partial class ReviewForm : Form
    {
        private int booking_id;
        private int customer_id;
        private Review review = new Review();

        public ReviewForm(int booking_id, int customer_id)
        {
            InitializeComponent();
            this.booking_id = booking_id;
            this.customer_id = customer_id;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int rating = int.Parse(this.numericRating.Value.ToString());
                String comment = this.rTxtComment.Text;

                if (this.review.createNewReview(this.booking_id, this.customer_id, comment, rating))
                {
                    MessageBox.Show("Submit review success", "Review", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Submit review failed", "Review", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't submit your review try again", "Review", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
