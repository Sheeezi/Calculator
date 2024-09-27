using System.IO;
using System;

namespace CalculatorLib
{
    public class CalculatorLibrary
    {
        private string? numberString1, numberString2, matOperator;
        private double? numberDouble1, numberDouble2;

        public string SetNumberValue(string vaule)
        {
            if (matOperator is null or "")
            {
                numberString1 += vaule;
                return numberString1;
            }
            else
            {
                numberString2 += vaule;
                return numberString2;
            }
        }

        public string SetOperatorSign(string value)
        {
            var result = string.Empty;

            if (numberString2 is null or "")
            {
                matOperator = value;
                return numberString1!;
            }
            else
            {
                result = MakeCalculation();
                matOperator = value;
                return result;
            }
        }

        public string MakeCalculation()
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
            numberString2 = string.Empty;
            //matOperator = string.Empty;
            return numberString1!;
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
            if (numberString1 is not null or "")
                numberDouble1 = Convert.ToDouble(numberString1);

            if (numberString2 is null or "")
                return;
            
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

        public void SaveResult()
        {
            var line = string.Empty;
            var fileName = string.Empty;

            line = $"{numberString1}\n";
            fileName = "SavedResults.txt";

            File.AppendAllText(fileName, line);
        }
    }
}
