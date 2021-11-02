
namespace HomeStay
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioGuest = new System.Windows.Forms.RadioButton();
            this.radioJan = new System.Windows.Forms.RadioButton();
            this.radioRecept = new System.Windows.Forms.RadioButton();
            this.radioManager = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.reg_LLB = new System.Windows.Forms.LinkLabel();
            this.login_BT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.password_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioGuest);
            this.panel1.Controls.Add(this.radioJan);
            this.panel1.Controls.Add(this.radioRecept);
            this.panel1.Controls.Add(this.radioManager);
            this.panel1.Location = new System.Drawing.Point(6, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 52);
            this.panel1.TabIndex = 6;
            // 
            // radioGuest
            // 
            this.radioGuest.AutoSize = true;
            this.radioGuest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGuest.Location = new System.Drawing.Point(525, 13);
            this.radioGuest.Name = "radioGuest";
            this.radioGuest.Size = new System.Drawing.Size(111, 36);
            this.radioGuest.TabIndex = 10;
            this.radioGuest.TabStop = true;
            this.radioGuest.Text = "Guest";
            this.radioGuest.UseVisualStyleBackColor = true;
            // 
            // radioJan
            // 
            this.radioJan.AutoSize = true;
            this.radioJan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioJan.Location = new System.Drawing.Point(388, 13);
            this.radioJan.Name = "radioJan";
            this.radioJan.Size = new System.Drawing.Size(126, 36);
            this.radioJan.TabIndex = 9;
            this.radioJan.TabStop = true;
            this.radioJan.Text = "Janitor";
            this.radioJan.UseVisualStyleBackColor = true;
            // 
            // radioRecept
            // 
            this.radioRecept.AutoSize = true;
            this.radioRecept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRecept.Location = new System.Drawing.Point(194, 13);
            this.radioRecept.Name = "radioRecept";
            this.radioRecept.Size = new System.Drawing.Size(187, 36);
            this.radioRecept.TabIndex = 8;
            this.radioRecept.TabStop = true;
            this.radioRecept.Text = "Receptionist";
            this.radioRecept.UseVisualStyleBackColor = true;
            // 
            // radioManager
            // 
            this.radioManager.AutoSize = true;
            this.radioManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioManager.Location = new System.Drawing.Point(35, 13);
            this.radioManager.Name = "radioManager";
            this.radioManager.Size = new System.Drawing.Size(148, 36);
            this.radioManager.TabIndex = 7;
            this.radioManager.TabStop = true;
            this.radioManager.Text = "Manager";
            this.radioManager.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guna2ControlBox2);
            this.panel2.Controls.Add(this.guna2ControlBox1);
            this.panel2.Controls.Add(this.guna2GradientPanel1);
            this.panel2.Controls.Add(this.guna2ShadowPanel1);
            this.panel2.Location = new System.Drawing.Point(-4, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 691);
            this.panel2.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.CustomIconSize = 45F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1155, 20);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(44, 36);
            this.guna2ControlBox2.TabIndex = 17;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.CustomIconSize = 45F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1106, 20);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 36);
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 6);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(514, 809);
            this.guna2GradientPanel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(90, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.pictureBox1.ShadowDecoration.Depth = 10;
            this.pictureBox1.ShadowDecoration.Enabled = true;
            this.pictureBox1.ShadowDecoration.Parent = this.pictureBox1;
            this.pictureBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.pictureBox1.Size = new System.Drawing.Size(302, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.reg_LLB);
            this.guna2ShadowPanel1.Controls.Add(this.login_BT);
            this.guna2ShadowPanel1.Controls.Add(this.password_TB);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.username_TB);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(523, 72);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 0;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(676, 714);
            this.guna2ShadowPanel1.TabIndex = 15;
            // 
            // reg_LLB
            // 
            this.reg_LLB.AutoSize = true;
            this.reg_LLB.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_LLB.Location = new System.Drawing.Point(242, 400);
            this.reg_LLB.Name = "reg_LLB";
            this.reg_LLB.Size = new System.Drawing.Size(352, 24);
            this.reg_LLB.TabIndex = 17;
            this.reg_LLB.TabStop = true;
            this.reg_LLB.Text = "Don\'t Have An Account? Register";
            this.reg_LLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_LLB_LinkClicked);
            // 
            // login_BT
            // 
            this.login_BT.BackColor = System.Drawing.SystemColors.Control;
            this.login_BT.BorderColor = System.Drawing.SystemColors.Control;
            this.login_BT.BorderRadius = 7;
            this.login_BT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.login_BT.CheckedState.Parent = this.login_BT;
            this.login_BT.CustomImages.Parent = this.login_BT;
            this.login_BT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.login_BT.FillColor2 = System.Drawing.Color.Teal;
            this.login_BT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_BT.ForeColor = System.Drawing.Color.White;
            this.login_BT.HoverState.Parent = this.login_BT;
            this.login_BT.Location = new System.Drawing.Point(154, 433);
            this.login_BT.Name = "login_BT";
            this.login_BT.ShadowDecoration.Parent = this.login_BT;
            this.login_BT.Size = new System.Drawing.Size(394, 69);
            this.login_BT.TabIndex = 16;
            this.login_BT.Text = "Login";
            this.login_BT.Click += new System.EventHandler(this.login_BT_Click);
            // 
            // password_TB
            // 
            this.password_TB.BorderRadius = 7;
            this.password_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_TB.DefaultText = "";
            this.password_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_TB.DisabledState.Parent = this.password_TB;
            this.password_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_TB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.password_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_TB.FocusedState.Parent = this.password_TB;
            this.password_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_TB.HoverState.Parent = this.password_TB;
            this.password_TB.Location = new System.Drawing.Point(154, 310);
            this.password_TB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.password_TB.Name = "password_TB";
            this.password_TB.PasswordChar = '\0';
            this.password_TB.PlaceholderText = "Password";
            this.password_TB.SelectedText = "";
            this.password_TB.ShadowDecoration.Parent = this.password_TB;
            this.password_TB.Size = new System.Drawing.Size(398, 66);
            this.password_TB.TabIndex = 11;
            this.password_TB.UseSystemPasswordChar = true;
            // 
            // username_TB
            // 
            this.username_TB.BorderRadius = 7;
            this.username_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_TB.DefaultText = "";
            this.username_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_TB.DisabledState.Parent = this.username_TB;
            this.username_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_TB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.username_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_TB.FocusedState.Parent = this.username_TB;
            this.username_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_TB.HoverState.Parent = this.username_TB;
            this.username_TB.Location = new System.Drawing.Point(154, 210);
            this.username_TB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.username_TB.Name = "username_TB";
            this.username_TB.PasswordChar = '\0';
            this.username_TB.PlaceholderText = "Username";
            this.username_TB.SelectedText = "";
            this.username_TB.ShadowDecoration.Parent = this.username_TB;
            this.username_TB.Size = new System.Drawing.Size(398, 66);
            this.username_TB.TabIndex = 10;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1206, 677);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioRecept;
        private System.Windows.Forms.RadioButton radioManager;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton login_BT;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public Guna.UI2.WinForms.Guna2TextBox username_TB;
        public Guna.UI2.WinForms.Guna2TextBox password_TB;
        private System.Windows.Forms.RadioButton radioJan;
        private System.Windows.Forms.RadioButton radioGuest;
        private System.Windows.Forms.LinkLabel reg_LLB;
    }
}

