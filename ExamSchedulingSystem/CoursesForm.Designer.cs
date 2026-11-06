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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            dgvCourses = new DataGridView();
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
            dgvStudents = new DataGridView();
            lblCourseHeader = new Label();
            lblStudentsHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            pnlTotalCourses.SuspendLayout();
            pnlScheduled.SuspendLayout();
            pnlPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            lblTitle.Size = new Size(359, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Courses && Students";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCourses.BackgroundColor = Color.FromArgb(30, 45, 75);
            dgvCourses.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCourses.ColumnHeadersHeight = 42;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCourses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCourses.EnableHeadersVisualStyles = false;
            dgvCourses.Location = new Point(40, 270);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCourses.RowTemplate.Height = 38;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(440, 340);
            dgvCourses.TabIndex = 8;
            dgvCourses.SelectionChanged += dgvCourses_SelectionChanged;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.ForeColor = Color.Silver;
            lblSubtitle.Location = new Point(34, 77);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(279, 23);
            lblSubtitle.TabIndex = 10;
            lblSubtitle.Text = "View courses and enrolled students";
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
            lblScheduledTitle.Size = new Size(117, 23);
            lblScheduledTitle.TabIndex = 13;
            lblScheduledTitle.Text = "Total Students";
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
            lblPendingTitle.Size = new Size(177, 23);
            lblPendingTitle.TabIndex = 13;
            lblPendingTitle.Text = "Courses with students";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(30, 45, 75);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStudents.ColumnHeadersHeight = 42;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 55, 85);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle4;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.Location = new Point(500, 270);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 38;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(400, 340);
            dgvStudents.TabIndex = 14;
            // 
            // lblCourseHeader
            // 
            lblCourseHeader.AutoSize = true;
            lblCourseHeader.BackColor = Color.Transparent;
            lblCourseHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseHeader.Location = new Point(40, 235);
            lblCourseHeader.Name = "lblCourseHeader";
            lblCourseHeader.Size = new Size(201, 31);
            lblCourseHeader.TabIndex = 15;
            lblCourseHeader.Text = "Available Courses";
            // 
            // lblStudentsHeader
            // 
            lblStudentsHeader.AutoSize = true;
            lblStudentsHeader.BackColor = Color.Transparent;
            lblStudentsHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsHeader.Location = new Point(500, 235);
            lblStudentsHeader.Name = "lblStudentsHeader";
            lblStudentsHeader.Size = new Size(205, 31);
            lblStudentsHeader.TabIndex = 16;
            lblStudentsHeader.Text = "Enrroled Students";
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(982, 652);
            Controls.Add(lblStudentsHeader);
            Controls.Add(lblCourseHeader);
            Controls.Add(dgvStudents);
            Controls.Add(pnlPending);
            Controls.Add(pnlScheduled);
            Controls.Add(pnlTotalCourses);
            Controls.Add(lblSubtitle);
            Controls.Add(dgvCourses);
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
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCourses;
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
        private DataGridView dgvStudents;
        private Label lblCourseHeader;
        private Label lblStudentsHeader;
    }
}