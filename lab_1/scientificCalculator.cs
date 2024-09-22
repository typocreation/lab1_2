using System;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // When user clicks a number button, the value will be added to the input TextBox
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            inputTextBox.Text += btn.Text;
        }

        // Clear the input TextBox
        private void Clear_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }

        // Calculate sine of input
        private void Sine_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(inputTextBox.Text);
            double result = Math.Sin(value);
            resultTextBox.Text = result.ToString();
        }

        // Calculate cosine of input
        private void Cosine_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(inputTextBox.Text);
            double result = Math.Cos(value);
            resultTextBox.Text = result.ToString();
        }

        // Calculate tangent of input
        private void Tangent_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(inputTextBox.Text);
            double result = Math.Tan(value);
            resultTextBox.Text = result.ToString();
        }

        // Calculate logarithm of input
        private void Log_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(inputTextBox.Text);
            double result = Math.Log(value);
            resultTextBox.Text = result.ToString();
        }
    }
}
