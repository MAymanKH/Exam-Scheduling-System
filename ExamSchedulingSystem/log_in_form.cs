using System;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class log_in_form : Form
    {
        public log_in_form()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            AcceptButton = button1;
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
        private void textBox1_TextChanged(object sender, EventArgs e) {
        //Empty for now
        }

    }
}
