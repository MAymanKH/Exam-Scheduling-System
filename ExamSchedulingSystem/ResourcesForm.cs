namespace Resource_Form
{
    public partial class ResourcesForm : Form
    {
        public ResourcesForm()
        {
            InitializeComponent();

            // Setup Rooms Table
            dgvRooms.Columns.Add("RoomName", "Room Name");
            dgvRooms.Columns.Add("Capacity", "Capacity");

            // Setup Time Slots Table
            dgvSlots.Columns.Add("Date", "Date");
            dgvSlots.Columns.Add("StartTime", "Start Time");
            dgvSlots.Columns.Add("EndTime", "End Time");

            // Setup Unavailability Table
            dgvUnavailable.Columns.Add("Room", "Room");
            dgvUnavailable.Columns.Add("Date", "Date");
            dgvUnavailable.Columns.Add("Slot", "Slot");

            // Time Format
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.ShowUpDown = true;

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.ShowUpDown = true;

            // Default Time
            dtpStartTime.Value = DateTime.Today.AddHours(9);
            dtpEndTime.Value = DateTime.Today.AddHours(11);

            // Events
            btnAddRoom.Click += btnAddRoom_Click;
            btnRemoveRoom.Click += btnRemoveRoom_Click;

            btnAddSlot.Click += btnAddSlot_Click;
            btnRemoveSlot.Click += btnRemoveSlot_Click;

            btnMarkUnavailable.Click += btnMarkUnavailable_Click;
            btnRestoreAvailability.Click += btnRestoreAvailability_Click;

            cmbDates.SelectedIndexChanged += cmbDates_SelectedIndexChanged;
        }

        // =========================
        // ROOMS
        // =========================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty for now
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "" || txtCapacity.Text == "")
            {
                MessageBox.Show("Enter Room Name and Capacity");
                return;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Enter a valid capacity");
                return;
            }

            dgvRooms.Rows.Add(txtRoomName.Text, capacity);

            cmbRooms.Items.Add(txtRoomName.Text);

            txtRoomName.Clear();
            txtCapacity.Clear();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                string roomName =
                    dgvRooms.SelectedRows[0].Cells[0].Value.ToString();

                dgvRooms.Rows.Remove(dgvRooms.SelectedRows[0]);

                cmbRooms.Items.Remove(roomName);
            }
            else
            {
                MessageBox.Show("Select a room first");
            }
        }

        // =========================
        // TIME SLOTS
        // =========================

        private void btnAddSlot_Click(object sender, EventArgs e)
        {
            DateTime date = dtpExamDate.Value.Date;

            string start = dtpStartTime.Value.ToString("hh:mm tt");
            string end = dtpEndTime.Value.ToString("hh:mm tt");

            dgvSlots.Rows.Add(date.ToShortDateString(), start, end);

            if (!cmbDates.Items.Contains(date.ToShortDateString()))
            {
                cmbDates.Items.Add(date.ToShortDateString());
            }
        }

        private void btnRemoveSlot_Click(object sender, EventArgs e)
        {
            if (dgvSlots.SelectedRows.Count > 0)
            {
                dgvSlots.Rows.Remove(dgvSlots.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Select a slot first");
            }
        }

        // =========================
        // ROOM UNAVAILABILITY
        // =========================

        private void cmbDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSlots.Items.Clear();

            string selectedDate = cmbDates.Text;

            foreach (DataGridViewRow row in dgvSlots.Rows)
            {
                if (row.Cells[0].Value.ToString() == selectedDate)
                {
                    string slot =
                        row.Cells[1].Value + " - " + row.Cells[2].Value;

                    cmbSlots.Items.Add(slot);
                }
            }
        }

        private void btnMarkUnavailable_Click(object sender, EventArgs e)
        {
            if (cmbRooms.Text == "" ||
                cmbDates.Text == "" ||
                cmbSlots.Text == "")
            {
                MessageBox.Show("Select Room, Date and Slot");
                return;
            }

            dgvUnavailable.Rows.Add(
                cmbRooms.Text,
                cmbDates.Text,
                cmbSlots.Text
            );
        }

        private void btnRestoreAvailability_Click(object sender, EventArgs e)
        {
            if (dgvUnavailable.SelectedRows.Count > 0)
            {
                dgvUnavailable.Rows.Remove(
                    dgvUnavailable.SelectedRows[0]
                );
            }
            else
            {
                MessageBox.Show("Select a record first");
            }
        }

        private void dgvUnavailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}