namespace ExamSchedulingSystem
{
    partial class Student_information
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            pnlData = new Panel();
            lblDataTitle = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlData.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(475, 27);
            textBox1.ReadOnly = true;
            textBox1.Text = "Sample data";
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(79, 70, 229);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(585, 131);
            button1.Name = "button1";
            button1.Size = new Size(247, 52);
            button1.TabIndex = 1;
            button1.Text = "Import students";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.GridColor = Color.DarkOliveGreen;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BackgroundColor = Color.FromArgb(17, 24, 39);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(933, 279);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 98);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 3;
            label1.Text = "Data source";
            // 
            //
            // pnlData
            //
            pnlData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlData.BackColor = Color.FromArgb(30, 41, 59);
            pnlData.Controls.Add(dataGridView1);
            pnlData.Controls.Add(lblDataTitle);
            pnlData.Location = new Point(19, 210);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(969, 394);
            pnlData.TabIndex = 4;
            //
            // lblDataTitle
            //
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 20F);
            lblDataTitle.ForeColor = Color.White;
            lblDataTitle.Location = new Point(15, 21);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.Text = "Students";
            lblDataTitle.TabIndex = 0;
            // Student_information
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1007, 630);
            Controls.Add(label1);
            Controls.Add(pnlData);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Student_information";
            Text = "Student_information";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel pnlData;
        private Label lblDataTitle;
        private Label label1;
    }
}