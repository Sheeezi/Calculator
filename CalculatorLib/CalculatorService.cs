namespace CalculatorLib
{
    public class CalculatorService
    {
        private string? numberString1, numberString2, matOperator;
        private double? numberDouble1, numberDouble2;

        public string? GetNumberString { get => numberString1; }

        public string SetNumberValue(string vaule)
        {
            var result = string.Empty;

            if (matOperator is null || matOperator == string.Empty)
            {
                numberString1 += vaule;
                result = numberString1;
            }
            else
            {
                numberString2 += vaule;
                result = numberString2;
            }

            return result;
        }

        public string SetOperatorSign(string value)
        {
            var result = string.Empty;

            if (numberString2 is null || numberString2 == string.Empty)
            {
                matOperator = value;
                result = numberString1!;
            }
            else
            {
                result = MakeCalculation();
                matOperator = value;
            }

            return result;

        }

        public string MakeCalculation()
        {
            var result = string.Empty;

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
            numberString2 = string.Empty;

            result = numberString1!;

            return result;
        }

        public string ClearCalculation()
        {
            numberDouble1 = 0;
            numberDouble2 = 0;
            numberString1 = string.Empty;
            numberString2 = string.Empty;
            matOperator = string.Empty;

            return "0";
        }

        public void NumbersCoversion()
        {
            if (numberString1 is null || numberString1 == string.Empty)
                return;

            if (numberString1 is not null || numberString1 != string.Empty)
                numberDouble1 = Convert.ToDouble(numberString1);

            if (numberString2 is null || matOperator == string.Empty)
                return;

            if (matOperator is not null || matOperator != string.Empty)
                numberDouble2 = Convert.ToDouble(numberString2);   
        }
    }
}
