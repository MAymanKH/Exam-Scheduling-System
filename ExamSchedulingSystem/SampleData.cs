using System.Data;

namespace ExamSchedulingSystem
{
    internal static class SampleData
    {
        internal sealed record Exam(string Course, DateTime Date, string Start, string End, string Room, int Students);
        internal sealed record Student(string Id, string Name, string[] Courses);
        internal sealed record Room(string Name, int Capacity);
        internal static readonly Room[] Rooms =
        {
            new("Hall A", 120), new("Hall B", 100), new("Hall C", 160), new("Hall D", 140),
            new("Lab 1", 80), new("Lab 2", 90), new("Room 201", 100), new("Room 202", 120)
        };
        internal static readonly string[] Courses = new[] { "CS", "MATH", "IS", "BUS" }
            .SelectMany(subject => Enumerable.Range(1, 6).Select(i => $"{subject}{100 + i}")).ToArray();
        internal static readonly Student[] StudentRecords = CreateStudents();
        internal static readonly Exam[] Exams = CreateExams();

        private static Student[] CreateStudents()
        {
            string[] first = { "Omar", "Nour", "Salma", "Youssef", "Mariam", "Karim", "Hana", "Ali", "Farah", "Ahmed", "Laila", "Adam", "Dina", "Hassan", "Sara", "Mostafa", "Rana", "Ziad" };
            string[] last = { "Hassan", "Ahmed", "Ali", "Adel", "Khaled", "Mostafa", "Ibrahim", "Mahmoud", "Samir", "Nasser", "Farouk", "Yassin", "Saleh", "Fathy", "Hamdy", "Saeed", "Kamal", "Fouad", "Mansour", "Ezz" };
            var random = new Random(2026);
            return Enumerable.Range(0, 360).Select(i => new Student($"{2026001 + i}",
                $"{first[i % first.Length]} {last[i / first.Length]}",
                Courses.OrderBy(_ => random.Next()).Take(3 + i % 3).OrderBy(c => c).ToArray())).ToArray();
        }

        private static Exam[] CreateExams()
        {
            int[] dailyCounts = { 2, 3, 1, 4, 2, 3, 4, 1, 2, 2 };
            string[] starts = { "09:00", "11:30", "14:00", "16:30" };
            string[] ends = { "11:00", "13:30", "16:00", "18:30" };
            var exams = new List<Exam>();
            for (int day = 0; day < dailyCounts.Length; day++)
                for (int slot = 0; slot < dailyCounts[day]; slot++)
                {
                    int i = exams.Count;
                    string course = Courses[i];
                    exams.Add(new Exam(course, new DateTime(2026, 12, 1).AddDays(day), starts[slot], ends[slot],
                        Rooms[i % Rooms.Length].Name, StudentRecords.Count(s => s.Courses.Contains(course))));
                }
            return exams.ToArray();
        }

        internal static DataTable Students()
        {
            var table = new DataTable();
            table.Columns.Add("Student ID");
            table.Columns.Add("Student Name");
            table.Columns.Add("Courses");
            foreach (var student in StudentRecords) table.Rows.Add(student.Id, student.Name, string.Join(", ", student.Courses));
            return table;
        }

        internal static DataTable Resources()
        {
            var table = new DataTable();
            table.Columns.Add("Room");
            table.Columns.Add("Capacity", typeof(int));
            table.Columns.Add("Exam Date", typeof(DateTime));
            table.Columns.Add("Start Time");
            table.Columns.Add("End Time");
            table.Columns.Add("Available", typeof(bool));
            foreach (var exam in Exams)
                foreach (var room in Rooms)
                    table.Rows.Add(room.Name, room.Capacity, exam.Date, exam.Start, exam.End, room.Name != exam.Room);
            return table;
        }
    }
}
