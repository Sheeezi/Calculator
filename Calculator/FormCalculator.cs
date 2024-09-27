using CalculatorLib;
using System.Data;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private CalculatorLibrary? calculatorLibrary;

        List<string> ResultsList = new();
        string results = string.Empty;

        public FormCalculator()
        {
            InitializeComponent();
            CenterCalc();
            calculatorLibrary = new CalculatorLibrary();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            labelNumberDisplayer.Text = calculatorLibrary?.SetNumberValue(button.Text);
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            labelNumberDisplayer.Text = calculatorLibrary?.SetOperatorSign(button.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumberDisplayer.Text = calculatorLibrary?.ClearCalculation();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            labelNumberDisplayer.Text = calculatorLibrary?.MakeCalculation();
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            calculatorLibrary?.SaveResult();
        }

        private void FormCalculator_CenterCalc(object sender, EventArgs e)
        {
            CenterCalc();
        }

        private void CenterCalc()
        {
            panelCalulator.Location = new Point(this.ClientSize.Width / 2 - panelCalulator.Width / 2, this.ClientSize.Height / 2 - panelCalulator.Height / 2);
        }
    }
}
