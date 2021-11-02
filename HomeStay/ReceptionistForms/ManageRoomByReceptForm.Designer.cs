
namespace HomeStay.ReceptionistForms
{
    partial class ManageRoomByReceptForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.room_DGV = new System.Windows.Forms.DataGridView();
            this.panelMngRoom = new System.Windows.Forms.Panel();
            this.clean_BT = new Guna.UI2.WinForms.Guna2Button();
            this.janitor_CBO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomDirty_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.room_DGV)).BeginInit();
            this.panelMngRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDirty_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // room_DGV
            // 
            this.room_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.room_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.room_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.room_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.room_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.room_DGV.ColumnHeadersHeight = 32;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.room_DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.room_DGV.EnableHeadersVisualStyles = false;
            this.room_DGV.Location = new System.Drawing.Point(13, 40);
            this.room_DGV.Name = "room_DGV";
            this.room_DGV.RowHeadersVisible = false;
            this.room_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.room_DGV.RowTemplate.DividerHeight = 1;
            this.room_DGV.RowTemplate.Height = 33;
            this.room_DGV.RowTemplate.ReadOnly = true;
            this.room_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.room_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.room_DGV.Size = new System.Drawing.Size(1262, 710);
            this.room_DGV.TabIndex = 2;
            this.room_DGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.room_DGV_CellMouseDoubleClick);
            // 
            // panelMngRoom
            // 
            this.panelMngRoom.Controls.Add(this.room_DGV);
            this.panelMngRoom.Location = new System.Drawing.Point(480, 8);
            this.panelMngRoom.Name = "panelMngRoom";
            this.panelMngRoom.Size = new System.Drawing.Size(1278, 778);
            this.panelMngRoom.TabIndex = 45;
            // 
            // clean_BT
            // 
            this.clean_BT.BorderRadius = 3;
            this.clean_BT.CheckedState.Parent = this.clean_BT;
            this.clean_BT.CustomImages.Parent = this.clean_BT;
            this.clean_BT.FillColor = System.Drawing.Color.ForestGreen;
            this.clean_BT.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean_BT.ForeColor = System.Drawing.Color.White;
            this.clean_BT.HoverState.Parent = this.clean_BT;
            this.clean_BT.Location = new System.Drawing.Point(12, 678);
            this.clean_BT.Name = "clean_BT";
            this.clean_BT.ShadowDecoration.Parent = this.clean_BT;
            this.clean_BT.Size = new System.Drawing.Size(462, 80);
            this.clean_BT.TabIndex = 41;
            this.clean_BT.Text = "Clean Room";
            this.clean_BT.Click += new System.EventHandler(this.clean_BT_Click);
            // 
            // janitor_CBO
            // 
            this.janitor_CBO.BackColor = System.Drawing.Color.Transparent;
            this.janitor_CBO.BorderThickness = 3;
            this.janitor_CBO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.janitor_CBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.janitor_CBO.FocusedColor = System.Drawing.Color.Empty;
            this.janitor_CBO.FocusedState.Parent = this.janitor_CBO;
            this.janitor_CBO.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janitor_CBO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.janitor_CBO.FormattingEnabled = true;
            this.janitor_CBO.HoverState.Parent = this.janitor_CBO;
            this.janitor_CBO.IntegralHeight = false;
            this.janitor_CBO.ItemHeight = 40;
            this.janitor_CBO.ItemsAppearance.Parent = this.janitor_CBO;
            this.janitor_CBO.Location = new System.Drawing.Point(12, 93);
            this.janitor_CBO.Name = "janitor_CBO";
            this.janitor_CBO.ShadowDecoration.Parent = this.janitor_CBO;
            this.janitor_CBO.Size = new System.Drawing.Size(244, 46);
            this.janitor_CBO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.janitor_CBO.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 41;
            this.label1.Text = "Select Janitor";
            // 
            // roomDirty_DGV
            // 
            this.roomDirty_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDirty_DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(206)))), ((int)(((byte)(247)))));
            this.roomDirty_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.roomDirty_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDirty_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomDirty_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDirty_DGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.roomDirty_DGV.EnableHeadersVisualStyles = false;
            this.roomDirty_DGV.Location = new System.Drawing.Point(12, 191);
            this.roomDirty_DGV.Name = "roomDirty_DGV";
            this.roomDirty_DGV.RowHeadersVisible = false;
            this.roomDirty_DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.roomDirty_DGV.RowTemplate.DividerHeight = 1;
            this.roomDirty_DGV.RowTemplate.Height = 33;
            this.roomDirty_DGV.RowTemplate.ReadOnly = true;
            this.roomDirty_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDirty_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDirty_DGV.Size = new System.Drawing.Size(462, 468);
            this.roomDirty_DGV.TabIndex = 41;
            // 
            // ManageRoomByReceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1770, 798);
            this.Controls.Add(this.janitor_CBO);
            this.Controls.Add(this.clean_BT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomDirty_DGV);
            this.Controls.Add(this.panelMngRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRoomByReceptForm";
            this.Text = "ManageRoomByReceptForm";
            this.Load += new System.EventHandler(this.ManageRoomByReceptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room_DGV)).EndInit();
            this.panelMngRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDirty_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView room_DGV;
        private System.Windows.Forms.Panel panelMngRoom;
        private Guna.UI2.WinForms.Guna2Button clean_BT;
        private Guna.UI2.WinForms.Guna2ComboBox janitor_CBO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView roomDirty_DGV;
    }
}