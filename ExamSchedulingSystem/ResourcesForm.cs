
using System.IO;
using ExcelDataReader;
using System.Data;
using System;
using System.Windows.Forms;

namespace Resource_Form
{
    public partial class ResourcesForm : Form
    {
        public ResourcesForm()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;

                    try
                    {
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });

                                dataGridView1.DataSource = result.Tables[0];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" √ﬂœ „‰ ≈€·«ﬁ „·› «·≈ﬂ”Ì· ≈–« ﬂ«‰ „› ÊÕ« ›Ì »—‰«„Ã ¬Œ—.\n" + ex.Message,
                                        "Œÿ√ ›Ì «·› Õ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }


}
