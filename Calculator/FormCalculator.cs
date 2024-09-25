using System.Data;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        string numberString1, numberString2, matOperator;
        double numberDouble1, numberDouble2;
        
        List<string> ResultsList = new();
        string results = string.Empty;

        public FormCalculator()
        {
            InitializeComponent();
            panelCalulator.Location = new Point(this.ClientSize.Width / 2 - panelCalulator.Width / 2, this.ClientSize.Height / 2 - panelCalulator.Height / 2);
        }

        private void FormCalculator_CenterCalc(object sender, EventArgs e)
        {
            panelCalulator.Location = new Point(this.ClientSize.Width / 2 - panelCalulator.Width / 2, this.ClientSize.Height / 2 - panelCalulator.Height / 2);
        }

        private void SetNumberValue(string vaule)
        {
            if (matOperator == null || matOperator == "")
            {
                numberString1 += vaule;
                labelNumberDisplayer.Text = numberString1;
            }
            else
            {
                numberString2 += vaule;
                labelNumberDisplayer.Text = numberString2;
            }
        }

        private void MakeCalculation()
        {
            if (numberString1 == "" || numberString1 == null)
                return;

            NumbersCoversion();

            switch (matOperator)
            {
                case "+":
                    numberString1 = (numberDouble1 + numberDouble2).ToString();
                    break;

                case "-":
                    numberString1 = (numberDouble1 - numberDouble2).ToString();
                    break;

                case "*":
                    numberString1 = (numberDouble1 * numberDouble2).ToString();
                    break;

                case "/":
                    numberString1 = (numberDouble1 / numberDouble2).ToString();
                    break;

                case "%":
                    numberString1 = ((numberDouble1 / 100) * numberDouble2).ToString();
                    break;

                default:
                    break;
            }
            numberString2 = "";
            matOperator = string.Empty;
            labelNumberDisplayer.Text = numberString1;
        }

        private void SetOperatorSign(string value)
        {
            if (numberString2 == null || numberString2 == "")
            {
                matOperator = value;
            }
            else
            {
                MakeCalculation();
                matOperator = value;
            }
        }

        private void NumbersCoversion()
        {
            numberDouble1 = Convert.ToDouble(numberString1.ToString());
            if (numberString2 == "")
            {
                numberString2 += numberDouble2.ToString();
            }
            //MessageBox.Show(numberString2);
            numberDouble2 = Convert.ToDouble(numberString2.ToString());
        }

        private void SaveResult()
        {
            ResultsList.Add(numberString1);
            DisplayResults();
        }

        private void DisplayResults()
        {


            foreach (string result in ResultsList)
            {
                results += $"{result}, ";
            }

            MessageBox.Show(results);
            results = string.Empty;
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetNumberValue(button.Text);
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (numberString1 == "" || numberString1 == null)
                return;

            Button button = (Button)sender;
            SetOperatorSign(button.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numberDouble1 = 0;
            numberDouble2 = 0;
            numberString1 = "";
            numberString2 = "";
            matOperator = "";
            labelNumberDisplayer.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            MakeCalculation();
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            SaveResult();
        }
    }
}
