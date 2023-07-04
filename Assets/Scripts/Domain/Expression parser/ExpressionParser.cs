using Calculator.Data;

namespace Calculator.Domain
{

    public abstract class ExpressionParser
    {
        public abstract ExpressionModel EvaluateExpression(string expression);
    }

}