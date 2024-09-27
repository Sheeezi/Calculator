using CalculatorLib;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private CalculatorService? calculatorLibrary;

        private List<string> ResultsList = new();
        private string results = string.Empty;

        private FileOperationService fileOperationService;

        public FormCalculator()
        {
            InitializeComponent();
            CenterCalc();
            calculatorLibrary = new CalculatorService();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
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
            if (fileOperationService == null)
                fileOperationService = new FileOperationService();

            var calculateResult = calculatorLibrary?.GetNumberString;
            fileOperationService.SaveResult(calculateResult!);

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
