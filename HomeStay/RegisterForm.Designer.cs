
namespace HomeStay
{
    partial class RegisterForm
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
            this.passwordT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.Log_LLB = new System.Windows.Forms.LinkLabel();
            this.reg_BT = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chophotoT2_BT = new System.Windows.Forms.Button();
            this.photoT2_LB = new System.Windows.Forms.Label();
            this.photoT2_PB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.phoneT2_LB = new System.Windows.Forms.Label();
            this.phoneT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lnameT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lnameT2_LB = new System.Windows.Forms.Label();
            this.fnameT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.fnameT2_LB = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.passwordT2_LB = new System.Windows.Forms.Label();
            this.usernameT2_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.userT2_LB = new System.Windows.Forms.Label();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoT2_PB)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordT2_TB
            // 
            this.passwordT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordT2_TB.DefaultText = "";
            this.passwordT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordT2_TB.DisabledState.Parent = this.passwordT2_TB;
            this.passwordT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordT2_TB.FocusedState.Parent = this.passwordT2_TB;
            this.passwordT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordT2_TB.HoverState.Parent = this.passwordT2_TB;
            this.passwordT2_TB.Location = new System.Drawing.Point(248, 119);
            this.passwordT2_TB.Margin = new System.Windows.Forms.Padding(104, 150, 104, 150);
            this.passwordT2_TB.Name = "passwordT2_TB";
            this.passwordT2_TB.PasswordChar = '\0';
            this.passwordT2_TB.PlaceholderText = "";
            this.passwordT2_TB.SelectedText = "";
            this.passwordT2_TB.ShadowDecoration.Parent = this.passwordT2_TB;
            this.passwordT2_TB.Size = new System.Drawing.Size(214, 44);
            this.passwordT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passwordT2_TB.TabIndex = 30;
            // 
            // Log_LLB
            // 
            this.Log_LLB.AutoSize = true;
            this.Log_LLB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_LLB.Location = new System.Drawing.Point(342, 667);
            this.Log_LLB.Name = "Log_LLB";
            this.Log_LLB.Size = new System.Drawing.Size(316, 30);
            this.Log_LLB.TabIndex = 48;
            this.Log_LLB.TabStop = true;
            this.Log_LLB.Text = "Have an Account? Log in";
            this.Log_LLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Log_LLB_LinkClicked);
            // 
            // reg_BT
            // 
            this.reg_BT.BorderRadius = 3;
            this.reg_BT.CheckedState.Parent = this.reg_BT;
            this.reg_BT.CustomImages.Parent = this.reg_BT;
            this.reg_BT.FillColor = System.Drawing.Color.RoyalBlue;
            this.reg_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_BT.ForeColor = System.Drawing.Color.White;
            this.reg_BT.HoverState.Parent = this.reg_BT;
            this.reg_BT.Location = new System.Drawing.Point(16, 716);
            this.reg_BT.Name = "reg_BT";
            this.reg_BT.ShadowDecoration.Parent = this.reg_BT;
            this.reg_BT.Size = new System.Drawing.Size(634, 80);
            this.reg_BT.TabIndex = 51;
            this.reg_BT.Text = "Register";
            this.reg_BT.Click += new System.EventHandler(this.reg_BT_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.chophotoT2_BT);
            this.guna2GroupBox2.Controls.Add(this.photoT2_LB);
            this.guna2GroupBox2.Controls.Add(this.photoT2_PB);
            this.guna2GroupBox2.Controls.Add(this.phoneT2_LB);
            this.guna2GroupBox2.Controls.Add(this.phoneT2_TB);
            this.guna2GroupBox2.Controls.Add(this.lnameT2_TB);
            this.guna2GroupBox2.Controls.Add(this.lnameT2_LB);
            this.guna2GroupBox2.Controls.Add(this.fnameT2_TB);
            this.guna2GroupBox2.Controls.Add(this.fnameT2_LB);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(15, 194);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(634, 470);
            this.guna2GroupBox2.TabIndex = 49;
            this.guna2GroupBox2.Text = "Guest Infomation";
            // 
            // chophotoT2_BT
            // 
            this.chophotoT2_BT.BackColor = System.Drawing.Color.Gainsboro;
            this.chophotoT2_BT.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chophotoT2_BT.Location = new System.Drawing.Point(372, 389);
            this.chophotoT2_BT.Name = "chophotoT2_BT";
            this.chophotoT2_BT.Size = new System.Drawing.Size(250, 61);
            this.chophotoT2_BT.TabIndex = 31;
            this.chophotoT2_BT.Text = "Choose Photo";
            this.chophotoT2_BT.UseVisualStyleBackColor = false;
            this.chophotoT2_BT.Click += new System.EventHandler(this.chophotoT2_BT_Click);
            // 
            // photoT2_LB
            // 
            this.photoT2_LB.AutoSize = true;
            this.photoT2_LB.Location = new System.Drawing.Point(366, 122);
            this.photoT2_LB.Name = "photoT2_LB";
            this.photoT2_LB.Size = new System.Drawing.Size(98, 36);
            this.photoT2_LB.TabIndex = 23;
            this.photoT2_LB.Text = "Photo";
            // 
            // photoT2_PB
            // 
            this.photoT2_PB.Location = new System.Drawing.Point(370, 175);
            this.photoT2_PB.Name = "photoT2_PB";
            this.photoT2_PB.ShadowDecoration.Parent = this.photoT2_PB;
            this.photoT2_PB.Size = new System.Drawing.Size(250, 183);
            this.photoT2_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoT2_PB.TabIndex = 22;
            this.photoT2_PB.TabStop = false;
            // 
            // phoneT2_LB
            // 
            this.phoneT2_LB.AutoSize = true;
            this.phoneT2_LB.Location = new System.Drawing.Point(14, 291);
            this.phoneT2_LB.Name = "phoneT2_LB";
            this.phoneT2_LB.Size = new System.Drawing.Size(106, 36);
            this.phoneT2_LB.TabIndex = 21;
            this.phoneT2_LB.Text = "Phone";
            // 
            // phoneT2_TB
            // 
            this.phoneT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneT2_TB.DefaultText = "";
            this.phoneT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneT2_TB.DisabledState.Parent = this.phoneT2_TB;
            this.phoneT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneT2_TB.FocusedState.Parent = this.phoneT2_TB;
            this.phoneT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneT2_TB.HoverState.Parent = this.phoneT2_TB;
            this.phoneT2_TB.Location = new System.Drawing.Point(20, 325);
            this.phoneT2_TB.Margin = new System.Windows.Forms.Padding(34, 50, 34, 50);
            this.phoneT2_TB.Name = "phoneT2_TB";
            this.phoneT2_TB.PasswordChar = '\0';
            this.phoneT2_TB.PlaceholderText = "";
            this.phoneT2_TB.SelectedText = "";
            this.phoneT2_TB.ShadowDecoration.Parent = this.phoneT2_TB;
            this.phoneT2_TB.Size = new System.Drawing.Size(266, 52);
            this.phoneT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phoneT2_TB.TabIndex = 20;
            // 
            // lnameT2_TB
            // 
            this.lnameT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameT2_TB.DefaultText = "";
            this.lnameT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lnameT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lnameT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameT2_TB.DisabledState.Parent = this.lnameT2_TB;
            this.lnameT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lnameT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameT2_TB.FocusedState.Parent = this.lnameT2_TB;
            this.lnameT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lnameT2_TB.HoverState.Parent = this.lnameT2_TB;
            this.lnameT2_TB.Location = new System.Drawing.Point(18, 236);
            this.lnameT2_TB.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.lnameT2_TB.Name = "lnameT2_TB";
            this.lnameT2_TB.PasswordChar = '\0';
            this.lnameT2_TB.PlaceholderText = "";
            this.lnameT2_TB.SelectedText = "";
            this.lnameT2_TB.ShadowDecoration.Parent = this.lnameT2_TB;
            this.lnameT2_TB.Size = new System.Drawing.Size(266, 44);
            this.lnameT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.lnameT2_TB.TabIndex = 3;
            // 
            // lnameT2_LB
            // 
            this.lnameT2_LB.AutoSize = true;
            this.lnameT2_LB.Location = new System.Drawing.Point(14, 203);
            this.lnameT2_LB.Name = "lnameT2_LB";
            this.lnameT2_LB.Size = new System.Drawing.Size(165, 36);
            this.lnameT2_LB.TabIndex = 2;
            this.lnameT2_LB.Text = "Last Name";
            // 
            // fnameT2_TB
            // 
            this.fnameT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameT2_TB.DefaultText = "";
            this.fnameT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnameT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnameT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameT2_TB.DisabledState.Parent = this.fnameT2_TB;
            this.fnameT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnameT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameT2_TB.FocusedState.Parent = this.fnameT2_TB;
            this.fnameT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnameT2_TB.HoverState.Parent = this.fnameT2_TB;
            this.fnameT2_TB.Location = new System.Drawing.Point(18, 158);
            this.fnameT2_TB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.fnameT2_TB.Name = "fnameT2_TB";
            this.fnameT2_TB.PasswordChar = '\0';
            this.fnameT2_TB.PlaceholderText = "";
            this.fnameT2_TB.SelectedText = "";
            this.fnameT2_TB.ShadowDecoration.Parent = this.fnameT2_TB;
            this.fnameT2_TB.Size = new System.Drawing.Size(266, 44);
            this.fnameT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.fnameT2_TB.TabIndex = 1;
            // 
            // fnameT2_LB
            // 
            this.fnameT2_LB.AutoSize = true;
            this.fnameT2_LB.Location = new System.Drawing.Point(14, 122);
            this.fnameT2_LB.Name = "fnameT2_LB";
            this.fnameT2_LB.Size = new System.Drawing.Size(162, 36);
            this.fnameT2_LB.TabIndex = 0;
            this.fnameT2_LB.Text = "First Name";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.passwordT2_TB);
            this.guna2GroupBox1.Controls.Add(this.passwordT2_LB);
            this.guna2GroupBox1.Controls.Add(this.usernameT2_TB);
            this.guna2GroupBox1.Controls.Add(this.userT2_LB);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 19);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(476, 169);
            this.guna2GroupBox1.TabIndex = 50;
            this.guna2GroupBox1.Text = "Account Infomation";
            // 
            // passwordT2_LB
            // 
            this.passwordT2_LB.AutoSize = true;
            this.passwordT2_LB.Location = new System.Drawing.Point(242, 80);
            this.passwordT2_LB.Name = "passwordT2_LB";
            this.passwordT2_LB.Size = new System.Drawing.Size(146, 36);
            this.passwordT2_LB.TabIndex = 29;
            this.passwordT2_LB.Text = "Password";
            // 
            // usernameT2_TB
            // 
            this.usernameT2_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameT2_TB.DefaultText = "";
            this.usernameT2_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameT2_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameT2_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameT2_TB.DisabledState.Parent = this.usernameT2_TB;
            this.usernameT2_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameT2_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameT2_TB.FocusedState.Parent = this.usernameT2_TB;
            this.usernameT2_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameT2_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameT2_TB.HoverState.Parent = this.usernameT2_TB;
            this.usernameT2_TB.Location = new System.Drawing.Point(20, 119);
            this.usernameT2_TB.Margin = new System.Windows.Forms.Padding(74, 103, 74, 103);
            this.usernameT2_TB.Name = "usernameT2_TB";
            this.usernameT2_TB.PasswordChar = '\0';
            this.usernameT2_TB.PlaceholderText = "";
            this.usernameT2_TB.SelectedText = "";
            this.usernameT2_TB.ShadowDecoration.Parent = this.usernameT2_TB;
            this.usernameT2_TB.Size = new System.Drawing.Size(198, 44);
            this.usernameT2_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.usernameT2_TB.TabIndex = 28;
            // 
            // userT2_LB
            // 
            this.userT2_LB.AutoSize = true;
            this.userT2_LB.Location = new System.Drawing.Point(14, 80);
            this.userT2_LB.Name = "userT2_LB";
            this.userT2_LB.Size = new System.Drawing.Size(159, 36);
            this.userT2_LB.TabIndex = 27;
            this.userT2_LB.Text = "Username";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 808);
            this.Controls.Add(this.Log_LLB);
            this.Controls.Add(this.reg_BT);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoT2_PB)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox passwordT2_TB;
        private System.Windows.Forms.LinkLabel Log_LLB;
        private Guna.UI2.WinForms.Guna2Button reg_BT;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Button chophotoT2_BT;
        private System.Windows.Forms.Label photoT2_LB;
        private Guna.UI2.WinForms.Guna2PictureBox photoT2_PB;
        private System.Windows.Forms.Label phoneT2_LB;
        private Guna.UI2.WinForms.Guna2TextBox phoneT2_TB;
        private Guna.UI2.WinForms.Guna2TextBox lnameT2_TB;
        private System.Windows.Forms.Label lnameT2_LB;
        private Guna.UI2.WinForms.Guna2TextBox fnameT2_TB;
        private System.Windows.Forms.Label fnameT2_LB;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label passwordT2_LB;
        private Guna.UI2.WinForms.Guna2TextBox usernameT2_TB;
        private System.Windows.Forms.Label userT2_LB;
    }
}