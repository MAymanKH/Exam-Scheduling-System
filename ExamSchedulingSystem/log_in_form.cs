using System;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class log_in_form : Form
    {
        public log_in_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

        }
        private void textBox1_TextChanged(object sender, EventArgs e) {
        //Empty for now
        }

    }
}
