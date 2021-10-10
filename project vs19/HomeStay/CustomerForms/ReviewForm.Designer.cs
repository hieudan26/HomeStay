
namespace HomeStay.CustomerForms
{
    partial class ReviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomType_LB = new System.Windows.Forms.Label();
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rTxtComment = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            this.SuspendLayout();
            // 
            // roomType_LB
            // 
            this.roomType_LB.AutoSize = true;
            this.roomType_LB.Location = new System.Drawing.Point(49, 35);
            this.roomType_LB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomType_LB.Name = "roomType_LB";
            this.roomType_LB.Size = new System.Drawing.Size(81, 17);
            this.roomType_LB.TabIndex = 7;
            this.roomType_LB.Text = "Room Type";
            // 
            // numericRating
            // 
            this.numericRating.Location = new System.Drawing.Point(204, 30);
            this.numericRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(141, 22);
            this.numericRating.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comment";
            // 
            // rTxtComment
            // 
            this.rTxtComment.Location = new System.Drawing.Point(208, 112);
            this.rTxtComment.Name = "rTxtComment";
            this.rTxtComment.Size = new System.Drawing.Size(377, 157);
            this.rTxtComment.TabIndex = 10;
            this.rTxtComment.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(407, 275);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 323);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rTxtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericRating);
            this.Controls.Add(this.roomType_LB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomType_LB;
        private System.Windows.Forms.NumericUpDown numericRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTxtComment;
        private System.Windows.Forms.Button btnSubmit;
    }
}