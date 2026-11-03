namespace ExamSchedulingSystem
{
    partial class CoursesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblCode = new Label();
            lblName = new Label();
            txtCourseCode = new TextBox();
            txtCourseName = new TextBox();
            btnAddCourse = new Button();
            btnClear = new Button();
            btnAddExam = new Button();
            dgvCourses = new DataGridView();
            btnViewExam = new Button();
            lblSubtitle = new Label();
            pnlTotalCourses = new Panel();
            lblTotalCoursesValue = new Label();
            lblTotalCoursesTitle = new Label();
            pnlScheduled = new Panel();
            lblScheduledValue = new Label();
            lblScheduledTitle = new Label();
            pnlPending = new Panel();
            lblPendingValue = new Label();
            lblPendingTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            pnlTotalCourses.SuspendLayout();
            pnlScheduled.SuspendLayout();
            pnlPending.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(377, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Courses Managment";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.BackColor = Color.Transparent;
            lblCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCode.ForeColor = Color.FromArgb(203, 213, 225);
            lblCode.Location = new Point(30, 255);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(110, 23);
            lblCode.TabIndex = 1;
            lblCode.Text = "Course Code";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(203, 213, 225);
            lblName.Location = new Point(290, 255);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Course Name";
            // 
            // txtCourseCode
            // 
            txtCourseCode.BackColor = Color.FromArgb(30, 41, 59);
            txtCourseCode.BorderStyle = BorderStyle.FixedSingle;
            txtCourseCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseCode.ForeColor = Color.White;
            txtCourseCode.Location = new Point(30, 285);
            txtCourseCode.Multiline = true;
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(224, 34);
            txtCourseCode.TabIndex = 3;
            // 
            // txtCourseName
            // 
            txtCourseName.BackColor = Color.FromArgb(30, 41, 59);
            txtCourseName.BorderStyle = BorderStyle.FixedSingle;
            txtCourseName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCourseName.ForeColor = Color.White;
            txtCourseName.Location = new Point(290, 285);
            txtCourseName.Multiline = true;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(224, 34);
            txtCourseName.TabIndex = 4;
            // 
            // btnAddCourse
            // 
            btnAddCourse.BackColor = Color.FromArgb(37, 99, 235);
            btnAddCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            btnAddCourse.FlatStyle = FlatStyle.Flat;
            btnAddCourse.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCourse.ForeColor = Color.White;
            btnAddCourse.Location = new Point(30, 340);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(150, 42);
            btnAddCourse.TabIndex = 5;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(51, 65, 85);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(195, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddExam
            // 
            btnAddExam.BackColor = Color.FromArgb(16, 185, 129);
            btnAddExam.FlatAppearance.BorderSize = 0;
            btnAddExam.FlatStyle = FlatStyle.Flat;
            btnAddExam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExam.ForeColor = Color.White;
            btnAddExam.Location = new Point(30, 700);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(150, 45);
            btnAddExam.TabIndex = 7;
            btnAddExam.Text = "Add Exam";
            btnAddExam.UseVisualStyleBackColor = false;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.FromArgb(15, 23, 42);
            dgvCourses.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCourses.ColumnHeadersHeight = 42;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCourses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCourses.EnableHeadersVisualStyles = false;
            dgvCourses.Location = new Point(30, 420);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(760, 250);
            dgvCourses.TabIndex = 8;
            // 
            // btnViewExam
            // 
            btnViewExam.BackColor = Color.FromArgb(71, 85, 105);
            btnViewExam.FlatAppearance.BorderSize = 0;
            btnViewExam.FlatStyle = FlatStyle.Flat;
            btnViewExam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewExam.ForeColor = Color.White;
            btnViewExam.Location = new Point(195, 700);
            btnViewExam.Name = "btnViewExam";
            btnViewExam.Size = new Size(150, 45);
            btnViewExam.TabIndex = 9;
            btnViewExam.Text = "View Exam";
            btnViewExam.UseVisualStyleBackColor = false;
            btnViewExam.Click += btnViewExam_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.ForeColor = Color.Silver;
            lblSubtitle.Location = new Point(34, 77);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(332, 23);
            lblSubtitle.TabIndex = 10;
            lblSubtitle.Text = "Manage your courses and exam schedules";
            // 
            // pnlTotalCourses
            // 
            pnlTotalCourses.BackColor = Color.FromArgb(30, 41, 59);
            pnlTotalCourses.Controls.Add(lblTotalCoursesValue);
            pnlTotalCourses.Controls.Add(lblTotalCoursesTitle);
            pnlTotalCourses.Location = new Point(30, 110);
            pnlTotalCourses.Name = "pnlTotalCourses";
            pnlTotalCourses.Size = new Size(240, 105);
            pnlTotalCourses.TabIndex = 11;
            // 
            // lblTotalCoursesValue
            // 
            lblTotalCoursesValue.AutoSize = true;
            lblTotalCoursesValue.BackColor = Color.Transparent;
            lblTotalCoursesValue.Cursor = Cursors.No;
            lblTotalCoursesValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCoursesValue.Location = new Point(20, 42);
            lblTotalCoursesValue.Name = "lblTotalCoursesValue";
            lblTotalCoursesValue.Size = new Size(46, 54);
            lblTotalCoursesValue.TabIndex = 14;
            lblTotalCoursesValue.Text = "0";
            // 
            // lblTotalCoursesTitle
            // 
            lblTotalCoursesTitle.AutoSize = true;
            lblTotalCoursesTitle.BackColor = Color.Transparent;
            lblTotalCoursesTitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblTotalCoursesTitle.Location = new Point(20, 15);
            lblTotalCoursesTitle.Name = "lblTotalCoursesTitle";
            lblTotalCoursesTitle.Size = new Size(111, 23);
            lblTotalCoursesTitle.TabIndex = 13;
            lblTotalCoursesTitle.Text = "Total Courses";
            // 
            // pnlScheduled
            // 
            pnlScheduled.BackColor = Color.FromArgb(30, 41, 59);
            pnlScheduled.Controls.Add(lblScheduledValue);
            pnlScheduled.Controls.Add(lblScheduledTitle);
            pnlScheduled.Location = new Point(290, 110);
            pnlScheduled.Name = "pnlScheduled";
            pnlScheduled.Size = new Size(240, 105);
            pnlScheduled.TabIndex = 12;
            // 
            // lblScheduledValue
            // 
            lblScheduledValue.AutoSize = true;
            lblScheduledValue.BackColor = Color.Transparent;
            lblScheduledValue.Cursor = Cursors.No;
            lblScheduledValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScheduledValue.Location = new Point(20, 42);
            lblScheduledValue.Name = "lblScheduledValue";
            lblScheduledValue.Size = new Size(46, 54);
            lblScheduledValue.TabIndex = 14;
            lblScheduledValue.Text = "0";
            // 
            // lblScheduledTitle
            // 
            lblScheduledTitle.AutoSize = true;
            lblScheduledTitle.BackColor = Color.Transparent;
            lblScheduledTitle.ForeColor = Color.FromArgb(52, 211, 153);
            lblScheduledTitle.Location = new Point(20, 15);
            lblScheduledTitle.Name = "lblScheduledTitle";
            lblScheduledTitle.Size = new Size(142, 23);
            lblScheduledTitle.TabIndex = 13;
            lblScheduledTitle.Text = "Scheduled Exams";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.FromArgb(30, 41, 59);
            pnlPending.Controls.Add(lblPendingValue);
            pnlPending.Controls.Add(lblPendingTitle);
            pnlPending.Location = new Point(550, 110);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(240, 105);
            pnlPending.TabIndex = 13;
            // 
            // lblPendingValue
            // 
            lblPendingValue.AutoSize = true;
            lblPendingValue.BackColor = Color.Transparent;
            lblPendingValue.Cursor = Cursors.No;
            lblPendingValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingValue.Location = new Point(20, 42);
            lblPendingValue.Name = "lblPendingValue";
            lblPendingValue.Size = new Size(46, 54);
            lblPendingValue.TabIndex = 14;
            lblPendingValue.Text = "0";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.BackColor = Color.Transparent;
            lblPendingTitle.ForeColor = Color.FromArgb(251, 191, 36);
            lblPendingTitle.Location = new Point(20, 15);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(125, 23);
            lblPendingTitle.TabIndex = 13;
            lblPendingTitle.Text = "Pending Exams";
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1124, 981);
            Controls.Add(pnlPending);
            Controls.Add(pnlScheduled);
            Controls.Add(pnlTotalCourses);
            Controls.Add(lblSubtitle);
            Controls.Add(btnViewExam);
            Controls.Add(dgvCourses);
            Controls.Add(btnAddExam);
            Controls.Add(btnClear);
            Controls.Add(btnAddCourse);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseCode);
            Controls.Add(lblName);
            Controls.Add(lblCode);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "CoursesForm";
            Text = "CoursesForm";
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            pnlTotalCourses.ResumeLayout(false);
            pnlTotalCourses.PerformLayout();
            pnlScheduled.ResumeLayout(false);
            pnlScheduled.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCode;
        private Label lblName;
        private TextBox txtCourseCode;
        private TextBox txtCourseName;
        private Button btnAddCourse;
        private Button btnClear;
        private Button btnAddExam;
        private DataGridView dgvCourses;
        private Button btnViewExam;
        private Label lblSubtitle;
        private Panel pnlTotalCourses;
        private Label lblTotalCoursesTitle;
        private Label lblTotalCoursesValue;
        private Panel pnlScheduled;
        private Label lblScheduledValue;
        private Label lblScheduledTitle;
        private Panel pnlPending;
        private Label lblPendingValue;
        private Label lblPendingTitle;
    }
}