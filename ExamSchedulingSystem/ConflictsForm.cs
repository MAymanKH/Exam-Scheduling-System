using System.Data;

namespace ExamSchedulingSystem
{
    public sealed class ConflictsForm : Form
    {
        public ConflictsForm()
        {
            Text = "Conflicts";
            Name = "ConflictsForm";
            BackColor = Color.FromArgb(17, 24, 39);
            ForeColor = Color.White;
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1000, 640);
            Padding = new Padding(24);
            var conflicts = ConflictReport.Find(SampleData.StudentRecords, SampleData.Exams);
            var title = new Label { Text = "Conflict report", AutoSize = true, Margin = new Padding(0, 0, 0, 12) };
            var byCourse = new SummaryChart("Affected students by course", conflicts
                .SelectMany(c => new[] { (Course: c.First.Course, c.Student.Id), (Course: c.Second.Course, c.Student.Id) })
                .GroupBy(c => c.Course).Select(g => (g.Key, g.Select(c => c.Id).Distinct().Count()))
                .OrderByDescending(c => c.Item2).ThenBy(c => c.Key)) { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 8, 0) };
            var byDay = new SummaryChart("Conflicting exam pairs by day", conflicts
                .GroupBy(c => c.First.Date.Date).OrderBy(g => g.Key)
                .Select(g => (g.Key.ToString("dd MMM"), g.Count()))) { Dock = DockStyle.Fill, Margin = new Padding(8, 0, 0, 0) };
            var charts = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1, Margin = new Padding(0, 0, 0, 12) };
            charts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            charts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            charts.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            charts.Controls.Add(byCourse, 0, 0);
            charts.Controls.Add(byDay, 1, 0);
            var table = new DataTable();
            foreach (string column in new[] { "Student ID", "Student name", "Date", "Course 1", "Time 1", "Resource 1", "Course 2", "Time 2", "Resource 2" })
                table.Columns.Add(column);
            foreach (var conflict in conflicts)
                table.Rows.Add(conflict.Student.Id, conflict.Student.Name, conflict.First.Date.ToString("dd MMM yyyy"),
                    conflict.First.Course, $"{conflict.First.Start} – {conflict.First.End}", conflict.First.Room,
                    conflict.Second.Course, $"{conflict.Second.Start} – {conflict.Second.End}", conflict.Second.Room);
            var grid = new DataGridView
            {
                Name = "dgvConflicts", Dock = DockStyle.Fill, ReadOnly = true,
                AllowUserToAddRows = false, AllowUserToDeleteRows = false,
                RowHeadersVisible = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                DataSource = table, Margin = Padding.Empty
            };
            var card = new Panel
            {
                Name = "pnlGridCard", Dock = DockStyle.Fill, Padding = new Padding(16),
                BackColor = Color.FromArgb(30, 41, 59), Margin = Padding.Empty
            };
            card.Controls.Add(grid);
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 3 };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 198));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.Controls.Add(title, 0, 0);
            layout.Controls.Add(charts, 0, 1);
            layout.Controls.Add(card, 0, 2);
            Controls.Add(layout);
            AppStyle.Apply(this);
            title.Font = AppStyle.Heading;
            void ArrangeCharts()
            {
                bool narrow = charts.Width < ResponsiveLayout.Pixels(this, 700);
                charts.SetCellPosition(byDay, narrow ? new TableLayoutPanelCellPosition(0, 1) : new TableLayoutPanelCellPosition(1, 0));
                charts.ColumnCount = narrow ? 1 : 2;
                charts.RowCount = narrow ? 2 : 1;
                charts.ColumnStyles[0].Width = narrow ? 100 : 50;
                charts.RowStyles.Clear();
                charts.RowStyles.Add(new RowStyle(SizeType.Percent, narrow ? 50 : 100));
                if (narrow) charts.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                byCourse.Margin = narrow ? new Padding(0, 0, 0, 6) : new Padding(0, 0, 8, 0);
                byDay.Margin = narrow ? new Padding(0, 6, 0, 0) : new Padding(8, 0, 0, 0);
                layout.RowStyles[1].Height = ResponsiveLayout.Pixels(this, narrow ? 272 : 198);
            }
            charts.SizeChanged += (_, _) => ArrangeCharts();
            ArrangeCharts();
        }
    }
}
