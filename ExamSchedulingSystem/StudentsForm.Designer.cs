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
            lblStudentName = new Label();
            lblStudentId = new Label();
            lblSelectStudent = new Label();
            txtStudentId = new TextBox();
            txtStudentName = new TextBox();
            btnAddStudent = new Button();
            dgvStudents = new DataGridView();
            cmbStudents = new ComboBox();
            clbCourses = new CheckedListBox();
            btnSaveCourses = new Button();
            lblCourses = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(77, 34);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(99, 20);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "student name";
            lblStudentName.Click += label1_Click;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(528, 34);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(75, 20);
            lblStudentId.TabIndex = 1;
            lblStudentId.Text = "student id";
            lblStudentId.Click += label2_Click;
            // 
            // lblSelectStudent
            // 
            lblSelectStudent.AutoSize = true;
            lblSelectStudent.Location = new Point(77, 391);
            lblSelectStudent.Name = "lblSelectStudent";
            lblSelectStudent.Size = new Size(106, 20);
            lblSelectStudent.TabIndex = 2;
            lblSelectStudent.Text = "select students";
            lblSelectStudent.Click += label3_Click;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(654, 34);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 3;
            txtStudentId.TextChanged += textBox1_TextChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(230, 41);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 4;
            txtStudentName.TextChanged += textBox2_TextChanged;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(998, 41);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(143, 29);
            btnAddStudent.TabIndex = 5;
            btnAddStudent.Text = "add student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += button1_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(120, 99);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(753, 221);
            dgvStudents.TabIndex = 6;
            dgvStudents.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(230, 383);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 7;
            cmbStudents.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // clbCourses
            // 
            clbCourses.FormattingEnabled = true;
            clbCourses.Location = new Point(584, 383);
            clbCourses.Name = "clbCourses";
            clbCourses.Size = new Size(150, 114);
            clbCourses.TabIndex = 8;
            clbCourses.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnSaveCourses
            // 
            btnSaveCourses.Location = new Point(919, 416);
            btnSaveCourses.Name = "btnSaveCourses";
            btnSaveCourses.Size = new Size(148, 29);
            btnSaveCourses.TabIndex = 9;
            btnSaveCourses.Text = "save courses";
            btnSaveCourses.UseVisualStyleBackColor = true;
            btnSaveCourses.Click += button2_Click;
            // 
            // lblCourses
            // 
            lblCourses.AutoSize = true;
            lblCourses.Location = new Point(445, 386);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(122, 20);
            lblCourses.TabIndex = 10;
            lblCourses.Text = "available courses";
            lblCourses.Click += label1_Click_1;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 553);
            Controls.Add(lblCourses);
            Controls.Add(btnSaveCourses);
            Controls.Add(clbCourses);
            Controls.Add(cmbStudents);
            Controls.Add(dgvStudents);
            Controls.Add(btnAddStudent);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentId);
            Controls.Add(lblSelectStudent);
            Controls.Add(lblStudentId);
            Controls.Add(lblStudentName);
            Name = "StudentsForm";
            Text = "StudentsForm";
            Load += StudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private Label lblStudentId;
        private Label lblSelectStudent;
        private TextBox txtStudentId;
        private TextBox txtStudentName;
        private Button btnAddStudent;
        private DataGridView dgvStudents;
        private ComboBox cmbStudents;
        private CheckedListBox clbCourses;
        private Button btnSaveCourses;
        private Label lblCourses;
    }
}