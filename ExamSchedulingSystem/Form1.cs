
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class frmMain : Form
    {
        private Form? activeForm;
        private readonly Dictionary<Button, Form> pages = new();
        private readonly Panel dashboard;
        internal bool LogoutRequested { get; private set; }

        public frmMain()
        {
            InitializeComponent();
            AppStyle.Apply(this);
            lblTitle.Font = AppStyle.Brand;
            lblTitle.AutoSize = false;
            lblTitle.SetBounds(0, lblTitle.Top, pnlSidebar.ClientSize.Width, ResponsiveLayout.Pixels(this, 40));
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = AppStyle.Heading;
            lblScheduleTitle.Font = AppStyle.Heading;
            foreach (var label in new[] { label3, label5, label7, label9 }) label.Font = AppStyle.Section;
            foreach (var label in new[] { label2, label4, label6, label8 }) label.Font = AppStyle.Metric;

            foreach (var exam in SampleData.Exams)
                dgvSchedulePreview.Rows.Add(exam.Course, exam.Date.ToString("dd MMM yyyy"), $"{exam.Start} - {exam.End}", exam.Room);
            label2.Text = SampleData.Students().Rows.Count.ToString();
            label4.Text = SampleData.Exams.Select(exam => exam.Course).Distinct().Count().ToString();
            label6.Text = "0";
            label8.Text = SampleData.Exams.Select(exam => exam.Room).Distinct().Count().ToString();

            pnlSidebar.AutoScroll = true;
            var navigation = new[] { btnDashboard, btnTimetable, btnStudents, btnResources };
            int inset = ResponsiveLayout.Pixels(this, 12);
            int buttonHeight = ResponsiveLayout.Pixels(this, 44);
            int gap = ResponsiveLayout.Pixels(this, 8);
            int top = lblTitle.Bottom + ResponsiveLayout.Pixels(this, 24);
            for (int i = 0; i < navigation.Length; i++)
            {
                var button = navigation[i];
                button.SetBounds(inset, top + i * (buttonHeight + gap), pnlSidebar.ClientSize.Width - inset * 2, buttonHeight);
                button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                button.Padding = new Padding(inset, 0, 0, 0);
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.TabIndex = i;
            }
            var logout = new Button
            {
                Name = "btnLogout", Text = "Log out", Font = AppStyle.Navigation,
                ForeColor = Color.White, BackColor = pnlSidebar.BackColor,
                FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand,
                Height = buttonHeight, Width = pnlSidebar.ClientSize.Width - inset * 2,
                Padding = new Padding(inset, 0, 0, 0), TextAlign = ContentAlignment.MiddleLeft,
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom, TabIndex = navigation.Length
            };
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            pnlSidebar.Controls.Add(logout);
            void PlaceLogout() => logout.Location = new Point(inset,
                Math.Max(navigation[^1].Bottom + gap, pnlSidebar.ClientSize.Height - logout.Height - inset));
            pnlSidebar.Resize += (_, _) => PlaceLogout();
            PlaceLogout();
            logout.Click += (_, _) => { LogoutRequested = true; Close(); };
            btnGenerateSchedule.Dispose();
            dashboard = ResponsiveLayout.Dashboard(this, pnlContent, label1, SummaryChart.Subjects(),
                new[] { pnlStudentsCard, pnlCoursesCard, pnlConflictsCard, pnlHallsCard },
                pnlSchedulePreview, btnViewSchedule, dgvSchedulePreview);
            // Connect the buttons to their click events
            btnStudents.Click += btnStudents_Click;
            btnTimetable.Click += btnTimetable_Click;
            btnResources.Click += btnResources_Click;
            btnViewSchedule.Click += btnTimetable_Click;

            // Select Dashboard when the program starts
            SetActiveButton(btnDashboard);
        }

        // Change the color of the selected button
        private void SetActiveButton(Button selectedButton)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnStudents,
                btnTimetable,
                btnResources
            };

            Color normalColor = Color.FromArgb(10, 18, 35);
            Color selectedColor = Color.FromArgb(45, 55, 80);
            Color hoverColor = Color.FromArgb(30, 41, 59);

            // Go through all the sidebar buttons
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.White;
                btn.Font = btn == selectedButton ? AppStyle.NavigationSelected : AppStyle.Navigation;

                // Give the selected button a different color
                if (btn == selectedButton)
                {
                    btn.BackColor = selectedColor;
                    btn.FlatAppearance.MouseOverBackColor = selectedColor;
                }
                else
                {
                    btn.BackColor = normalColor;
                    btn.FlatAppearance.MouseOverBackColor = hoverColor;
                }
            }
        }

        private void OpenPage(Func<Form> createPage, Button button)
        {
            pnlContent.SuspendLayout();
            try
            {
                if (!pages.TryGetValue(button, out var form))
                {
                    form = createPage();
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    pnlContent.Controls.Add(form);
                    pages.Add(button, form);
                }

                var previous = activeForm;
                form.Show();
                form.BringToFront();
                dashboard.Hide();
                if (previous != form) previous?.Hide();
                activeForm = form;
                SetActiveButton(button);
            }
            finally
            {
                pnlContent.ResumeLayout(true);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activeForm?.Hide();
            activeForm = null;
            dashboard.Show();
            dashboard.BringToFront();
            SetActiveButton(btnDashboard);
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenPage(() => new Student_information(), btnStudents);
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            OpenPage(() => new TimetableForm(), btnTimetable);
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            OpenPage(() => new Resource_Form.ResourcesForm(), btnResources);
        }
    }
}
