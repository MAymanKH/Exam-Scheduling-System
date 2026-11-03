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
            grpAvailability = new GroupBox();
            dgvUnavailable = new DataGridView();
            btnMarkUnavailable = new Button();
            btnRestoreAvailability = new Button();
            cmbRooms = new ComboBox();
            cmbDates = new ComboBox();
            cmbSlots = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dataGridView3 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            grbRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            grpTimeSlots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSlots).BeginInit();
            grpAvailability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnavailable).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
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
            grbRooms.Size = new Size(509, 180);
            grbRooms.TabIndex = 0;
            grbRooms.TabStop = false;
            grbRooms.Text = "Rooms Mangement";
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.FromArgb(17, 24, 39);
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(14, 97);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(440, 77);
            dgvRooms.TabIndex = 6;
            dgvRooms.CellContentClick += dgvRooms_CellContentClick;
            // 
            // btnRemoveRoom
            // 
            btnRemoveRoom.BackColor = Color.FromArgb(79, 70, 229);
            btnRemoveRoom.Location = new Point(310, 39);
            btnRemoveRoom.Name = "btnRemoveRoom";
            btnRemoveRoom.Size = new Size(125, 27);
            btnRemoveRoom.TabIndex = 5;
            btnRemoveRoom.Text = "Remove Selected Room";
            btnRemoveRoom.UseVisualStyleBackColor = false;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(79, 70, 229);
            btnAddRoom.Location = new Point(230, 39);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(75, 27);
            btnAddRoom.TabIndex = 4;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = Color.White;
            txtCapacity.Location = new Point(145, 40);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(75, 27);
            txtCapacity.TabIndex = 3;
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(10, 40);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(125, 27);
            txtRoomName.TabIndex = 2;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.ForeColor = SystemColors.ButtonFace;
            lblCapacity.Location = new Point(145, 20);
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
            grpTimeSlots.Location = new Point(10, 196);
            grpTimeSlots.Name = "grpTimeSlots";
            grpTimeSlots.Size = new Size(509, 198);
            grpTimeSlots.TabIndex = 1;
            grpTimeSlots.TabStop = false;
            grpTimeSlots.Text = "Dates & Time Slots";
            // 
            // dgvSlots
            // 
            dgvSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSlots.BackgroundColor = Color.FromArgb(17, 24, 39);
            dgvSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlots.Location = new Point(14, 115);
            dgvSlots.Name = "dgvSlots";
            dgvSlots.ReadOnly = true;
            dgvSlots.RowHeadersWidth = 51;
            dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlots.Size = new Size(440, 77);
            dgvSlots.TabIndex = 8;
            // 
            // btnRemoveSlot
            // 
            btnRemoveSlot.BackColor = Color.FromArgb(79, 70, 229);
            btnRemoveSlot.Location = new Point(246, 73);
            btnRemoveSlot.Name = "btnRemoveSlot";
            btnRemoveSlot.Size = new Size(171, 29);
            btnRemoveSlot.TabIndex = 7;
            btnRemoveSlot.Text = "Remove Selected Slot";
            btnRemoveSlot.UseVisualStyleBackColor = false;
            // 
            // btnAddSlot
            // 
            btnAddSlot.BackColor = Color.FromArgb(79, 70, 229);
            btnAddSlot.Location = new Point(83, 73);
            btnAddSlot.Name = "btnAddSlot";
            btnAddSlot.Size = new Size(163, 29);
            btnAddSlot.TabIndex = 6;
            btnAddSlot.Text = "Add Date & Slot";
            btnAddSlot.UseVisualStyleBackColor = false;
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(336, 40);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(127, 27);
            dtpEndTime.TabIndex = 5;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(192, 40);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(127, 27);
            dtpStartTime.TabIndex = 4;
            // 
            // dtpExamDate
            // 
            dtpExamDate.Format = DateTimePickerFormat.Short;
            dtpExamDate.Location = new Point(10, 40);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(162, 27);
            dtpExamDate.TabIndex = 3;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.ForeColor = Color.White;
            lblEndTime.Location = new Point(336, 23);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(71, 20);
            lblEndTime.TabIndex = 2;
            lblEndTime.Text = "End Time";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.ForeColor = Color.White;
            lblStartTime.Location = new Point(192, 23);
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
            // grpAvailability
            // 
            grpAvailability.Controls.Add(groupBox1);
            grpAvailability.Controls.Add(groupBox2);
            grpAvailability.Controls.Add(groupBox3);
            grpAvailability.Controls.Add(dgvUnavailable);
            grpAvailability.Controls.Add(btnMarkUnavailable);
            grpAvailability.Controls.Add(btnRestoreAvailability);
            grpAvailability.Controls.Add(cmbRooms);
            grpAvailability.Controls.Add(cmbDates);
            grpAvailability.Controls.Add(cmbSlots);
            grpAvailability.Controls.Add(label3);
            grpAvailability.Controls.Add(label2);
            grpAvailability.Controls.Add(label1);
            grpAvailability.ForeColor = Color.White;
            grpAvailability.Location = new Point(12, 400);
            grpAvailability.Name = "grpAvailability";
            grpAvailability.Size = new Size(509, 210);
            grpAvailability.TabIndex = 2;
            grpAvailability.TabStop = false;
            grpAvailability.Text = "Room Unavailability";
            // 
            // dgvUnavailable
            // 
            dgvUnavailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnavailable.BackgroundColor = Color.FromArgb(17, 24, 39);
            dgvUnavailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnavailable.GridColor = SystemColors.InactiveBorder;
            dgvUnavailable.Location = new Point(12, 127);
            dgvUnavailable.Name = "dgvUnavailable";
            dgvUnavailable.ReadOnly = true;
            dgvUnavailable.RowHeadersWidth = 51;
            dgvUnavailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnavailable.Size = new Size(440, 77);
            dgvUnavailable.TabIndex = 8;
            dgvUnavailable.CellContentClick += dgvUnavailable_CellContentClick;
            // 
            // btnMarkUnavailable
            // 
            btnMarkUnavailable.BackColor = Color.FromArgb(79, 70, 229);
            btnMarkUnavailable.Location = new Point(245, 80);
            btnMarkUnavailable.Name = "btnMarkUnavailable";
            btnMarkUnavailable.Size = new Size(207, 29);
            btnMarkUnavailable.TabIndex = 7;
            btnMarkUnavailable.Text = "Mark Room as Unavailable";
            btnMarkUnavailable.UseVisualStyleBackColor = false;
            // 
            // btnRestoreAvailability
            // 
            btnRestoreAvailability.BackColor = Color.FromArgb(79, 70, 229);
            btnRestoreAvailability.Location = new Point(83, 80);
            btnRestoreAvailability.Name = "btnRestoreAvailability";
            btnRestoreAvailability.Size = new Size(156, 29);
            btnRestoreAvailability.TabIndex = 6;
            btnRestoreAvailability.Text = "Restore Availabale";
            btnRestoreAvailability.UseVisualStyleBackColor = false;
            // 
            // cmbRooms
            // 
            cmbRooms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRooms.FormattingEnabled = true;
            cmbRooms.Location = new Point(10, 46);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(151, 28);
            cmbRooms.TabIndex = 5;
            // 
            // cmbDates
            // 
            cmbDates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDates.FormattingEnabled = true;
            cmbDates.Location = new Point(179, 46);
            cmbDates.Name = "cmbDates";
            cmbDates.Size = new Size(151, 28);
            cmbDates.TabIndex = 4;
            // 
            // cmbSlots
            // 
            cmbSlots.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSlots.FormattingEnabled = true;
            cmbSlots.Location = new Point(347, 46);
            cmbSlots.Name = "cmbSlots";
            cmbSlots.Size = new Size(151, 28);
            cmbSlots.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(347, 23);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = " Select Slot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(179, 23);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Select Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Select Room";
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
            groupBox1.Location = new Point(0, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 198);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room Unavailability";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 41, 59);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(438, 77);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(79, 70, 229);
            button1.Location = new Point(245, 80);
            button1.Name = "button1";
            button1.Size = new Size(207, 29);
            button1.TabIndex = 7;
            button1.Text = "Mark Room as Unavailable";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(79, 70, 229);
            button2.Location = new Point(83, 80);
            button2.Name = "button2";
            button2.Size = new Size(156, 29);
            button2.TabIndex = 6;
            button2.Text = "Restore Availabale";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(179, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(347, 46);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(0, -10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 196);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dates & Time Slots";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(30, 41, 59);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(2, 108);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(438, 77);
            dataGridView2.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(79, 70, 229);
            button3.Location = new Point(246, 73);
            button3.Name = "button3";
            button3.Size = new Size(171, 29);
            button3.TabIndex = 7;
            button3.Text = "Remove Selected Slot";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(79, 70, 229);
            button4.Location = new Point(76, 73);
            button4.Name = "button4";
            button4.Size = new Size(163, 29);
            button4.TabIndex = 6;
            button4.Text = "Add Date & Slot";
            button4.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.BlanchedAlmond;
            dateTimePicker1.CustomFormat = "hh:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(336, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(127, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "hh:mm tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(192, 40);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(127, 27);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(10, 40);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(162, 27);
            dateTimePicker3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 17);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 2;
            label7.Text = "End Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(192, 17);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 1;
            label8.Text = "Start Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 17);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 0;
            label9.Text = "Exam Date";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView3);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(0, -180);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(509, 180);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rooms Mangement";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.FromArgb(30, 41, 59);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 87);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(440, 77);
            dataGridView3.TabIndex = 6;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(79, 70, 229);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(310, 39);
            button5.Name = "button5";
            button5.Size = new Size(125, 27);
            button5.TabIndex = 5;
            button5.Text = "Remove Selected Room";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(79, 70, 229);
            button6.Location = new Point(230, 39);
            button6.Name = "button6";
            button6.Size = new Size(75, 27);
            button6.TabIndex = 4;
            button6.Text = "Add Room";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(145, 20);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 1;
            label10.Text = "Capacity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 20);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 1;
            label11.Text = "Room Name";
            // 
            // ResourcesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(606, 636);
            Controls.Add(grpAvailability);
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
            grpAvailability.ResumeLayout(false);
            grpAvailability.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnavailable).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private GroupBox grpAvailability;
        private ComboBox cmbRooms;
        private ComboBox cmbDates;
        private ComboBox cmbSlots;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnMarkUnavailable;
        private Button btnRestoreAvailability;
        private DataGridView dgvUnavailable;
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
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox3;
        private DataGridView dataGridView3;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label10;
        private Label label11;
    }
}
