using System;
using System.Windows.Forms;

namespace ExamSchedulingSystem
{
    public partial class log_in_form : Form
    {
        public log_in_form()
        {
            InitializeComponent();
            AppStyle.Apply(this);
            Text = "Exam Scheduler";
            StartPosition = FormStartPosition.CenterScreen;
            var title = new Label
            {
                Name = "lblLoginTitle",
                Text = "Exam Scheduler",
                Font = AppStyle.Heading,
                ForeColor = System.Drawing.Color.White,
                AutoSize = true
            };
            var card = ResponsiveLayout.Fields(this, title, label1, textBox1, label2, textBox2, linkLabel1, button1);
            card.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            card.Padding = new Padding(24);
            title.Margin = new Padding(0, 0, 0, 24);
            linkLabel1.Text = "Forgot password?";
            linkLabel1.Anchor = AnchorStyles.Right;
            button1.Margin = Padding.Empty;
            textBox1.TabIndex = 0;
            textBox2.TabIndex = 1;
            linkLabel1.TabIndex = 2;
            button1.TabIndex = 3;
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
