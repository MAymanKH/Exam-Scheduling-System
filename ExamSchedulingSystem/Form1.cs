
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class frmMain : Form
    {
        private Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();
            AppStyle.Apply(this);
            lblTitle.Font = AppStyle.Section;
            label1.Font = AppStyle.Heading;
            lblScheduleTitle.Font = AppStyle.Heading;
            foreach (var label in new[] { label3, label5, label7, label9 }) label.Font = AppStyle.Section;
            foreach (var label in new[] { label2, label4, label6, label8 }) label.Font = AppStyle.Metric;

            // Connect the buttons to their click events
            btnStudents.Click += btnStudents_Click;
            btnTimetable.Click += btnTimetable_Click;
            btnResources.Click += btnResources_Click;

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

        // Open a form inside the main content panel
        private void OpenPage(Form form, Button button)
        {
            // Close the previously opened form
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            // Make the new form fit inside the dashboard panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Show the form on top of the dashboard
            pnlContent.Controls.Add(form);
            form.Show();
            form.BringToFront();

            activeForm = form;

            // Change the selected button color
            SetActiveButton(button);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Close the currently opened form
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            // The dashboard controls are now visible again
            SetActiveButton(btnDashboard);
        }


        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenPage(new Student_information(), btnStudents);
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            OpenPage(new TimetableForm(), btnTimetable);
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            OpenPage(new Resource_Form.ResourcesForm(), btnResources);
        }
    }
}
