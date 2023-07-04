using System.Text.RegularExpressions;
using Calculator.Data;

namespace Calculator.Domain
{

    public class AdditionExpressionParser : ExpressionParser
    {
        public override ExpressionModel EvaluateExpression(string expression)
        {
            bool isValidInput = Regex.IsMatch(expression, @"^[0-9+]+$");
            float result = 0;

            if (isValidInput)
            {
                string[] expressionParts = expression.Split('+');
                result = PerformAddition(expressionParts);
            }

            return new ExpressionModel(expression, result, isValidInput);
        }

        private float PerformAddition(string[] numbers)
        {
            float sum = 0;
            foreach (string number in numbers)
            {
                float parsedNumber = float.Parse(number);
                sum += parsedNumber;
            }

            return sum;
        }
    }
}
