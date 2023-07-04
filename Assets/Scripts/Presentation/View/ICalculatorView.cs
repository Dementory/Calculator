using System.Collections.Generic;
using Calculator.Data;

namespace Calculator.Presentation
{

    public interface ICalculatorView
    {
        public string GetExpression();

        public void SetExpression(string expression);

        public void SetHistoryText(List<ExpressionModel> history);
    }
}
