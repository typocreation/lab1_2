using System;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        // Insert values into the DataGridView at runtime
        private void InsertButton_Click(object sender, EventArgs e)
        {
            // Define some values to insert into the DataGridView
            string[] row1 = { "1", "John Doe", "30" };
            string[] row2 = { "2", "Jane Smith", "28" };
            string[] row3 = { "3", "Mark Johnson", "25" };

            // Add rows to the DataGridView
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
        }
    }
}
