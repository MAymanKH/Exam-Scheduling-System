namespace Resource_Form
{
    partial class ResourcesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            pnlData = new Panel();
            lblDataTitle = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlData.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Size = new Size(1052, 306);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(79, 70, 229);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(701, 164);
            button1.Name = "button1";
            button1.Size = new Size(242, 52);
            button1.TabIndex = 1;
            button1.Text = "Import resources";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 27);
            textBox1.ReadOnly = true;
            textBox1.Text = "Sample data";
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(54, 138);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
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
            pnlData.Location = new Point(19, 247);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(1088, 421);
            pnlData.TabIndex = 4;
            //
            // lblDataTitle
            //
            lblDataTitle.AutoSize = true;
            lblDataTitle.Font = new Font("Segoe UI", 20F);
            lblDataTitle.ForeColor = Color.White;
            lblDataTitle.Location = new Point(15, 21);
            lblDataTitle.Name = "lblDataTitle";
            lblDataTitle.Text = "Resources";
            lblDataTitle.TabIndex = 0;
            // ResourcesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1126, 695);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pnlData);
            Name = "ResourcesForm";
            Text = "Resources Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnlData;
        private Label lblDataTitle;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}