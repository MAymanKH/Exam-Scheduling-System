namespace ExamSchedulingSystem
{
    partial class StudentsForm
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
            clbCourses = new CheckedListBox();
            cmbStudents = new ComboBox();
            btnSaveCourses = new Button();
            lblAvailableCourses = new Label();
            lblSelectStudents = new Label();
            dgvStudents = new DataGridView();
            txtStudentId = new TextBox();
            txtStudentName = new TextBox();
            btnAddStudent = new Button();
            lblStudentName = new Label();
            lblStudentId = new Label();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // clbCourses
            // 
            clbCourses.BackColor = Color.FromArgb(30, 41, 59);
            clbCourses.Font = new Font("Segoe UI", 14F);
            clbCourses.ForeColor = Color.AliceBlue;
            clbCourses.FormattingEnabled = true;
            clbCourses.Location = new Point(615, 202);
            clbCourses.Name = "clbCourses";
            clbCourses.Size = new Size(211, 106);
            clbCourses.TabIndex = 19;
            clbCourses.SelectedIndexChanged += clbCourses_SelectedIndexChanged;
            // 
            // cmbStudents
            // 
            cmbStudents.BackColor = SystemColors.ActiveCaption;
            cmbStudents.Font = new Font("Segoe UI", 14F);
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(200, 202);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(192, 39);
            cmbStudents.TabIndex = 18;
            cmbStudents.SelectedIndexChanged += cmbStudents_SelectedIndexChanged;
            // 
            // btnSaveCourses
            // 
            btnSaveCourses.BackColor = Color.FromArgb(79, 70, 229);
            btnSaveCourses.FlatAppearance.BorderSize = 0;
            btnSaveCourses.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnSaveCourses.FlatStyle = FlatStyle.Flat;
            btnSaveCourses.Font = new Font("Calibri", 15F);
            btnSaveCourses.ForeColor = Color.White;
            btnSaveCourses.Location = new Point(832, 211);
            btnSaveCourses.Name = "btnSaveCourses";
            btnSaveCourses.Size = new Size(180, 39);
            btnSaveCourses.TabIndex = 17;
            btnSaveCourses.Text = "Save Cources";
            btnSaveCourses.UseVisualStyleBackColor = false;
            btnSaveCourses.Click += btnSaveCourses_Click;
            // 
            // lblAvailableCourses
            // 
            lblAvailableCourses.AutoSize = true;
            lblAvailableCourses.Font = new Font("Segoe UI", 15F);
            lblAvailableCourses.ForeColor = Color.AliceBlue;
            lblAvailableCourses.Location = new Point(398, 202);
            lblAvailableCourses.Name = "lblAvailableCourses";
            lblAvailableCourses.Size = new Size(211, 35);
            lblAvailableCourses.TabIndex = 1;
            lblAvailableCourses.Text = "Available Cources";
            lblAvailableCourses.Click += lblAvailableCourses_Click;
            // 
            // lblSelectStudents
            // 
            lblSelectStudents.AutoSize = true;
            lblSelectStudents.Font = new Font("Segoe UI", 15F);
            lblSelectStudents.ForeColor = Color.AliceBlue;
            lblSelectStudents.Location = new Point(12, 202);
            lblSelectStudents.Name = "lblSelectStudents";
            lblSelectStudents.Size = new Size(182, 35);
            lblSelectStudents.TabIndex = 0;
            lblSelectStudents.Text = "Select Students";
            lblSelectStudents.Click += lblSelectStudents_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = Color.FromArgb(30, 41, 59);
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName });
            dgvStudents.Location = new Point(12, 334);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(814, 181);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // txtStudentId
            // 
            txtStudentId.BackColor = SystemColors.ActiveCaption;
            txtStudentId.Location = new Point(615, 59);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(161, 27);
            txtStudentId.TabIndex = 15;
            txtStudentId.TextChanged += txtStudentId_TextChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = SystemColors.ActiveCaption;
            txtStudentName.Location = new Point(200, 56);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(169, 27);
            txtStudentName.TabIndex = 14;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(79, 70, 229);
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Calibri", 15F);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(832, 56);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(180, 39);
            btnAddStudent.TabIndex = 13;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 15F);
            lblStudentName.ForeColor = Color.MintCream;
            lblStudentName.Location = new Point(12, 47);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(173, 35);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name";
            lblStudentName.Click += lblStudentName_Click;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 15F);
            lblStudentId.ForeColor = Color.AliceBlue;
            lblStudentId.Location = new Point(398, 51);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(128, 35);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student Id";
            lblStudentId.Click += lblStudentId_Click;
            // 
            // StudentID
            // 
            StudentID.DataPropertyName = "Student ID";
            StudentID.HeaderText = "Student ID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.Width = 200;
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "Student Name";
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.Width = 550;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1027, 527);
            Controls.Add(dgvStudents);
            Controls.Add(cmbStudents);
            Controls.Add(lblSelectStudents);
            Controls.Add(lblAvailableCourses);
            Controls.Add(btnAddStudent);
            Controls.Add(btnSaveCourses);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(clbCourses);
            Name = "StudentsForm";
            Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox clbCourses;
        private ComboBox cmbStudents;
        private Button btnSaveCourses;
        private Label lblAvailableCourses;
        private Label lblSelectStudents;
        private DataGridView dgvStudents;
        private TextBox txtStudentId;
        private TextBox txtStudentName;
        private Button btnAddStudent;
        private Label lblStudentName;
        private Label lblStudentId;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
    }
}