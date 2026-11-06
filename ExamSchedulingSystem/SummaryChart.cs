namespace ExamSchedulingSystem
{
    internal sealed class SummaryChart : Control
    {
        private readonly string title;
        private readonly (string Label, int Value)[] values;
        private readonly string suffix;

        internal SummaryChart(string title, IEnumerable<(string Label, int Value)> values, string suffix = "")
        {
            this.title = title;
            this.values = values.ToArray();
            this.suffix = suffix;
            Name = "summaryChart";
            BackColor = Color.FromArgb(30, 41, 59);
            ForeColor = Color.White;
            Font = AppStyle.Body;
            Height = ResponsiveLayout.Pixels(this, 186);
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            AccessibleName = title;
            AccessibleDescription = string.Join("; ", this.values.Select(v => $"{v.Label}: {v.Value}{suffix}"));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int P(int value) => ResponsiveLayout.Pixels(this, value);
            var g = e.Graphics;
            int count = Math.Min(values.Length, Math.Max(1, (Height - P(44)) / P(26)));
            string caption = count < values.Length ? title + $" (top {count})" : title;
            TextRenderer.DrawText(g, caption, AppStyle.Action, new Rectangle(P(16), P(10), Width - P(32), P(24)), ForeColor,
                TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
            int max = suffix == "%" ? 100 : Math.Max(1, values.Select(v => v.Value).DefaultIfEmpty().Max());
            int rowHeight = Math.Max(P(20), (Height - P(44)) / Math.Max(1, count));
            int labelWidth = P(90), valueWidth = P(46);
            int barWidth = Math.Max(1, Width - labelWidth - valueWidth - P(40));
            using var track = new SolidBrush(Color.FromArgb(45, 55, 80));
            using var fill = new SolidBrush(Color.FromArgb(129, 140, 248));
            for (int i = 0; i < count; i++)
            {
                int y = P(40) + i * rowHeight;
                TextRenderer.DrawText(g, values[i].Label, Font, new Rectangle(P(16), y, labelWidth, rowHeight), ForeColor, TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
                g.FillRectangle(track, P(16) + labelWidth, y + P(4), barWidth, P(10));
                g.FillRectangle(fill, P(16) + labelWidth, y + P(4), barWidth * values[i].Value / max, P(10));
                TextRenderer.DrawText(g, $"{values[i].Value}{suffix}", Font, new Rectangle(Width - valueWidth - P(12), y, valueWidth, rowHeight), ForeColor, TextFormatFlags.Right | TextFormatFlags.NoPadding);
            }
        }

        internal static SummaryChart Subjects() => new("Enrollments by subject", SampleData.Exams
            .GroupBy(e => new string(e.Course.TakeWhile(char.IsLetter).ToArray())).Select(g => (g.Key, g.Sum(e => e.Students))));
        internal static SummaryChart Days() => new("Busiest exam days", SampleData.Exams.GroupBy(e => e.Date)
            .OrderByDescending(g => g.Count()).ThenBy(g => g.Key).Take(5).Select(g => (g.Key.ToString("dd MMM"), g.Count())));
        internal static SummaryChart Enrollment() => new("Most enrolled courses", SampleData.Exams.OrderByDescending(e => e.Students)
            .Take(5).Select(e => (e.Course, e.Students)));
        internal static SummaryChart Utilization() => new("Busiest rooms · seats used (%)", SampleData.Rooms.Select(room =>
            (room.Name, Value: (int)Math.Round(100d * SampleData.Exams.Where(e => e.Room == room.Name).Sum(e => e.Students) /
                (room.Capacity * SampleData.Exams.Count(e => e.Room == room.Name)))))
            .OrderByDescending(v => v.Value).Take(5), "%");
    }
}
