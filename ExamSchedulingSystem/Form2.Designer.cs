namespace ExamSchedulingSystem
{
    partial class Form2
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
            pnlContent2 = new Panel();
            pnlCoursesCard = new Panel();
            panel1 = new Panel();
            txtId = new TextBox();
            txtName = new TextBox();
            btnAddStudent = new Button();
            pnlStudentName = new Panel();
            label1 = new Label();
            pnlStudentsId = new Panel();
            student = new Label();
            dgvStudents = new DataGridView();
            panel3 = new Panel();
            lblSelectStudents = new Label();
            lblCources = new Panel();
            lblCourcess = new Label();
            btnSaveCources = new Button();
            cmbStudents = new ComboBox();
            clbCourses = new CheckedListBox();
            pnlContent2.SuspendLayout();
            pnlCoursesCard.SuspendLayout();
            panel1.SuspendLayout();
            pnlStudentName.SuspendLayout();
            pnlStudentsId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            panel3.SuspendLayout();
            lblCources.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent2
            // 
            pnlContent2.BackColor = Color.FromArgb(17, 24, 39);
            pnlContent2.Controls.Add(clbCourses);
            pnlContent2.Controls.Add(cmbStudents);
            pnlContent2.Controls.Add(btnSaveCources);
            pnlContent2.Controls.Add(lblCources);
            pnlContent2.Controls.Add(panel3);
            pnlContent2.Controls.Add(pnlCoursesCard);
            pnlContent2.Controls.Add(panel1);
            pnlContent2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlContent2.Location = new Point(208, -3);
            pnlContent2.Name = "pnlContent2";
            pnlContent2.Size = new Size(897, 615);
            pnlContent2.TabIndex = 0;
            // 
            // pnlCoursesCard
            // 
            pnlCoursesCard.BackColor = Color.FromArgb(30, 41, 59);
            pnlCoursesCard.Controls.Add(dgvStudents);
            pnlCoursesCard.Location = new Point(16, 103);
            pnlCoursesCard.Name = "pnlCoursesCard";
            pnlCoursesCard.Size = new Size(862, 229);
            pnlCoursesCard.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 18, 35);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnAddStudent);
            panel1.Controls.Add(pnlStudentName);
            panel1.Controls.Add(pnlStudentsId);
            panel1.Location = new Point(16, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 82);
            panel1.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Location = new Point(481, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(161, 31);
            txtId.TabIndex = 15;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(169, 31);
            txtName.TabIndex = 14;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(79, 70, 229);
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(698, 22);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(118, 39);
            btnAddStudent.TabIndex = 13;
            btnAddStudent.Text = "add student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnGenerateSchedule_Click;
            // 
            // pnlStudentName
            // 
            pnlStudentName.BackColor = Color.FromArgb(30, 41, 59);
            pnlStudentName.Controls.Add(label1);
            pnlStudentName.Location = new Point(20, 22);
            pnlStudentName.Name = "pnlStudentName";
            pnlStudentName.Size = new Size(136, 43);
            pnlStudentName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // pnlStudentsId
            // 
            pnlStudentsId.BackColor = Color.FromArgb(30, 41, 59);
            pnlStudentsId.Controls.Add(student);
            pnlStudentsId.Location = new Point(337, 22);
            pnlStudentsId.Name = "pnlStudentsId";
            pnlStudentsId.Size = new Size(138, 43);
            pnlStudentsId.TabIndex = 10;
            // 
            // student
            // 
            student.AutoSize = true;
            student.ForeColor = Color.AliceBlue;
            student.Location = new Point(17, 9);
            student.Name = "student";
            student.Size = new Size(94, 25);
            student.TabIndex = 0;
            student.Text = "Student Id";
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = Color.DarkSlateBlue;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(20, 18);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(487, 181);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 41, 59);
            panel3.Controls.Add(lblSelectStudents);
            panel3.Location = new Point(36, 354);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 42);
            panel3.TabIndex = 15;
            // 
            // lblSelectStudents
            // 
            lblSelectStudents.AutoSize = true;
            lblSelectStudents.ForeColor = Color.AliceBlue;
            lblSelectStudents.Location = new Point(32, 5);
            lblSelectStudents.Name = "lblSelectStudents";
            lblSelectStudents.Size = new Size(132, 25);
            lblSelectStudents.TabIndex = 0;
            lblSelectStudents.Text = "Select Students";
            // 
            // lblCources
            // 
            lblCources.BackColor = Color.FromArgb(30, 41, 59);
            lblCources.Controls.Add(lblCourcess);
            lblCources.Location = new Point(353, 354);
            lblCources.Name = "lblCources";
            lblCources.Size = new Size(211, 42);
            lblCources.TabIndex = 16;
            // 
            // lblCourcess
            // 
            lblCourcess.AutoSize = true;
            lblCourcess.ForeColor = Color.AliceBlue;
            lblCourcess.Location = new Point(18, 9);
            lblCourcess.Name = "lblCourcess";
            lblCourcess.Size = new Size(151, 25);
            lblCourcess.TabIndex = 1;
            lblCourcess.Text = "Available Cources";
            // 
            // btnSaveCources
            // 
            btnSaveCources.BackColor = Color.FromArgb(79, 70, 229);
            btnSaveCources.FlatAppearance.BorderSize = 0;
            btnSaveCources.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 80);
            btnSaveCources.FlatStyle = FlatStyle.Flat;
            btnSaveCources.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveCources.ForeColor = Color.White;
            btnSaveCources.Location = new Point(711, 359);
            btnSaveCources.Name = "btnSaveCources";
            btnSaveCources.Size = new Size(131, 39);
            btnSaveCources.TabIndex = 17;
            btnSaveCources.Text = "Save Cources";
            btnSaveCources.UseVisualStyleBackColor = false;
            btnSaveCources.Click += btnSaveCources_Click;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(39, 419);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(198, 33);
            cmbStudents.TabIndex = 18;
            cmbStudents.SelectedIndexChanged += cmbStudents_SelectedIndexChanged;
            // 
            // clbCourses
            // 
            clbCourses.FormattingEnabled = true;
            clbCourses.Location = new Point(353, 419);
            clbCourses.Name = "clbCourses";
            clbCourses.Size = new Size(211, 108);
            clbCourses.TabIndex = 19;
            clbCourses.SelectedIndexChanged += clbCourses_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 611);
            Controls.Add(pnlContent2);
            Name = "Form2";
            Text = "Form2";
            pnlContent2.ResumeLayout(false);
            pnlCoursesCard.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlStudentName.ResumeLayout(false);
            pnlStudentName.PerformLayout();
            pnlStudentsId.ResumeLayout(false);
            pnlStudentsId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            lblCources.ResumeLayout(false);
            lblCources.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent2;
        private Panel pnlStudentsId;
        private Panel pnlStudentName;
        private Label student;
        private Label label1;
        private Panel panel1;
        private Button btnAddStudent;
        private Panel pnlCoursesCard;
        private TextBox txtId;
        private TextBox txtName;
        private DataGridView dgvStudents;
        private Panel panel3;
        private Label lblSelectStudents;
        private Button btnSaveCources;
        private Panel lblCources;
        private Label lblCourcess;
        private CheckedListBox clbCourses;
        private ComboBox cmbStudents;
    }
}