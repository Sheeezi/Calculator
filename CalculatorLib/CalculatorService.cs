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

            if (matOperator is null || matOperator != string.Empty)
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

            if (numberString2 is null or "")
            {
                matOperator = value;
                result = numberString1!;
            }
            else
            {
                matOperator = value;
                result = MakeCalculation();
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
            //TODO: poprawic
            if (numberString1 is not null or "")
                numberDouble1 = Convert.ToDouble(numberString1);

            //TODO: poprawic
            if (numberString2 is null or "")
                return;

            //TODO: poprawic
            if (numberString2 is not null or "")
                numberDouble2 = Convert.ToDouble(numberString2);

            //if (numberString1 is null or "")
            //{
            //    numberString2 = numberDouble2.ToString();
            //    return;
            //}

            //if (numberString2 is not null or "")
            //{
            //    numberDouble2 = Convert.ToDouble(numberString2);
            //}      
        }


    }
}
