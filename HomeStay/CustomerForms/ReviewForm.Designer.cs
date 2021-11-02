
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
            this.submit_BT = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.comment_TB = new System.Windows.Forms.Label();
            this.rating_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comment_RTB = new System.Windows.Forms.RichTextBox();
            this.rating_TB = new System.Windows.Forms.Label();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit_BT
            // 
            this.submit_BT.BorderRadius = 3;
            this.submit_BT.CheckedState.Parent = this.submit_BT;
            this.submit_BT.CustomImages.Parent = this.submit_BT;
            this.submit_BT.FillColor = System.Drawing.Color.RoyalBlue;
            this.submit_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_BT.ForeColor = System.Drawing.Color.White;
            this.submit_BT.HoverState.Parent = this.submit_BT;
            this.submit_BT.Location = new System.Drawing.Point(12, 676);
            this.submit_BT.Name = "submit_BT";
            this.submit_BT.ShadowDecoration.Parent = this.submit_BT;
            this.submit_BT.Size = new System.Drawing.Size(676, 80);
            this.submit_BT.TabIndex = 54;
            this.submit_BT.Text = "Submit ";
            this.submit_BT.Click += new System.EventHandler(this.submit_BT_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.comment_TB);
            this.guna2GroupBox2.Controls.Add(this.rating_CBO);
            this.guna2GroupBox2.Controls.Add(this.comment_RTB);
            this.guna2GroupBox2.Controls.Add(this.rating_TB);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(676, 649);
            this.guna2GroupBox2.TabIndex = 52;
            this.guna2GroupBox2.Text = "Give Your Reaction";
            // 
            // comment_TB
            // 
            this.comment_TB.AutoSize = true;
            this.comment_TB.Location = new System.Drawing.Point(14, 216);
            this.comment_TB.Name = "comment_TB";
            this.comment_TB.Size = new System.Drawing.Size(161, 36);
            this.comment_TB.TabIndex = 34;
            this.comment_TB.Text = "Comment";
            // 
            // rating_CBO
            // 
            this.rating_CBO.BackColor = System.Drawing.Color.Transparent;
            this.rating_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rating_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rating_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.rating_CBO.FocusedState.Parent = this.rating_CBO;
            this.rating_CBO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rating_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.rating_CBO.FormattingEnabled = true;
            this.rating_CBO.HoverState.Parent = this.rating_CBO;
            this.rating_CBO.IntegralHeight = false;
            this.rating_CBO.ItemHeight = 26;
            this.rating_CBO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rating_CBO.ItemsAppearance.Parent = this.rating_CBO;
            this.rating_CBO.Location = new System.Drawing.Point(20, 130);
            this.rating_CBO.Margin = new System.Windows.Forms.Padding(4);
            this.rating_CBO.Name = "rating_CBO";
            this.rating_CBO.ShadowDecoration.Parent = this.rating_CBO;
            this.rating_CBO.Size = new System.Drawing.Size(266, 32);
            this.rating_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.rating_CBO.TabIndex = 33;
            // 
            // comment_RTB
            // 
            this.comment_RTB.Location = new System.Drawing.Point(20, 270);
            this.comment_RTB.Name = "comment_RTB";
            this.comment_RTB.Size = new System.Drawing.Size(640, 358);
            this.comment_RTB.TabIndex = 32;
            this.comment_RTB.Text = "";
            // 
            // rating_TB
            // 
            this.rating_TB.AutoSize = true;
            this.rating_TB.Location = new System.Drawing.Point(14, 90);
            this.rating_TB.Name = "rating_TB";
            this.rating_TB.Size = new System.Drawing.Size(108, 36);
            this.rating_TB.TabIndex = 0;
            this.rating_TB.Text = "Rating";
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 770);
            this.Controls.Add(this.submit_BT);
            this.Controls.Add(this.guna2GroupBox2);
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button submit_BT;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label rating_TB;
        private System.Windows.Forms.RichTextBox comment_RTB;
        private Guna.UI2.WinForms.Guna2ComboBox rating_CBO;
        private System.Windows.Forms.Label comment_TB;
    }
}