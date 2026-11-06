using System.Data;

namespace ExamSchedulingSystem
{
    internal static class SampleData
    {
        internal sealed record Exam(string Course, DateTime Date, string Start, string End, string Room, int Students);

        internal static readonly Exam[] Exams =
        {
            new("CS101", new DateTime(2026, 12, 1), "09:00", "11:00", "Hall A", 3),
            new("MATH201", new DateTime(2026, 12, 1), "11:30", "13:30", "Hall B", 3),
            new("CS102", new DateTime(2026, 12, 2), "09:00", "11:00", "Hall A", 3),
            new("IS201", new DateTime(2026, 12, 2), "11:30", "13:30", "Lab 1", 3)
        };

        internal static DataTable Students()
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
            return students;
        }

        internal static DataTable Resources()
        {
            var resources = new DataTable();
            resources.Columns.Add("Room");
            resources.Columns.Add("Capacity", typeof(int));
            resources.Columns.Add("Exam Date", typeof(DateTime));
            resources.Columns.Add("Start Time");
            resources.Columns.Add("End Time");
            resources.Columns.Add("Available", typeof(bool));
            foreach (var exam in Exams)
            {
                foreach (var room in new[] { (Name: "Hall A", Capacity: 120), (Name: "Hall B", Capacity: 80), (Name: "Lab 1", Capacity: 30) })
                    resources.Rows.Add(room.Name, room.Capacity, exam.Date, exam.Start, exam.End, room.Name != exam.Room);
            }
            return resources;
        }
    }
}
