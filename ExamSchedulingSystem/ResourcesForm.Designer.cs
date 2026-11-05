namespace Resource_Form
{
    partial class ResourcesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbRooms = new GroupBox();
            dgvRooms = new DataGridView();
            btnRemoveRoom = new Button();
            btnAddRoom = new Button();
            txtCapacity = new TextBox();
            txtRoomName = new TextBox();
            lblCapacity = new Label();
            llblRoomName = new Label();
            grpTimeSlots = new GroupBox();
            dgvSlots = new DataGridView();
            btnRemoveSlot = new Button();
            btnAddSlot = new Button();
            dtpEndTime = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpExamDate = new DateTimePicker();
            lblEndTime = new Label();
            lblStartTime = new Label();
            lblExamDate = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            grbRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            grpTimeSlots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSlots).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbRooms
            // 
            grbRooms.Controls.Add(dgvRooms);
            grbRooms.Controls.Add(btnRemoveRoom);
            grbRooms.Controls.Add(btnAddRoom);
            grbRooms.Controls.Add(txtCapacity);
            grbRooms.Controls.Add(txtRoomName);
            grbRooms.Controls.Add(lblCapacity);
            grbRooms.Controls.Add(llblRoomName);
            grbRooms.ForeColor = Color.White;
            grbRooms.Location = new Point(10, 10);
            grbRooms.Name = "grbRooms";
            grbRooms.Size = new Size(1083, 212);
            grbRooms.TabIndex = 0;
            grbRooms.TabStop = false;
            grbRooms.Text = "Rooms Mangement";
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(14, 97);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(546, 109);
            dgvRooms.TabIndex = 6;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // btnRemoveRoom
            // 
            btnRemoveRoom.BackColor = Color.FromArgb(79, 70, 229);
            btnRemoveRoom.Location = new Point(647, 119);
            btnRemoveRoom.Name = "btnRemoveRoom";
            btnRemoveRoom.Size = new Size(237, 57);
            btnRemoveRoom.TabIndex = 5;
            btnRemoveRoom.Text = "Remove Selected Room";
            btnRemoveRoom.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(79, 70, 229);
            btnAddRoom.Location = new Point(682, 56);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(163, 48);
            btnAddRoom.TabIndex = 4;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = Color.White;
            txtCapacity.Location = new Point(327, 43);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(136, 27);
            txtCapacity.TabIndex = 3;
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(15, 43);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(254, 27);
            txtRoomName.TabIndex = 2;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.ForeColor = SystemColors.ButtonFace;
            lblCapacity.Location = new Point(355, 17);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(66, 20);
            lblCapacity.TabIndex = 1;
            lblCapacity.Text = "Capacity";
            // 
            // llblRoomName
            // 
            llblRoomName.AutoSize = true;
            llblRoomName.BackColor = Color.Transparent;
            llblRoomName.ForeColor = SystemColors.ButtonFace;
            llblRoomName.Location = new Point(10, 20);
            llblRoomName.Name = "llblRoomName";
            llblRoomName.Size = new Size(93, 20);
            llblRoomName.TabIndex = 1;
            llblRoomName.Text = "Room Name";
            // 
            // grpTimeSlots
            // 
            grpTimeSlots.Controls.Add(dgvSlots);
            grpTimeSlots.Controls.Add(btnRemoveSlot);
            grpTimeSlots.Controls.Add(btnAddSlot);
            grpTimeSlots.Controls.Add(dtpEndTime);
            grpTimeSlots.Controls.Add(dtpStartTime);
            grpTimeSlots.Controls.Add(dtpExamDate);
            grpTimeSlots.Controls.Add(lblEndTime);
            grpTimeSlots.Controls.Add(lblStartTime);
            grpTimeSlots.Controls.Add(lblExamDate);
            grpTimeSlots.ForeColor = Color.White;
            grpTimeSlots.Location = new Point(10, 229);
            grpTimeSlots.Name = "grpTimeSlots";
            grpTimeSlots.Size = new Size(1083, 222);
            grpTimeSlots.TabIndex = 1;
            grpTimeSlots.TabStop = false;
            grpTimeSlots.Text = "Dates & Time Slots";
            // 
            // dgvSlots
            // 
            dgvSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSlots.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlots.Location = new Point(14, 115);
            dgvSlots.Name = "dgvSlots";
            dgvSlots.ReadOnly = true;
            dgvSlots.RowHeadersWidth = 51;
            dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlots.Size = new Size(546, 101);
            dgvSlots.TabIndex = 8;
            // 
            // btnRemoveSlot
            // 
            btnRemoveSlot.BackColor = Color.FromArgb(79, 70, 229);
            btnRemoveSlot.Location = new Point(647, 115);
            btnRemoveSlot.Name = "btnRemoveSlot";
            btnRemoveSlot.Size = new Size(237, 57);
            btnRemoveSlot.TabIndex = 7;
            btnRemoveSlot.Text = "Remove Selected Slot";
            btnRemoveSlot.UseVisualStyleBackColor = false;
            // 
            // btnAddSlot
            // 
            btnAddSlot.BackColor = Color.FromArgb(79, 70, 229);
            btnAddSlot.Location = new Point(682, 46);
            btnAddSlot.Name = "btnAddSlot";
            btnAddSlot.Size = new Size(163, 56);
            btnAddSlot.TabIndex = 6;
            btnAddSlot.Text = "Add Date & Slot";
            btnAddSlot.UseVisualStyleBackColor = false;
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(371, 59);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(127, 27);
            dtpEndTime.TabIndex = 5;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(212, 59);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(127, 27);
            dtpStartTime.TabIndex = 4;
            // 
            // dtpExamDate
            // 
            dtpExamDate.Format = DateTimePickerFormat.Short;
            dtpExamDate.Location = new Point(15, 59);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(162, 27);
            dtpExamDate.TabIndex = 3;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.ForeColor = Color.White;
            lblEndTime.Location = new Point(371, 23);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(71, 20);
            lblEndTime.TabIndex = 2;
            lblEndTime.Text = "End Time";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.ForeColor = Color.White;
            lblStartTime.Location = new Point(212, 23);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(77, 20);
            lblStartTime.TabIndex = 1;
            lblStartTime.Text = "Start Time";
            // 
            // lblExamDate
            // 
            lblExamDate.AutoSize = true;
            lblExamDate.ForeColor = Color.White;
            lblExamDate.Location = new Point(10, 23);
            lblExamDate.Name = "lblExamDate";
            lblExamDate.Size = new Size(81, 20);
            lblExamDate.TabIndex = 0;
            lblExamDate.Text = "Exam Date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(10, 457);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1083, 239);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room Unavailability";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 41, 59);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(546, 101);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(79, 70, 229);
            button1.Location = new Point(647, 124);
            button1.Name = "button1";
            button1.Size = new Size(237, 57);
            button1.TabIndex = 7;
            button1.Text = "Mark Room as Unavailable";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(79, 70, 229);
            button2.Location = new Point(689, 46);
            button2.Name = "button2";
            button2.Size = new Size(156, 56);
            button2.TabIndex = 6;
            button2.Text = "Restore Availabale";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(179, 61);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(347, 61);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 23);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 2;
            label4.Text = " Select Slot";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 23);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 1;
            label5.Text = "Select Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 23);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 0;
            label6.Text = "Select Room";
            // 
            // ResourcesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1126, 730);
            Controls.Add(groupBox1);
            Controls.Add(grpTimeSlots);
            Controls.Add(grbRooms);
            Name = "ResourcesForm";
            Text = "Resources Management";
            Load += Form1_Load;
            grbRooms.ResumeLayout(false);
            grbRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            grpTimeSlots.ResumeLayout(false);
            grpTimeSlots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSlots).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbRooms;
        private Label llblRoomName;
        private Label lblCapacity;
        private TextBox txtCapacity;
        private TextBox txtRoomName;
        private DataGridView dgvRooms;
        private Button btnRemoveRoom;
        private Button btnAddRoom;
        private GroupBox grpTimeSlots;
        private Label lblEndTime;
        private Label lblStartTime;
        private Label lblExamDate;
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpExamDate;
        private Button btnRemoveSlot;
        private Button btnAddSlot;
        private DataGridView dgvSlots;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
