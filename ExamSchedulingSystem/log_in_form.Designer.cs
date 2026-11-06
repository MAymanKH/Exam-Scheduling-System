namespace ExamSchedulingSystem
{
    partial class log_in_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new BorderlessButton();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 132);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 30);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 231);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 30);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(79, 70, 229);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(300, 305);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(178, 33);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 92);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 3;
            label1.Text = "User name / ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(235, 196);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(79, 70, 229);
            linkLabel1.Location = new Point(435, 196);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(150, 23);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password?";
            // 
            // log_in_form
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1150, 724);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "log_in_form";
            Text = "log_in_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}