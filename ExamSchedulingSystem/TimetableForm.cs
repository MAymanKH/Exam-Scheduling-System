using System.Drawing;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    // The design (colors, positions, controls) is in TimetableForm.Designer.cs.
    // Open this form in the Visual Studio Designer to edit it with the mouse.
    // This file is only for the CODE.
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
            AppStyle.Apply(this);
            lblTitle.Font = AppStyle.Heading;

            ResponsiveLayout.Timetable(this, pnlEdit, lblStatus, btnApply,
                (lblRoom, cmbRoom), (lblDate, dtpDate), (lblStart, dtpStart), (lblEnd, dtpEnd));
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

        // Click on "Apply Change" -> the logic will be added here later.
        private void btnApply_Click(object sender, System.EventArgs e)
        {
            // TODO
        }

        // Selected row changed in the table -> logic later.
        private void dgvTimetable_SelectionChanged(object sender, System.EventArgs e)
        {
            // TODO
        }

        // Shows a message under the editors.
        // Example: SetStatus("Saved", Color.LimeGreen);
        public void SetStatus(string text, Color color)
        {
            lblStatus.ForeColor = color;
            lblStatus.Text = text;
        }
    }
}
