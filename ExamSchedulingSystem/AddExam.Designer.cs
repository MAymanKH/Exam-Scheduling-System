namespace ExamSchedulingSystem
{
    partial class AddExamForm
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
            lblTitle = new Label();
            lblExamDate = new Label();
            dtpExamDate = new DateTimePicker();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblRoom = new Label();
            cmbRoom = new ComboBox();
            btnSaveExam = new Button();
            lblExamTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(34, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Exam";
            // 
            // lblExamDate
            // 
            lblExamDate.AutoSize = true;
            lblExamDate.BackColor = Color.Transparent;
            lblExamDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExamDate.ForeColor = Color.FromArgb(203, 213, 225);
            lblExamDate.Location = new Point(30, 115);
            lblExamDate.Name = "lblExamDate";
            lblExamDate.Size = new Size(96, 23);
            lblExamDate.TabIndex = 1;
            lblExamDate.Text = "Exam Date";
            // 
            // dtpExamDate
            // 
            dtpExamDate.CalendarForeColor = Color.White;
            dtpExamDate.CalendarMonthBackground = Color.FromArgb(30, 41, 59);
            dtpExamDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpExamDate.Format = DateTimePickerFormat.Short;
            dtpExamDate.Location = new Point(30, 145);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(440, 31);
            dtpExamDate.TabIndex = 2;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.BackColor = Color.Transparent;
            lblStartTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartTime.ForeColor = Color.FromArgb(203, 213, 225);
            lblStartTime.Location = new Point(30, 195);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(95, 23);
            lblStartTime.TabIndex = 3;
            lblStartTime.Text = "Start Time";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(30, 225);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(440, 31);
            dtpStartTime.TabIndex = 4;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.BackColor = Color.Transparent;
            lblRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoom.ForeColor = Color.FromArgb(203, 213, 225);
            lblRoom.Location = new Point(30, 275);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(110, 23);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Select Room";
            // 
            // cmbRoom
            // 
            cmbRoom.BackColor = Color.FromArgb(30, 41, 59);
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.FlatStyle = FlatStyle.Flat;
            cmbRoom.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoom.ForeColor = Color.White;
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(30, 305);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(440, 33);
            cmbRoom.TabIndex = 6;
            // 
            // btnSaveExam
            // 
            btnSaveExam.BackColor = Color.FromArgb(37, 99, 235);
            btnSaveExam.Cursor = Cursors.Hand;
            btnSaveExam.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnSaveExam.FlatStyle = FlatStyle.Flat;
            btnSaveExam.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveExam.ForeColor = Color.White;
            btnSaveExam.Location = new Point(30, 365);
            btnSaveExam.Name = "btnSaveExam";
            btnSaveExam.Size = new Size(440, 45);
            btnSaveExam.TabIndex = 7;
            btnSaveExam.TabStop = false;
            btnSaveExam.Text = "Save Exam";
            btnSaveExam.UseVisualStyleBackColor = false;
            btnSaveExam.Click += btnSaveExam_Click;
            // 
            // lblExamTitle
            // 
            lblExamTitle.AutoSize = true;
            lblExamTitle.BackColor = Color.Transparent;
            lblExamTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExamTitle.Location = new Point(30, 20);
            lblExamTitle.Name = "lblExamTitle";
            lblExamTitle.Size = new Size(339, 46);
            lblExamTitle.TabIndex = 8;
            lblExamTitle.Text = "Schedule New Exam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(148, 163, 184);
            label1.Location = new Point(32, 65);
            label1.Name = "label1";
            label1.Size = new Size(305, 23);
            label1.TabIndex = 9;
            label1.Text = "Choose the exam date, time and room";
            // 
            // AddExamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(581, 477);
            Controls.Add(label1);
            Controls.Add(lblExamTitle);
            Controls.Add(btnSaveExam);
            Controls.Add(cmbRoom);
            Controls.Add(lblRoom);
            Controls.Add(dtpStartTime);
            Controls.Add(lblStartTime);
            Controls.Add(dtpExamDate);
            Controls.Add(lblExamDate);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Exam";
            Load += AddExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblExamDate;
        private DateTimePicker dtpExamDate;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblRoom;
        private ComboBox cmbRoom;
        private Button btnSaveExam;
        private Label lblExamTitle;
        private Label label1;
    }
}