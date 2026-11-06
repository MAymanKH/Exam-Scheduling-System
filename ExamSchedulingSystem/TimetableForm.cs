using System.Drawing;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    // The design (colors, positions, controls) is in TimetableForm.Designer.cs.
    // Open this form in the Visual Studio Designer to edit it with the mouse.
    // This file is only for the CODE.
    public partial class TimetableForm : Form
    {
        internal event EventHandler? ViewConflictsRequested;

        public TimetableForm()
        {
            InitializeComponent();
            AppStyle.Apply(this);
            lblTitle.Font = AppStyle.Heading;
            Padding = new Padding(ResponsiveLayout.Pixels(this, ResponsiveLayout.PageTitleLeft), Padding.Top, Padding.Right, Padding.Bottom);
            lblTitle.Location = new Point(0, ResponsiveLayout.Pixels(this, ResponsiveLayout.PageTitleTop) - Padding.Top);
            foreach (var exam in SampleData.Exams)
                dgvTimetable.Rows.Add(exam.Course, exam.Date.ToString("dd MMM yyyy"), exam.Start, exam.End, exam.Room, exam.Students);
            MinimumSize = new Size(400, 500);
            var chart = SummaryChart.Days();
            chart.Dock = DockStyle.Top;
            Controls.Add(chart);
            Controls.SetChildIndex(chart, 2);
            void SizeChart() => chart.Height = Math.Clamp(ClientSize.Height / 4, 116, 186);
            Resize += (_, _) => SizeChart();
            SizeChart();
            void ArrangeHeader()
            {
                int gap = ResponsiveLayout.Pixels(this, 12);
                bool narrow = pnlHeader.Width < ResponsiveLayout.Pixels(this, 600);
                int actionTop = narrow ? lblTitle.Bottom + gap : gap;
                pnlHeader.Height = actionTop + btnGenerate.Height + gap;
                int width = Math.Min(ResponsiveLayout.Pixels(this, 170), (pnlHeader.Width - gap) / 2);
                btnGenerate.SetBounds(pnlHeader.Width - width, actionTop, width, btnGenerate.Height);
                btnViewConflicts.SetBounds(btnGenerate.Left - gap - width, actionTop, width, btnViewConflicts.Height);
            }
            pnlHeader.Resize += (_, _) => ArrangeHeader();
            ArrangeHeader();
            // These 3 lines are here (not in the Designer) so the Designer
            // still shows a normal form that you can edit.
            // At runtime they make the form sit INSIDE frmMain's panel.
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }

        // Click on "Generate" -> the logic will be added here later.
        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            // TODO
        }

    }
}
