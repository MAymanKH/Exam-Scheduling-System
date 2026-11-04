
using System;
using System.Windows.Forms;

namespace Resource_Form
{
    public partial class ResourcesForm : Form
    {
        public ResourcesForm()
        {
            InitializeComponent();

            // Rooms Table
            dgvRooms.Columns.Clear();
            dgvRooms.Columns.Add("RoomName", "Room Name");
            dgvRooms.Columns.Add("Capacity", "Capacity");

            // Time Slots Table
            dgvSlots.Columns.Clear();
            dgvSlots.Columns.Add("Date", "Date");
            dgvSlots.Columns.Add("StartTime", "Start Time");
            dgvSlots.Columns.Add("EndTime", "End Time");

            // Unavailability Table
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Room", "Room");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Slot", "Slot");

            // Time Format
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.ShowUpDown = true;

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.ShowUpDown = true;

            dtpStartTime.Value = DateTime.Today.AddHours(9);
            dtpEndTime.Value = DateTime.Today.AddHours(11);

            // Events
            btnAddRoom.Click += btnAddRoom_Click;
            btnRemoveRoom.Click += btnRemoveRoom_Click;

            btnAddSlot.Click += btnAddSlot_Click;
            btnRemoveSlot.Click += btnRemoveSlot_Click;

            button2.Click += btnMarkUnavailable_Click;
            button1.Click += btnRestoreAvailability_Click;

            comboBox2.SelectedIndexChanged +=
                cmbDates_SelectedIndexChanged;
        }

        // =========================
        // ROOMS
        // =========================

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "" || txtCapacity.Text == "")
            {
                MessageBox.Show("Enter Room Name and Capacity");
                return;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity)
                || capacity <= 0)
            {
                MessageBox.Show("Enter a valid capacity");
                return;
            }

            dgvRooms.Rows.Add(txtRoomName.Text, capacity);

            comboBox1.Items.Add(txtRoomName.Text);

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

                comboBox1.Items.Remove(roomName);
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

            if (dtpEndTime.Value.TimeOfDay <=
                dtpStartTime.Value.TimeOfDay)
            {
                MessageBox.Show("End time must be after start time");
                return;
            }

            dgvSlots.Rows.Add(
                date.ToString("dd/MM/yyyy"),
                start,
                end
            );

            string dateText = date.ToString("dd/MM/yyyy");

            if (!comboBox2.Items.Contains(dateText))
            {
                comboBox2.Items.Add(dateText);
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

        private void cmbDates_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            string selectedDate = comboBox2.Text;

            foreach (DataGridViewRow row in dgvSlots.Rows)
            {
                if (row.Cells[0].Value.ToString() == selectedDate)
                {
                    string slot =
                        row.Cells[1].Value + " - " + row.Cells[2].Value;

                    comboBox3.Items.Add(slot);
                }
            }
        }

        private void btnMarkUnavailable_Click(
            object sender, EventArgs e)
        {
            if (comboBox1.Text == "" ||
                comboBox2.Text == "" ||
                comboBox3.Text == "")
            {
                MessageBox.Show("Select Room, Date and Slot");
                return;
            }

            dataGridView1.Rows.Add(
                comboBox1.Text,
                comboBox2.Text,
                comboBox3.Text
            );
        }

        private void btnRestoreAvailability_Click(
            object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(
                    dataGridView1.SelectedRows[0]
                );
            }
            else
            {
                MessageBox.Show("Select a record first");
            }
        }
        private void dgvRooms_CellContentClick( object sender, DataGridViewCellEventArgs e)
        {
            //empty for now
        }
        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e)
        {
            //empty for now
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty for now
        }
    }


}
