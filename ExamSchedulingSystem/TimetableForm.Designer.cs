namespace ExamSchedulingSystem
{
    partial class TimetableForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel { Size = new Size(952, 70) };
            lblTitle = new Label();
            btnGenerate = new Button();
            pnlGridCard = new Panel();
            dgvTimetable = new DataGridView();
            colCourse = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colStart = new DataGridViewTextBoxColumn();
            colEnd = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colStudents = new DataGridViewTextBoxColumn();
            pnlSpacer = new Panel();
            SuspendLayout();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnGenerate);
            lblTitle.AutoSize = true;
            lblTitle.Name = "lblTitle";
            lblTitle.Location = new Point(0, 14);
            lblTitle.Text = "Timetable";
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Text = "Generate";
            btnGenerate.BackColor = Color.FromArgb(79, 70, 229);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Size = new Size(170, 40);
            btnGenerate.Location = new Point(782, 12);
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.Click += btnGenerate_Click;

            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Padding = new Padding(16);
            pnlGridCard.BackColor = Color.FromArgb(30, 41, 59);
            pnlGridCard.Controls.Add(dgvTimetable);
            dgvTimetable.Name = "dgvTimetable";
            dgvTimetable.Dock = DockStyle.Fill;
            dgvTimetable.AllowUserToAddRows = false;
            dgvTimetable.AllowUserToResizeRows = false;
            dgvTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimetable.ReadOnly = true;
            dgvTimetable.RowHeadersVisible = false;
            dgvTimetable.MultiSelect = false;
            dgvTimetable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colCourse.HeaderText = "Course";
            colDate.HeaderText = "Date";
            colStart.HeaderText = "Start";
            colEnd.HeaderText = "End";
            colRoom.HeaderText = "Room";
            colStudents.HeaderText = "Students";
            dgvTimetable.Columns.AddRange(colCourse, colDate, colStart, colEnd, colRoom, colStudents);
            pnlSpacer.Dock = DockStyle.Top;
            pnlSpacer.Height = 12;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(17, 24, 39);
            ForeColor = Color.White;
            ClientSize = new Size(1000, 640);
            Padding = new Padding(24, 16, 24, 16);
            Font = AppStyle.Body;
            Controls.Add(pnlGridCard);
            Controls.Add(pnlSpacer);
            Controls.Add(pnlHeader);
            Name = "TimetableForm";
            Text = "Timetable";
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnGenerate;
        private Panel pnlGridCard;
        private DataGridView dgvTimetable;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colStart;
        private DataGridViewTextBoxColumn colEnd;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colStudents;
        private Panel pnlSpacer;
    }
}
