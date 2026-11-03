using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class AddExamForm : Form
    {

        public DateTime ExamDate { get; private set; }
        public DateTime StartTime { get; private set; }
        public string SelectedRoom { get; private set; }

        public AddExamForm()
        {
            InitializeComponent();

            btnSaveExam.FlatAppearance.BorderSize = 0;
            btnSaveExam.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(59, 130, 246);

            cmbRoom.Items.Add("Room 101");
            cmbRoom.Items.Add("Room 102");
            cmbRoom.Items.Add("Room 103");
            cmbRoom.Items.Add("Lab 201");
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room");
                return;
            }

            if (dtpExamDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Exam date cannot be in the past");
                return;
            }

            ExamDate = dtpExamDate.Value.Date;
            StartTime = dtpStartTime.Value;
            SelectedRoom = cmbRoom.SelectedItem.ToString();

            MessageBox.Show("Exam details saved successfully");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddExamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
