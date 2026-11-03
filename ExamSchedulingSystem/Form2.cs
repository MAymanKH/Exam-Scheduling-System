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
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
            studentsTable.Columns.Add("Student ID");
            studentsTable.Columns.Add("Student Name");

            dgvStudents.DataSource = studentsTable;

            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string id = txtId.Text;

            if (name == "" || id == "")
            {
                MessageBox.Show("Please enter student name and ID");
                return;
            }

            studentsTable.Rows.Add(id, name);

            cmbStudents.Items.Add(id);

            studentCourses[id] = new List<string>();

            txtName.Clear();
            txtId.Clear();

            MessageBox.Show("Student Added Successfully");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbCourses.Items.Clear();

            clbCourses.Items.AddRange(availableCourses.ToArray());

            if (cmbStudents.SelectedItem == null)
                return;

            string id = cmbStudents.SelectedItem.ToString();

            if (studentCourses.ContainsKey(id))
            {
                for (int i = 0; i < clbCourses.Items.Count; i++)
                {
                    if (studentCourses[id].Contains(clbCourses.Items[i].ToString()))
                    {
                        clbCourses.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void clbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveCources_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select a student first");
                return;
            }

            string id = cmbStudents.SelectedItem.ToString();

            studentCourses[id].Clear();

            foreach (var course in clbCourses.CheckedItems)
            {
                studentCourses[id].Add(course.ToString());
            }

            MessageBox.Show("Courses Saved Successfully");
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
