using System.Data;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        string numberString1, numberString2, matOperator;
        double numberDouble1, numberDouble2;

        public FormCalculator()
        {
            InitializeComponent();
            panelCalulator.Location = new Point(this.ClientSize.Width / 2 - panelCalulator.Width / 2, this.ClientSize.Height / 2 - panelCalulator.Height / 2);
        }

        private void FormCalculator_ResizeEnd(object sender, EventArgs e)
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
        //private void buttonZero_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("0");
        //}
        //private void buttonOne_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("1");
        //}

        //private void buttonTwo_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("2");
        //}

        //private void buttonThree_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("3");
        //}

        //private void buttonFour_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("4");
        //}

        //private void buttonFive_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("5");
        //}

        //private void buttonSix_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("6");
        //}

        //private void buttonSeven_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("7");
        //}

        //private void buttonEight_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("8");
        //}

        //private void buttonNine_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue("9");
        //}

        //private void buttonComma_Click(object sender, EventArgs e)
        //{
        //    SetNumberValue(",");
        //}
        //private void buttonAdd_Click(object sender, EventArgs e)
        //{
        //    SetOperatorSign("+");
        //}

        //private void buttonSubtract_Click(object sender, EventArgs e)
        //{
        //    SetOperatorSign("-");
        //}

        //private void buttonTimes_Click(object sender, EventArgs e)
        //{
        //    SetOperatorSign("*");
        //}

        //private void buttonDivide_Click(object sender, EventArgs e)
        //{
        //    SetOperatorSign("/");
        //}

        //private void buttonPercent_Click(object sender, EventArgs e)
        //{
        //    SetOperatorSign("%");
        //}

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetNumberValue(button.Text);
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetOperatorSign(button.Text);
        }

        //private void buttonClearEnter_Click(object sender, EventArgs e)
        //{
        //    if (matOperator == null || matOperator == "")
        //    {
        //        numberString1 = "";
        //        labelNumberDisplayer.Text = "0";    
        //    }
        //    else
        //    {
        //        numberString2 = "";
        //        labelNumberDisplayer.Text = "0";
        //    }
        //}

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
    }
}
