
namespace HomeStay.ManagerForms
{
    partial class ManageRoomTypesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMngRoom = new System.Windows.Forms.Panel();
            this.bed_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.capacity_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.showRoom_BT = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.del_BT = new Guna.UI2.WinForms.Guna2Button();
            this.add_BT = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.price_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomType_DGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomType_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMngRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomType_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMngRoom
            // 
            this.panelMngRoom.Controls.Add(this.bed_CBO);
            this.panelMngRoom.Controls.Add(this.capacity_CBO);
            this.panelMngRoom.Controls.Add(this.showRoom_BT);
            this.panelMngRoom.Controls.Add(this.guna2Button2);
            this.panelMngRoom.Controls.Add(this.del_BT);
            this.panelMngRoom.Controls.Add(this.add_BT);
            this.panelMngRoom.Controls.Add(this.label1);
            this.panelMngRoom.Controls.Add(this.price_TB);
            this.panelMngRoom.Controls.Add(this.roomType_DGV);
            this.panelMngRoom.Controls.Add(this.label2);
            this.panelMngRoom.Controls.Add(this.label3);
            this.panelMngRoom.Controls.Add(this.roomType_TB);
            this.panelMngRoom.Controls.Add(this.label4);
            this.panelMngRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMngRoom.Location = new System.Drawing.Point(0, 0);
            this.panelMngRoom.Name = "panelMngRoom";
            this.panelMngRoom.Size = new System.Drawing.Size(1470, 1028);
            this.panelMngRoom.TabIndex = 60;
            // 
            // bed_CBO
            // 
            this.bed_CBO.BackColor = System.Drawing.Color.Transparent;
            this.bed_CBO.BorderThickness = 3;
            this.bed_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bed_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bed_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.bed_CBO.FocusedState.Parent = this.bed_CBO;
            this.bed_CBO.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bed_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.bed_CBO.FormattingEnabled = true;
            this.bed_CBO.HoverState.Parent = this.bed_CBO;
            this.bed_CBO.IntegralHeight = false;
            this.bed_CBO.ItemHeight = 40;
            this.bed_CBO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.bed_CBO.ItemsAppearance.Parent = this.bed_CBO;
            this.bed_CBO.Location = new System.Drawing.Point(1040, 434);
            this.bed_CBO.Name = "bed_CBO";
            this.bed_CBO.ShadowDecoration.Parent = this.bed_CBO;
            this.bed_CBO.Size = new System.Drawing.Size(584, 46);
            this.bed_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.bed_CBO.TabIndex = 45;
            // 
            // capacity_CBO
            // 
            this.capacity_CBO.BackColor = System.Drawing.Color.Transparent;
            this.capacity_CBO.BorderThickness = 3;
            this.capacity_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.capacity_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.capacity_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.capacity_CBO.FocusedState.Parent = this.capacity_CBO;
            this.capacity_CBO.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.capacity_CBO.FormattingEnabled = true;
            this.capacity_CBO.HoverState.Parent = this.capacity_CBO;
            this.capacity_CBO.IntegralHeight = false;
            this.capacity_CBO.ItemHeight = 40;
            this.capacity_CBO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.capacity_CBO.ItemsAppearance.Parent = this.capacity_CBO;
            this.capacity_CBO.Location = new System.Drawing.Point(1040, 281);
            this.capacity_CBO.Name = "capacity_CBO";
            this.capacity_CBO.ShadowDecoration.Parent = this.capacity_CBO;
            this.capacity_CBO.Size = new System.Drawing.Size(584, 46);
            this.capacity_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.capacity_CBO.TabIndex = 44;
            // 
            // showRoom_BT
            // 
            this.showRoom_BT.BorderRadius = 3;
            this.showRoom_BT.CheckedState.Parent = this.showRoom_BT;
            this.showRoom_BT.CustomImages.Parent = this.showRoom_BT;
            this.showRoom_BT.FillColor = System.Drawing.Color.Goldenrod;
            this.showRoom_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRoom_BT.ForeColor = System.Drawing.Color.White;
            this.showRoom_BT.HoverState.Parent = this.showRoom_BT;
            this.showRoom_BT.Location = new System.Drawing.Point(4, 790);
            this.showRoom_BT.Name = "showRoom_BT";
            this.showRoom_BT.ShadowDecoration.Parent = this.showRoom_BT;
            this.showRoom_BT.Size = new System.Drawing.Size(267, 80);
            this.showRoom_BT.TabIndex = 43;
            this.showRoom_BT.Text = "Show Room";
            this.showRoom_BT.Click += new System.EventHandler(this.showRoom_BT_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 3;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(291, 790);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(267, 80);
            this.guna2Button2.TabIndex = 42;
            this.guna2Button2.Text = "Show Room Type";
            // 
            // del_BT
            // 
            this.del_BT.BorderRadius = 3;
            this.del_BT.CheckedState.Parent = this.del_BT;
            this.del_BT.CustomImages.Parent = this.del_BT;
            this.del_BT.FillColor = System.Drawing.Color.IndianRed;
            this.del_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_BT.ForeColor = System.Drawing.Color.White;
            this.del_BT.HoverState.Parent = this.del_BT;
            this.del_BT.Location = new System.Drawing.Point(1040, 704);
            this.del_BT.Name = "del_BT";
            this.del_BT.ShadowDecoration.Parent = this.del_BT;
            this.del_BT.Size = new System.Drawing.Size(267, 80);
            this.del_BT.TabIndex = 41;
            this.del_BT.Text = "Delete";
            this.del_BT.Click += new System.EventHandler(this.del_BT_Click);
            // 
            // add_BT
            // 
            this.add_BT.BorderRadius = 3;
            this.add_BT.CheckedState.Parent = this.add_BT;
            this.add_BT.CustomImages.Parent = this.add_BT;
            this.add_BT.FillColor = System.Drawing.Color.ForestGreen;
            this.add_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_BT.ForeColor = System.Drawing.Color.White;
            this.add_BT.HoverState.Parent = this.add_BT;
            this.add_BT.Location = new System.Drawing.Point(1367, 704);
            this.add_BT.Name = "add_BT";
            this.add_BT.ShadowDecoration.Parent = this.add_BT;
            this.add_BT.Size = new System.Drawing.Size(267, 80);
            this.add_BT.TabIndex = 40;
            this.add_BT.Text = "Add";
            this.add_BT.Click += new System.EventHandler(this.add_BT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1034, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room Type";
            // 
            // price_TB
            // 
            this.price_TB.BorderThickness = 3;
            this.price_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_TB.DefaultText = "";
            this.price_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_TB.DisabledState.Parent = this.price_TB;
            this.price_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_TB.FocusedState.Parent = this.price_TB;
            this.price_TB.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_TB.HoverState.Parent = this.price_TB;
            this.price_TB.Location = new System.Drawing.Point(1040, 596);
            this.price_TB.Margin = new System.Windows.Forms.Padding(14, 21, 14, 21);
            this.price_TB.Name = "price_TB";
            this.price_TB.PasswordChar = '\0';
            this.price_TB.PlaceholderText = "";
            this.price_TB.SelectedText = "";
            this.price_TB.ShadowDecoration.Parent = this.price_TB;
            this.price_TB.Size = new System.Drawing.Size(584, 55);
            this.price_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.price_TB.TabIndex = 5;
            // 
            // roomType_DGV
            // 
            this.roomType_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomType_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.roomType_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomType_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomType_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomType_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomType_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomType_DGV.EnableHeadersVisualStyles = false;
            this.roomType_DGV.Location = new System.Drawing.Point(4, 56);
            this.roomType_DGV.Name = "roomType_DGV";
            this.roomType_DGV.RowHeadersVisible = false;
            this.roomType_DGV.RowHeadersWidth = 82;
            this.roomType_DGV.RowTemplate.DividerHeight = 1;
            this.roomType_DGV.RowTemplate.Height = 33;
            this.roomType_DGV.RowTemplate.ReadOnly = true;
            this.roomType_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomType_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomType_DGV.Size = new System.Drawing.Size(990, 728);
            this.roomType_DGV.TabIndex = 2;
            this.roomType_DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.roomType_DGV_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1034, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1034, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacity";
            // 
            // roomType_TB
            // 
            this.roomType_TB.BorderThickness = 3;
            this.roomType_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomType_TB.DefaultText = "";
            this.roomType_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomType_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomType_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomType_TB.DisabledState.Parent = this.roomType_TB;
            this.roomType_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomType_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType_TB.FocusedState.Parent = this.roomType_TB;
            this.roomType_TB.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType_TB.HoverState.Parent = this.roomType_TB;
            this.roomType_TB.Location = new System.Drawing.Point(1040, 128);
            this.roomType_TB.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.roomType_TB.Name = "roomType_TB";
            this.roomType_TB.PasswordChar = '\0';
            this.roomType_TB.PlaceholderText = "";
            this.roomType_TB.SelectedText = "";
            this.roomType_TB.ShadowDecoration.Parent = this.roomType_TB;
            this.roomType_TB.Size = new System.Drawing.Size(584, 55);
            this.roomType_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.roomType_TB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1034, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bed";
            // 
            // ManageRoomTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1470, 1028);
            this.Controls.Add(this.panelMngRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRoomTypesForm";
            this.Text = "ManageRoomTypesForm";
            this.Load += new System.EventHandler(this.ManageRoomTypesForm_Load);
            this.panelMngRoom.ResumeLayout(false);
            this.panelMngRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomType_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMngRoom;
        private Guna.UI2.WinForms.Guna2ComboBox bed_CBO;
        private Guna.UI2.WinForms.Guna2ComboBox capacity_CBO;
        private Guna.UI2.WinForms.Guna2Button showRoom_BT;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button del_BT;
        private Guna.UI2.WinForms.Guna2Button add_BT;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox price_TB;
        private System.Windows.Forms.DataGridView roomType_DGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox roomType_TB;
        private System.Windows.Forms.Label label4;
    }
}