
namespace HomeStay.ManagerForms
{
    partial class ManageRoomsForm
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
            this.room_DGV = new System.Windows.Forms.DataGridView();
            this.capacity_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomCapacity_LB = new System.Windows.Forms.Label();
            this.roomPrice_LB = new System.Windows.Forms.Label();
            this.roomType_LB = new System.Windows.Forms.Label();
            this.roomBed_BT = new System.Windows.Forms.Label();
            this.bed_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.price_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomType_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.add_BT = new Guna.UI2.WinForms.Guna2Button();
            this.delete_BT = new Guna.UI2.WinForms.Guna2Button();
            this.showRoomType_BT = new Guna.UI2.WinForms.Guna2Button();
            this.showRoom_BT = new Guna.UI2.WinForms.Guna2Button();
            this.panelMngRoom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.room_DGV)).BeginInit();
            this.panelMngRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // room_DGV
            // 
            this.room_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.room_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.room_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.room_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.room_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.room_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.room_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.room_DGV.EnableHeadersVisualStyles = false;
            this.room_DGV.Location = new System.Drawing.Point(4, 56);
            this.room_DGV.Name = "room_DGV";
            this.room_DGV.RowHeadersVisible = false;
            this.room_DGV.RowHeadersWidth = 82;
            this.room_DGV.RowTemplate.DividerHeight = 1;
            this.room_DGV.RowTemplate.Height = 33;
            this.room_DGV.RowTemplate.ReadOnly = true;
            this.room_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.room_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.room_DGV.Size = new System.Drawing.Size(990, 728);
            this.room_DGV.TabIndex = 2;
            this.room_DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.room_DGV_CellMouseClick);
            // 
            // capacity_TB
            // 
            this.capacity_TB.BorderThickness = 3;
            this.capacity_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacity_TB.DefaultText = "";
            this.capacity_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.capacity_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.capacity_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacity_TB.DisabledState.Parent = this.capacity_TB;
            this.capacity_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacity_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacity_TB.FocusedState.Parent = this.capacity_TB;
            this.capacity_TB.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacity_TB.HoverState.Parent = this.capacity_TB;
            this.capacity_TB.Location = new System.Drawing.Point(1040, 279);
            this.capacity_TB.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.capacity_TB.Name = "capacity_TB";
            this.capacity_TB.PasswordChar = '\0';
            this.capacity_TB.PlaceholderText = "";
            this.capacity_TB.SelectedText = "";
            this.capacity_TB.ShadowDecoration.Parent = this.capacity_TB;
            this.capacity_TB.Size = new System.Drawing.Size(584, 55);
            this.capacity_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.capacity_TB.TabIndex = 1;
            // 
            // roomCapacity_LB
            // 
            this.roomCapacity_LB.AutoSize = true;
            this.roomCapacity_LB.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacity_LB.Location = new System.Drawing.Point(1034, 242);
            this.roomCapacity_LB.Name = "roomCapacity_LB";
            this.roomCapacity_LB.Size = new System.Drawing.Size(150, 36);
            this.roomCapacity_LB.TabIndex = 0;
            this.roomCapacity_LB.Text = "Capacity";
            // 
            // roomPrice_LB
            // 
            this.roomPrice_LB.AutoSize = true;
            this.roomPrice_LB.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPrice_LB.Location = new System.Drawing.Point(1034, 563);
            this.roomPrice_LB.Name = "roomPrice_LB";
            this.roomPrice_LB.Size = new System.Drawing.Size(86, 36);
            this.roomPrice_LB.TabIndex = 4;
            this.roomPrice_LB.Text = "Price";
            // 
            // roomType_LB
            // 
            this.roomType_LB.AutoSize = true;
            this.roomType_LB.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType_LB.Location = new System.Drawing.Point(1034, 95);
            this.roomType_LB.Name = "roomType_LB";
            this.roomType_LB.Size = new System.Drawing.Size(174, 36);
            this.roomType_LB.TabIndex = 6;
            this.roomType_LB.Text = "Room Type";
            // 
            // roomBed_BT
            // 
            this.roomBed_BT.AutoSize = true;
            this.roomBed_BT.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBed_BT.Location = new System.Drawing.Point(1034, 401);
            this.roomBed_BT.Name = "roomBed_BT";
            this.roomBed_BT.Size = new System.Drawing.Size(71, 36);
            this.roomBed_BT.TabIndex = 2;
            this.roomBed_BT.Text = "Bed";
            // 
            // bed_TB
            // 
            this.bed_TB.BorderThickness = 3;
            this.bed_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bed_TB.DefaultText = "";
            this.bed_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bed_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bed_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bed_TB.DisabledState.Parent = this.bed_TB;
            this.bed_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bed_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bed_TB.FocusedState.Parent = this.bed_TB;
            this.bed_TB.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bed_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bed_TB.HoverState.Parent = this.bed_TB;
            this.bed_TB.Location = new System.Drawing.Point(1040, 436);
            this.bed_TB.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.bed_TB.Name = "bed_TB";
            this.bed_TB.PasswordChar = '\0';
            this.bed_TB.PlaceholderText = "";
            this.bed_TB.SelectedText = "";
            this.bed_TB.ShadowDecoration.Parent = this.bed_TB;
            this.bed_TB.Size = new System.Drawing.Size(584, 55);
            this.bed_TB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.bed_TB.TabIndex = 3;
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
            // roomType_CBO
            // 
            this.roomType_CBO.BackColor = System.Drawing.Color.Transparent;
            this.roomType_CBO.BorderThickness = 3;
            this.roomType_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomType_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.roomType_CBO.FocusedState.Parent = this.roomType_CBO;
            this.roomType_CBO.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomType_CBO.FormattingEnabled = true;
            this.roomType_CBO.HoverState.Parent = this.roomType_CBO;
            this.roomType_CBO.IntegralHeight = false;
            this.roomType_CBO.ItemHeight = 40;
            this.roomType_CBO.ItemsAppearance.Parent = this.roomType_CBO;
            this.roomType_CBO.Location = new System.Drawing.Point(1040, 135);
            this.roomType_CBO.Name = "roomType_CBO";
            this.roomType_CBO.ShadowDecoration.Parent = this.roomType_CBO;
            this.roomType_CBO.Size = new System.Drawing.Size(584, 46);
            this.roomType_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.roomType_CBO.TabIndex = 15;
            this.roomType_CBO.SelectedValueChanged += new System.EventHandler(this.roomType_CBO_SelectedValueChanged);
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
            // delete_BT
            // 
            this.delete_BT.BorderRadius = 3;
            this.delete_BT.CheckedState.Parent = this.delete_BT;
            this.delete_BT.CustomImages.Parent = this.delete_BT;
            this.delete_BT.FillColor = System.Drawing.Color.IndianRed;
            this.delete_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_BT.ForeColor = System.Drawing.Color.White;
            this.delete_BT.HoverState.Parent = this.delete_BT;
            this.delete_BT.Location = new System.Drawing.Point(1040, 704);
            this.delete_BT.Name = "delete_BT";
            this.delete_BT.ShadowDecoration.Parent = this.delete_BT;
            this.delete_BT.Size = new System.Drawing.Size(267, 80);
            this.delete_BT.TabIndex = 41;
            this.delete_BT.Text = "Delete";
            this.delete_BT.Click += new System.EventHandler(this.delete_BT_Click);
            // 
            // showRoomType_BT
            // 
            this.showRoomType_BT.BorderRadius = 3;
            this.showRoomType_BT.CheckedState.Parent = this.showRoomType_BT;
            this.showRoomType_BT.CustomImages.Parent = this.showRoomType_BT;
            this.showRoomType_BT.FillColor = System.Drawing.Color.RoyalBlue;
            this.showRoomType_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRoomType_BT.ForeColor = System.Drawing.Color.White;
            this.showRoomType_BT.HoverState.Parent = this.showRoomType_BT;
            this.showRoomType_BT.Location = new System.Drawing.Point(291, 790);
            this.showRoomType_BT.Name = "showRoomType_BT";
            this.showRoomType_BT.ShadowDecoration.Parent = this.showRoomType_BT;
            this.showRoomType_BT.Size = new System.Drawing.Size(267, 80);
            this.showRoomType_BT.TabIndex = 42;
            this.showRoomType_BT.Text = "Show Room Type";
            this.showRoomType_BT.Click += new System.EventHandler(this.showRoomType_BT_Click);
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
            // 
            // panelMngRoom
            // 
            this.panelMngRoom.Controls.Add(this.showRoom_BT);
            this.panelMngRoom.Controls.Add(this.showRoomType_BT);
            this.panelMngRoom.Controls.Add(this.delete_BT);
            this.panelMngRoom.Controls.Add(this.add_BT);
            this.panelMngRoom.Controls.Add(this.roomType_CBO);
            this.panelMngRoom.Controls.Add(this.roomType_LB);
            this.panelMngRoom.Controls.Add(this.price_TB);
            this.panelMngRoom.Controls.Add(this.room_DGV);
            this.panelMngRoom.Controls.Add(this.roomPrice_LB);
            this.panelMngRoom.Controls.Add(this.roomCapacity_LB);
            this.panelMngRoom.Controls.Add(this.bed_TB);
            this.panelMngRoom.Controls.Add(this.capacity_TB);
            this.panelMngRoom.Controls.Add(this.roomBed_BT);
            this.panelMngRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMngRoom.Location = new System.Drawing.Point(0, 0);
            this.panelMngRoom.Name = "panelMngRoom";
            this.panelMngRoom.Size = new System.Drawing.Size(1688, 1028);
            this.panelMngRoom.TabIndex = 44;
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1688, 1028);
            this.Controls.Add(this.panelMngRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRoomsForm";
            this.Text = "ManageRoomsForm";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room_DGV)).EndInit();
            this.panelMngRoom.ResumeLayout(false);
            this.panelMngRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView room_DGV;
        private Guna.UI2.WinForms.Guna2ComboBox roomType_CBO;
        private System.Windows.Forms.Label roomType_LB;
        private Guna.UI2.WinForms.Guna2TextBox price_TB;
        private System.Windows.Forms.Label roomPrice_LB;
        private Guna.UI2.WinForms.Guna2TextBox bed_TB;
        private System.Windows.Forms.Label roomBed_BT;
        private Guna.UI2.WinForms.Guna2TextBox capacity_TB;
        private System.Windows.Forms.Label roomCapacity_LB;
        private Guna.UI2.WinForms.Guna2Button add_BT;
        private Guna.UI2.WinForms.Guna2Button delete_BT;
        private Guna.UI2.WinForms.Guna2Button showRoomType_BT;
        private Guna.UI2.WinForms.Guna2Button showRoom_BT;
        private System.Windows.Forms.Panel panelMngRoom;
    }
}