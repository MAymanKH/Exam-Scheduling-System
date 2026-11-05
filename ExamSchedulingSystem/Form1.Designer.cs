namespace ExamSchedulingSystem
{
    partial class frmMain
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
            pnlSidebar = new Panel();
            lblTitle = new Label();
            btnTimetable = new Button();
            btnStudents = new Button();
            btnDashboard = new Button();
            btnResources = new Button();
            btnCourses = new Button();
            pnlContent = new Panel();
            pnlSchedulePreview = new Panel();
            dgvSchedulePreview = new DataGridView();
            colCourse = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colHall = new DataGridViewTextBoxColumn();
            btnViewSchedule = new Button();
            lblScheduleTitle = new Label();
            pnlConflictsCard = new Panel();
            label6 = new Label();
            label7 = new Label();
            pnlHallsCard = new Panel();
            label8 = new Label();
            label9 = new Label();
            pnlCoursesCard = new Panel();
            label4 = new Label();
            label5 = new Label();
            pnlStudentsCard = new Panel();
            label2 = new Label();
            label3 = new Label();
            btnGenerateSchedule = new Button();
            label1 = new Label();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlSchedulePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedulePreview).BeginInit();
            pnlConflictsCard.SuspendLayout();
            pnlHallsCard.SuspendLayout();
            pnlCoursesCard.SuspendLayout();
            pnlStudentsCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(10, 18, 35);
            pnlSidebar.Controls.Add(lblTitle);
            pnlSidebar.Controls.Add(btnTimetable);
            pnlSidebar.Controls.Add(btnStudents);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnResources);
            pnlSidebar.Controls.Add(btnCourses);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 677);
            pnlSidebar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 45);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Exam Scheduler";
            // 
            // btnTimetable
            // 
            btnTimetable.FlatAppearance.BorderSize = 0;
            btnTimetable.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnTimetable.FlatStyle = FlatStyle.Flat;
            btnTimetable.Font = new Font("Calibri", 15F);
            btnTimetable.ForeColor = Color.White;
            btnTimetable.Location = new Point(12, 327);
            btnTimetable.Name = "btnTimetable";
            btnTimetable.Size = new Size(195, 40);
            btnTimetable.TabIndex = 4;
            btnTimetable.Text = "Timetable";
            btnTimetable.TextAlign = ContentAlignment.MiddleLeft;
            btnTimetable.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Calibri", 15F);
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(12, 156);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(195, 40);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(10, 18, 35);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Calibri", 15F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 94);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(195, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnResources
            // 
            btnResources.FlatAppearance.BorderSize = 0;
            btnResources.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnResources.FlatStyle = FlatStyle.Flat;
            btnResources.Font = new Font("Calibri", 15F);
            btnResources.ForeColor = Color.White;
            btnResources.Location = new Point(12, 271);
            btnResources.Name = "btnResources";
            btnResources.Size = new Size(195, 40);
            btnResources.TabIndex = 3;
            btnResources.Text = "Resources";
            btnResources.TextAlign = ContentAlignment.MiddleLeft;
            btnResources.UseVisualStyleBackColor = true;
            // 
            // btnCourses
            // 
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Calibri", 15F);
            btnCourses.ForeColor = Color.White;
            btnCourses.Location = new Point(12, 215);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(195, 40);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Courses";
            btnCourses.TextAlign = ContentAlignment.MiddleLeft;
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(17, 24, 39);
            pnlContent.Controls.Add(pnlSchedulePreview);
            pnlContent.Controls.Add(pnlConflictsCard);
            pnlContent.Controls.Add(pnlHallsCard);
            pnlContent.Controls.Add(pnlCoursesCard);
            pnlContent.Controls.Add(pnlStudentsCard);
            pnlContent.Controls.Add(btnGenerateSchedule);
            pnlContent.Controls.Add(label1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(938, 677);
            pnlContent.TabIndex = 1;
            // 
            // pnlSchedulePreview
            // 
            pnlSchedulePreview.BackColor = Color.FromArgb(30, 41, 59);
            pnlSchedulePreview.Controls.Add(dgvSchedulePreview);
            pnlSchedulePreview.Controls.Add(btnViewSchedule);
            pnlSchedulePreview.Controls.Add(lblScheduleTitle);
            pnlSchedulePreview.Location = new Point(19, 247);
            pnlSchedulePreview.Name = "pnlSchedulePreview";
            pnlSchedulePreview.Size = new Size(898, 403);
            pnlSchedulePreview.TabIndex = 12;
            // 
            // dgvSchedulePreview
            // 
            dgvSchedulePreview.AllowUserToAddRows = false;
            dgvSchedulePreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedulePreview.BackgroundColor = Color.FromArgb(17, 24, 39);
            dgvSchedulePreview.BorderStyle = BorderStyle.None;
            dgvSchedulePreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedulePreview.Columns.AddRange(new DataGridViewColumn[] { colCourse, colDate, colTime, colHall });
            dgvSchedulePreview.GridColor = Color.DarkOliveGreen;
            dgvSchedulePreview.Location = new Point(15, 97);
            dgvSchedulePreview.Name = "dgvSchedulePreview";
            dgvSchedulePreview.ReadOnly = true;
            dgvSchedulePreview.RowHeadersVisible = false;
            dgvSchedulePreview.RowHeadersWidth = 51;
            dgvSchedulePreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedulePreview.Size = new Size(862, 288);
            dgvSchedulePreview.TabIndex = 12;
            // 
            // colCourse
            // 
            colCourse.HeaderText = "Course";
            colCourse.MinimumWidth = 6;
            colCourse.Name = "colCourse";
            colCourse.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colHall
            // 
            colHall.HeaderText = "Hall";
            colHall.MinimumWidth = 6;
            colHall.Name = "colHall";
            colHall.ReadOnly = true;
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.BackColor = Color.FromArgb(30, 41, 59);
            btnViewSchedule.FlatAppearance.BorderSize = 0;
            btnViewSchedule.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnViewSchedule.FlatStyle = FlatStyle.Flat;
            btnViewSchedule.Font = new Font("Calibri", 14F);
            btnViewSchedule.ForeColor = Color.FromArgb(79, 70, 229);
            btnViewSchedule.Location = new Point(788, 24);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(89, 34);
            btnViewSchedule.TabIndex = 11;
            btnViewSchedule.Text = "View All";
            btnViewSchedule.UseVisualStyleBackColor = false;
            // 
            // lblScheduleTitle
            // 
            lblScheduleTitle.AutoSize = true;
            lblScheduleTitle.Font = new Font("Segoe UI", 20F);
            lblScheduleTitle.ForeColor = Color.White;
            lblScheduleTitle.Location = new Point(15, 21);
            lblScheduleTitle.Name = "lblScheduleTitle";
            lblScheduleTitle.Size = new Size(256, 46);
            lblScheduleTitle.TabIndex = 10;
            lblScheduleTitle.Text = "Exam Timetable";
            // 
            // pnlConflictsCard
            // 
            pnlConflictsCard.BackColor = Color.FromArgb(30, 41, 59);
            pnlConflictsCard.Controls.Add(label6);
            pnlConflictsCard.Controls.Add(label7);
            pnlConflictsCard.Location = new Point(471, 84);
            pnlConflictsCard.Name = "pnlConflictsCard";
            pnlConflictsCard.Size = new Size(220, 115);
            pnlConflictsCard.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(85, 50);
            label6.Name = "label6";
            label6.Size = new Size(49, 57);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(203, 41);
            label7.TabIndex = 9;
            label7.Text = "Total Conflicts";
            // 
            // pnlHallsCard
            // 
            pnlHallsCard.BackColor = Color.FromArgb(30, 41, 59);
            pnlHallsCard.Controls.Add(label8);
            pnlHallsCard.Controls.Add(label9);
            pnlHallsCard.Location = new Point(697, 84);
            pnlHallsCard.Name = "pnlHallsCard";
            pnlHallsCard.Size = new Size(220, 115);
            pnlHallsCard.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(87, 50);
            label8.Name = "label8";
            label8.Size = new Size(49, 57);
            label8.TabIndex = 10;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(4, 9);
            label9.Name = "label9";
            label9.Size = new Size(152, 41);
            label9.TabIndex = 9;
            label9.Text = "Total Halls";
            // 
            // pnlCoursesCard
            // 
            pnlCoursesCard.BackColor = Color.FromArgb(30, 41, 59);
            pnlCoursesCard.Controls.Add(label4);
            pnlCoursesCard.Controls.Add(label5);
            pnlCoursesCard.Location = new Point(245, 84);
            pnlCoursesCard.Name = "pnlCoursesCard";
            pnlCoursesCard.Size = new Size(220, 115);
            pnlCoursesCard.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(87, 50);
            label4.Name = "label4";
            label4.Size = new Size(49, 57);
            label4.TabIndex = 10;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 9);
            label5.Name = "label5";
            label5.Size = new Size(219, 46);
            label5.TabIndex = 9;
            label5.Text = "Total Courses";
            // 
            // pnlStudentsCard
            // 
            pnlStudentsCard.BackColor = Color.FromArgb(30, 41, 59);
            pnlStudentsCard.Controls.Add(label2);
            pnlStudentsCard.Controls.Add(label3);
            pnlStudentsCard.Location = new Point(19, 84);
            pnlStudentsCard.Name = "pnlStudentsCard";
            pnlStudentsCard.Size = new Size(220, 115);
            pnlStudentsCard.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 50);
            label2.Name = "label2";
            label2.Size = new Size(49, 57);
            label2.TabIndex = 10;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 9);
            label3.Name = "label3";
            label3.Size = new Size(205, 41);
            label3.TabIndex = 9;
            label3.Text = "Total Students";
            // 
            // btnGenerateSchedule
            // 
            btnGenerateSchedule.BackColor = Color.FromArgb(79, 70, 229);
            btnGenerateSchedule.FlatAppearance.BorderSize = 0;
            btnGenerateSchedule.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnGenerateSchedule.FlatStyle = FlatStyle.Flat;
            btnGenerateSchedule.Font = new Font("Calibri", 15F);
            btnGenerateSchedule.ForeColor = Color.White;
            btnGenerateSchedule.Location = new Point(733, 17);
            btnGenerateSchedule.Name = "btnGenerateSchedule";
            btnGenerateSchedule.Size = new Size(184, 40);
            btnGenerateSchedule.TabIndex = 7;
            btnGenerateSchedule.Text = "Generate Schedule";
            btnGenerateSchedule.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 22F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(182, 45);
            label1.TabIndex = 6;
            label1.Text = "Dashboard";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1158, 677);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 10F);
            Name = "frmMain";
            Text = "Exam Scheduling System";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlSchedulePreview.ResumeLayout(false);
            pnlSchedulePreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedulePreview).EndInit();
            pnlConflictsCard.ResumeLayout(false);
            pnlConflictsCard.PerformLayout();
            pnlHallsCard.ResumeLayout(false);
            pnlHallsCard.PerformLayout();
            pnlCoursesCard.ResumeLayout(false);
            pnlCoursesCard.PerformLayout();
            pnlStudentsCard.ResumeLayout(false);
            pnlStudentsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnTimetable;
        private Button btnResources;
        private Button btnCourses;
        private Button btnStudents;
        private Button btnDashboard;
        private Label lblTitle;
        private Panel pnlContent;
        private Button btnGenerateSchedule;
        private Label label1;
        private Panel pnlStudentsCard;
        private Label label2;
        private Label label3;
        private Panel pnlConflictsCard;
        private Label label6;
        private Label label7;
        private Panel pnlHallsCard;
        private Label label8;
        private Label label9;
        private Panel pnlCoursesCard;
        private Label label4;
        private Label label5;
        private Panel pnlSchedulePreview;
        private Label lblScheduleTitle;
        private DataGridView dgvSchedulePreview;
        private Button btnViewSchedule;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colHall;
    }
}
