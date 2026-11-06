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
            dataGridView1.DataSource = ExamSchedulingSystem.SampleData.Resources();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            dataGridView1.DataSource = ExamSchedulingSystem.SampleData.Resources();
        }
    }
}
