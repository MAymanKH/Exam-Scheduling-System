using System.Data;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class Student_information : Form
    {
        public Student_information()
        {
            InitializeComponent();
            AppStyle.Apply(this);
            lblDataTitle.Font = AppStyle.Heading;
            button1.Width = 190;
            ResponsiveLayout.Import(this, label1, textBox1, button1, pnlData);
        }

        private void button1_Click_1(object? sender, EventArgs e)
        {
            var students = new DataTable();
            students.Columns.Add("Student ID");
            students.Columns.Add("Student Name");
            students.Columns.Add("Courses");
            students.Rows.Add("2026001", "Omar Hassan", "CS101, MATH201");
            students.Rows.Add("2026002", "Nour Ahmed", "CS101, IS201");
            students.Rows.Add("2026003", "Salma Ali", "CS102, MATH201");
            students.Rows.Add("2026004", "Youssef Adel", "CS102, IS201");
            students.Rows.Add("2026005", "Mariam Khaled", "CS101, CS102");
            students.Rows.Add("2026006", "Karim Mostafa", "MATH201, IS201");
            dataGridView1.DataSource = students;
        }
    }
}
