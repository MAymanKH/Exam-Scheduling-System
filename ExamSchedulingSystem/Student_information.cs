using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class Student_information : Form
    {
        public Student_information()
        {
            InitializeComponent();
            AppStyle.Apply(this);
            lblDataTitle.Font = AppStyle.Heading;
            button1.Width = 190;
            ResponsiveLayout.Import(this, label1, textBox1, button1, pnlData, SummaryChart.Enrollment());
            dataGridView1.DataSource = SampleData.Students();
        }

        private void button1_Click_1(object? sender, EventArgs e)
        {
            dataGridView1.DataSource = SampleData.Students();
        }
    }
}
