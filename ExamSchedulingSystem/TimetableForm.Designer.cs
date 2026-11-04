namespace ExamSchedulingSystem
{
    partial class TimetableForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.colCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlHeader  (top: title + Generate button)
            //
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnGenerate);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(952, 70);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Timetable";
            //
            // btnGenerate  (Anchor Right = stays on the right edge)
            //
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(782, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(170, 40);
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            //
            // pnlGridCard  (middle card that holds the table)
            //
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlGridCard.Controls.Add(this.dgvTimetable);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(16);
            //
            // dgvTimetable
            //
            this.dgvTimetable.AllowUserToAddRows = false;
            this.dgvTimetable.AllowUserToResizeRows = false;
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.BackgroundColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTimetable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.dgvTimetable.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvTimetable.ColumnHeadersHeight = 36;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourse, this.colDate, this.colStart, this.colEnd, this.colRoom, this.colStudents});
            cellStyle.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            cellStyle.ForeColor = System.Drawing.Color.White;
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            cellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTimetable.DefaultCellStyle = cellStyle;
            this.dgvTimetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimetable.EnableHeadersVisualStyles = false;
            this.dgvTimetable.GridColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvTimetable.MultiSelect = false;
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RowHeadersVisible = false;
            this.dgvTimetable.RowTemplate.Height = 34;
            this.dgvTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimetable.SelectionChanged += new System.EventHandler(this.dgvTimetable_SelectionChanged);
            //
            // columns
            //
            this.colCourse.HeaderText = "Course";
            this.colCourse.Name = "colCourse";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colStart.HeaderText = "Start";
            this.colStart.Name = "colStart";
            this.colEnd.HeaderText = "End";
            this.colEnd.Name = "colEnd";
            this.colRoom.HeaderText = "Room";
            this.colRoom.Name = "colRoom";
            this.colStudents.HeaderText = "Students";
            this.colStudents.Name = "colStudents";
            //
            // pnlSpacer  (small gap between the table and the edit card)
            //
            this.pnlSpacer.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(952, 12);
            //
            // pnlEdit  (bottom card: change room / slot)
            //
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlEdit.Controls.Add(this.lblRoom);
            this.pnlEdit.Controls.Add(this.cmbRoom);
            this.pnlEdit.Controls.Add(this.lblDate);
            this.pnlEdit.Controls.Add(this.dtpDate);
            this.pnlEdit.Controls.Add(this.lblStart);
            this.pnlEdit.Controls.Add(this.dtpStart);
            this.pnlEdit.Controls.Add(this.lblEnd);
            this.pnlEdit.Controls.Add(this.dtpEnd);
            this.pnlEdit.Controls.Add(this.btnApply);
            this.pnlEdit.Controls.Add(this.lblStatus);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(952, 130);
            //
            // captions (small grey labels above the inputs)
            //
            this.lblRoom.AutoSize = true;
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblRoom.Location = new System.Drawing.Point(16, 12);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Text = "Room";
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblDate.Location = new System.Drawing.Point(222, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Date";
            this.lblStart.AutoSize = true;
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblStart.Location = new System.Drawing.Point(378, 12);
            this.lblStart.Name = "lblStart";
            this.lblStart.Text = "Start";
            this.lblEnd.AutoSize = true;
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblEnd.Location = new System.Drawing.Point(484, 12);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Text = "End";
            //
            // cmbRoom
            //
            this.cmbRoom.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoom.ForeColor = System.Drawing.Color.White;
            this.cmbRoom.Location = new System.Drawing.Point(16, 38);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(190, 25);
            //
            // dtpDate
            //
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(222, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(140, 25);
            //
            // dtpStart
            //
            this.dtpStart.CustomFormat = "HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(378, 38);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(90, 25);
            //
            // dtpEnd
            //
            this.dtpEnd.CustomFormat = "HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(484, 38);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(90, 25);
            //
            // btnApply
            //
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(600, 36);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 34);
            this.btnApply.Text = "Apply Change";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            //
            // lblStatus  (message line)
            //
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblStatus.Location = new System.Drawing.Point(16, 84);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(920, 38);
            this.lblStatus.Text = "Select an exam to change its room or slot.";
            //
            // TimetableForm
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.pnlGridCard);
            this.Controls.Add(this.pnlSpacer);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TimetableForm";
            this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.Text = "Timetable";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudents;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblStatus;
    }
}
