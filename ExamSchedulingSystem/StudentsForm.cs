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
        private Dictionary<string, List<string>> studentCourses = new Dictionary<string, List<string>>();

        private List<string> availableCourses = new List<string>
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

            dgvStudents.DataSource = studentsTable;

            clbCourses.Items.AddRange(availableCourses.ToArray());

            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text.Trim();
            string studentName = txtStudentName.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Please enter Student ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter Student Name.");
                return;
            }

            foreach (DataRow row in studentsTable.Rows)
            {
                if (row["Student ID"].ToString() == studentId)
                {
                    MessageBox.Show("Student ID already exists.");
                    return;
                }
            }

            studentsTable.Rows.Add(studentId, studentName);

            studentCourses[studentId] = new List<string>();

            cmbStudents.Items.Add(studentId);

            txtStudentId.Clear();
            txtStudentName.Clear();

            MessageBox.Show("Student added successfully.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem == null)
                return;

            string studentId = cmbStudents.SelectedItem.ToString();

            List<string> selectedCourses = studentCourses[studentId];

            for (int i = 0; i < clbCourses.Items.Count; i++)
            {
                string course = clbCourses.Items[i].ToString();

                clbCourses.SetItemChecked(
                    i,
                    selectedCourses.Contains(course)
                );
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            string studentId = cmbStudents.SelectedItem.ToString();

            List<string> selectedCourses = clbCourses.CheckedItems
                .Cast<string>()
                .ToList();

            studentCourses[studentId] = selectedCourses;

            MessageBox.Show("Courses saved successfully.");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
