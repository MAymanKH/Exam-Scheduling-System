namespace ExamSchedulingSystem
{
    internal static class AppStyle
    {
        internal static readonly Font Body = new("Segoe UI", 10F);
        internal static readonly Font Action = new("Segoe UI", 10F, FontStyle.Bold);
        internal static readonly Font Navigation = new("Segoe UI", 12F);
        internal static readonly Font NavigationSelected = new("Segoe UI", 12F, FontStyle.Bold);
        internal static readonly Font Heading = new("Segoe UI", 20F);
        internal static readonly Font Brand = new("Segoe UI", 16F, FontStyle.Bold);
        internal static readonly Font Section = new("Segoe UI", 16F);
        internal static readonly Font Metric = new("Segoe UI", 25F, FontStyle.Bold);
        internal const int ButtonHeight = 40;

        internal static void Apply(Form form)
        {
            form.SuspendLayout();
            var scaling = form.AutoScaleMode;
            // Preserve designer geometry while normalizing fonts; subsequent DPI scaling still applies.
            form.AutoScaleMode = AutoScaleMode.None;
            form.Font = Body;
            ApplyChildren(form);
            form.AutoScaleDimensions = form.CurrentAutoScaleDimensions;
            form.AutoScaleMode = scaling;
            form.ResumeLayout(true);
            RoundedCorners.Apply(form);
        }

        private static void ApplyChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Font = Body;
                switch (control)
                {
                    case Button button:
                        button.Font = Action;
                        button.AutoSize = false;
                        button.Height = ButtonHeight;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                        button.Cursor = Cursors.Hand;
                        break;
                    case LinkLabel link:
                        link.LinkColor = Color.FromArgb(165, 180, 252);
                        link.ActiveLinkColor = Color.White;
                        link.VisitedLinkColor = link.LinkColor;
                        break;
                    case DataGridView grid:
                        grid.EnableHeadersVisualStyles = false;
                        grid.BorderStyle = BorderStyle.None;
                        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        grid.GridColor = Color.FromArgb(45, 55, 80);
                        grid.BackgroundColor = Color.FromArgb(17, 24, 39);
                        grid.DefaultCellStyle.BackColor = Color.FromArgb(17, 24, 39);
                        grid.DefaultCellStyle.ForeColor = Color.White;
                        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(79, 70, 229);
                        grid.DefaultCellStyle.SelectionForeColor = Color.White;
                        grid.RowsDefaultCellStyle = new DataGridViewCellStyle();
                        grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(22, 32, 50) };
                        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(17, 24, 39);
                        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(17, 24, 39);
                        grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(148, 163, 184);
                        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        foreach (DataGridViewColumn column in grid.Columns) column.MinimumWidth = 100;
                        grid.ColumnAdded += (_, e) => e.Column.MinimumWidth = 100;
                        grid.DefaultCellStyle.Font = Body;
                        grid.ColumnHeadersDefaultCellStyle.Font = Action;
                        grid.ColumnHeadersHeight = 36;
                        grid.RowTemplate.Height = 34;
                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                        grid.DefaultCellStyle.Padding = new Padding(4);
                        break;
                }
                ApplyChildren(control);
            }
        }
    }
}
