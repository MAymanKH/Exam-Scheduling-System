using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class StudentsForm : Form
    {

        private DataTable studentsTable = new DataTable();

        private Dictionary<string, List<string>> studentCourses =
            new Dictionary<string, List<string>>();

        private List<string> availableCourses = new List<string>()
        {
            "CS101",
            "CS102",
            "MATH201",
            "IS201"
        };

        public StudentsForm()
        {
            InitializeComponent();
            studentsTable.Columns.Add("Student ID");
            studentsTable.Columns.Add("Student Name");

            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.DataSource = studentsTable;

            cmbStudents.DataSource = studentsTable;
            cmbStudents.DisplayMember = "Student Name";
            cmbStudents.ValueMember = "Student ID";

            clbCourses.Items.AddRange(availableCourses.ToArray());

            //btnAddStudent.Click += btnAddStudent_Click;
            //btnSaveCourses.Click += btnSaveCourses_Click;
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string studentId = txtStudentId.Text.Trim();

            if (studentName == "" || studentId == "")
            {
                MessageBox.Show("Please enter Student Name and ID");
                return;
            }

            foreach (DataRow row in studentsTable.Rows)
            {
                if (row["Student ID"].ToString() == studentId)
                {
                    MessageBox.Show("Student ID already exists");
                    return;
                }
            }

            studentsTable.Rows.Add(studentId, studentName);

            studentCourses[studentId] = new List<string>();

            txtStudentName.Clear();
            txtStudentId.Clear();

            MessageBox.Show("Student Added Successfully");
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSelectStudents_Click(object sender, EventArgs e)
        {

        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAvailableCourses_Click(object sender, EventArgs e)
        {

        }

        private void clbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveCourses_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null)
            {
                MessageBox.Show("Please select a student");
                return;
            }

            string studentId = cmbStudents.SelectedValue.ToString();

            List<string> selectedCourses = new List<string>();

            foreach (var item in clbCourses.CheckedItems)
            {
                selectedCourses.Add(item.ToString());
            }

            studentCourses[studentId] = selectedCourses;

            MessageBox.Show("Courses Saved Successfully");
        }
    }
}
