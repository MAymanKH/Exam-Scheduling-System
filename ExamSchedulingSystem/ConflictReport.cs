using System.Globalization;

namespace ExamSchedulingSystem
{
    internal static class ConflictReport
    {
        internal sealed record Conflict(SampleData.Student Student, SampleData.Exam First, SampleData.Exam Second);

        internal static List<Conflict> Find(IEnumerable<SampleData.Student> students, IEnumerable<SampleData.Exam> exams)
        {
            var schedule = exams.Select(exam => new
            {
                Exam = exam,
                Start = TimeOnly.ParseExact(exam.Start, "HH:mm", CultureInfo.InvariantCulture),
                End = TimeOnly.ParseExact(exam.End, "HH:mm", CultureInfo.InvariantCulture)
            }).OrderBy(item => item.Exam.Date.Date).ThenBy(item => item.Start).ToArray();
            var conflicts = new List<Conflict>();
            foreach (var student in students)
            {
                var enrolled = schedule.Where(item => student.Courses.Contains(item.Exam.Course)).ToArray();
                for (int i = 0; i < enrolled.Length; i++)
                    for (int j = i + 1; j < enrolled.Length; j++)
                    {
                        var first = enrolled[i];
                        var second = enrolled[j];
                        if (first.Exam.Course != second.Exam.Course && first.Exam.Date.Date == second.Exam.Date.Date
                            && first.Start < second.End && second.Start < first.End)
                            conflicts.Add(new Conflict(student, first.Exam, second.Exam));
                    }
            }
            return conflicts;
        }
    }
}
