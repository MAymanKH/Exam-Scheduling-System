using System.Drawing;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    // Simple UI only. No logic.
    public class TimetableForm : Form
    {
        // Dashboard colors
        Color dark   = Color.FromArgb(17, 24, 39);   // main background
        Color card   = Color.FromArgb(30, 41, 59);   // cards
        Color purple = Color.FromArgb(79, 70, 229);

        public TimetableForm()
        {
            // Form settings
            TopLevel = false;                        // so it can sit inside frmMain's panel
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            BackColor = dark;
            ForeColor = Color.White;
            Padding = new Padding(24);

            // ----- Table (fills the middle) -----
            var grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            grid.BackgroundColor = dark;
            grid.BorderStyle = BorderStyle.None;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = dark;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.BackColor = dark;
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = purple;
            grid.Columns.Add("c1", "Course");
            grid.Columns.Add("c2", "Date");
            grid.Columns.Add("c3", "Start");
            grid.Columns.Add("c4", "End");
            grid.Columns.Add("c5", "Room");
            grid.Columns.Add("c6", "Students");

            // ----- Bottom panel: change room / slot -----
            var bottom = new Panel();
            bottom.Dock = DockStyle.Bottom;
            bottom.Height = 100;
            bottom.BackColor = card;

            var room = new ComboBox { Left = 16, Top = 30, Width = 160, DropDownStyle = ComboBoxStyle.DropDownList };
            var date = new DateTimePicker { Left = 190, Top = 30, Width = 120, Format = DateTimePickerFormat.Short };
            var start = new DateTimePicker { Left = 325, Top = 30, Width = 80, Format = DateTimePickerFormat.Time, ShowUpDown = true };
            var end = new DateTimePicker { Left = 420, Top = 30, Width = 80, Format = DateTimePickerFormat.Time, ShowUpDown = true };
            var apply = new Button { Text = "Apply Change", Left = 520, Top = 26, Width = 130, Height = 32, FlatStyle = FlatStyle.Flat, BackColor = purple };
            var status = new Label { Left = 16, Top = 70, Width = 700, Text = "Select an exam to change its room or slot." };

            bottom.Controls.AddRange(new Control[] { room, date, start, end, apply, status });

            // ----- Top: title + Generate button -----
            var top = new Panel();
            top.Dock = DockStyle.Top;
            top.Height = 60;

            var title = new Label { Text = "Timetable", Font = new Font("Segoe UI", 20f), AutoSize = true, Left = 0, Top = 10 };
            var generate = new Button { Text = "Generate", Width = 150, Height = 38, Top = 8, FlatStyle = FlatStyle.Flat, BackColor = purple };
            top.Controls.Add(title);
            top.Controls.Add(generate);
            top.Resize += (s, e) => generate.Left = top.Width - generate.Width; // keep button on the right

            // Add order matters: Fill first, then Bottom, then Top
            var gridCard = new Panel { Dock = DockStyle.Fill, BackColor = card, Padding = new Padding(16) };
            gridCard.Controls.Add(grid);

            Controls.Add(gridCard);
            Controls.Add(bottom);
            Controls.Add(top);
        }
    }
}
