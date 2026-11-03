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

        private List<ExamInfo> exams = new List<ExamInfo>();

        public CoursesForm()
        {
            InitializeComponent();

            dgvCourses.Columns.Clear();

            dgvCourses.Columns.Add("Code", "Course Code");
            dgvCourses.Columns.Add("Name", "Course Name");
            dgvCourses.Columns.Add("Status", "Exam Status");
        }


        private void UpdateStatistics()
        {
            int total = dgvCourses.Rows.Count;

            int scheduled = exams.Count;

            int pending = total - scheduled;

            lblTotalCoursesValue.Text = total.ToString();
            lblScheduledValue.Text = scheduled.ToString();
            lblPendingValue.Text = pending.ToString();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course first");
                return;
            }

            string selectedCode = dgvCourses.SelectedRows[0]
                    .Cells["Code"].Value.ToString();

            foreach (ExamInfo exam in exams)
            {
                if (exam.CourseCode == selectedCode)
                {
                    MessageBox.Show("This course already has an exam");
                    return;
                }
            }

            using (AddExamForm examForm = new AddExamForm())
            {
                if (examForm.ShowDialog() == DialogResult.OK)
                {
                    string courseCode = dgvCourses.SelectedRows[0]
                        .Cells["Code"].Value.ToString();

                    DateTime examDate = examForm.ExamDate;
                    DateTime startTime = examForm.StartTime;
                    string room = examForm.SelectedRoom;

                    ExamInfo newExam = new ExamInfo
                    {
                        CourseCode = courseCode,
                        ExamDate = examDate,
                        StartTime = startTime,
                        Room = room
                    };


                    DateTime newStart = examDate.Date + startTime.TimeOfDay;
                    DateTime newEnd = newStart.AddHours(2);

                    bool roomConflict = exams.Any(exam =>
                    {
                        DateTime existingStart =
                            exam.ExamDate.Date + exam.StartTime.TimeOfDay;

                        DateTime existingEnd = existingStart.AddHours(2);

                        return exam.Room == room &&
                               newStart < existingEnd &&
                               newEnd > existingStart;
                    });

                    if (roomConflict)
                    {
                        MessageBox.Show("Room is already booked at this time");
                        return;
                    }

                    exams.Add(newExam);
                    UpdateStatistics();

                    dgvCourses.SelectedRows[0].Cells["Status"].Value = "Scheduled";

                    MessageBox.Show(
                        "Course: " + courseCode +
                        "\nDate: " + examDate.ToShortDateString() +
                        "\nTime: " + startTime.ToShortTimeString() +
                        "\nRoom: " + room
                    );
                }
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string code = txtCourseCode.Text.Trim();
            string name = txtCourseName.Text.Trim();

            // Check empty fields
            if (code == "" || name == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            // Check duplicate course code
            foreach (DataGridViewRow row in dgvCourses.Rows)
            {
                if (row.Cells["Code"].Value?.ToString()
                    .Equals(code, StringComparison.OrdinalIgnoreCase) == true)
                {
                    MessageBox.Show("Course code already exists");
                    return;
                }
            }

            // Add course to the table
            dgvCourses.Rows.Add(code, name, "Not Scheduled");
            UpdateStatistics();

            MessageBox.Show("Course added successfully");

            // Clear textboxes
            txtCourseCode.Clear();
            txtCourseName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseCode.Clear();
            txtCourseName.Clear();
            txtCourseCode.Focus();
        }

        private void btnViewExam_Click(object sender, EventArgs e)
        {

            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course first");
                return;
            }

            string courseCode = dgvCourses.SelectedRows[0]
                .Cells["Code"].Value.ToString();

            ExamInfo selectedExam = exams.FirstOrDefault(
                exam => exam.CourseCode == courseCode
            );

            if (selectedExam == null)
            {
                MessageBox.Show("No exam scheduled for this course");
                return;
            }

            MessageBox.Show(
                "Course: " + selectedExam.CourseCode +
                "\nDate: " + selectedExam.ExamDate.ToShortDateString() +
                "\nStart Time: " + selectedExam.StartTime.ToShortTimeString() +
                "\nEnd Time: " + selectedExam.StartTime.AddHours(2).ToShortTimeString() +
                "\nRoom: " + selectedExam.Room,
                "Exam Details"
            );

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
