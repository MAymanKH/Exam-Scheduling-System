using System.Data;
using System.Windows.Forms;

namespace Resource_Form
{
    public partial class ResourcesForm : Form
    {
        public ResourcesForm()
        {
            InitializeComponent();
            ExamSchedulingSystem.AppStyle.Apply(this);
            lblDataTitle.Font = ExamSchedulingSystem.AppStyle.Heading;
            button1.Width = 190;
            ExamSchedulingSystem.ResponsiveLayout.Import(this, label1, textBox1, button1, pnlData);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            var resources = new DataTable();
            resources.Columns.Add("Room");
            resources.Columns.Add("Capacity", typeof(int));
            resources.Columns.Add("Exam Date", typeof(DateTime));
            resources.Columns.Add("Start Time");
            resources.Columns.Add("End Time");
            resources.Columns.Add("Available", typeof(bool));
            resources.Rows.Add("Hall A", 120, new DateTime(2026, 12, 1), "09:00", "11:00", true);
            resources.Rows.Add("Hall B", 80, new DateTime(2026, 12, 1), "09:00", "11:00", true);
            resources.Rows.Add("Lab 1", 30, new DateTime(2026, 12, 1), "09:00", "11:00", false);
            resources.Rows.Add("Hall A", 120, new DateTime(2026, 12, 1), "11:30", "13:30", true);
            resources.Rows.Add("Hall B", 80, new DateTime(2026, 12, 1), "11:30", "13:30", false);
            resources.Rows.Add("Lab 1", 30, new DateTime(2026, 12, 1), "11:30", "13:30", true);
            dataGridView1.DataSource = resources;
        }
    }
}
