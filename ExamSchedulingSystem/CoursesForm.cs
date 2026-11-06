using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ExamSchedulingSystem
{
    public partial class CoursesForm : Form
    {

        private DataTable studentsTable = new DataTable();

        public CoursesForm()
        {
            InitializeComponent();

            dgvStudents.Columns.Clear();

            dgvStudents.Columns.Add("StudentID", "Student ID");
            dgvStudents.Columns.Add("StudentName", "Student Name");

            studentsTable.Columns.Add("StudentID", typeof(string));
            studentsTable.Columns.Add("StudentName", typeof(string));
            studentsTable.Columns.Add("CourseCode", typeof(string));

            dgvCourses.Columns.Clear();

            dgvCourses.Columns.Add("Code", "Course Code");
            dgvCourses.Columns.Add("Name", "Course Name");
            dgvCourses.Columns.Add("Status", "Exam Status");
            dgvCourses.Columns["Name"].FillWeight = 180;
            dgvCourses.Rows.Add("CS101", "Introduction to Programming", "Not Scheduled");
            dgvCourses.Rows.Add("CS102", "Data Structures", "Not Scheduled");
            studentsTable.Rows.Add("2025001", "Ahmed Mohamed", "CS101");
            studentsTable.Rows.Add("2025002", "Omar Ali", "CS102");
            UpdateStatistics();
        }


        private void UpdateStatistics()
        {
            int total = dgvCourses.Rows.Count;

            int scheduled = studentsTable
             .AsEnumerable()
             .Select(row => row["StudentID"].ToString())
             .Distinct()
             .Count();

            int pending = studentsTable
             .AsEnumerable()
             .Select(row => row["CourseCode"].ToString())
             .Distinct()
             .Count();

            lblTotalCoursesValue.Text = total.ToString();
            lblScheduledValue.Text = scheduled.ToString();
            lblPendingValue.Text = pending.ToString();
        }


        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            dgvStudents.Rows.Clear();

            if (dgvCourses.CurrentRow == null)
            {
                return;
            }

            string courseCode = dgvCourses.CurrentRow.Cells["Code"].Value?.ToString();

            if (string.IsNullOrEmpty(courseCode))
            {
                return;
            }

            foreach (DataRow student in studentsTable.Rows)
            {
                if (student["CourseCode"].ToString() == courseCode)
                {
                    dgvStudents.Rows.Add(
                        student["StudentID"].ToString(),
                        student["StudentName"].ToString()
                    );
                }
            }
        }
    }

    public class ExamInfo
    {
        public string CourseCode { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime StartTime { get; set; }
        public string Room { get; set; }
    }
}
