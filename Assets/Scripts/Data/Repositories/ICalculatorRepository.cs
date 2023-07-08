using System.Collections.Generic;

namespace Calculator.Data
{

    public interface ICalculatorRepository
    {
        public void LoadData();

        public List<ExpressionModel> GetHistory();

        public void AddHistory(ExpressionModel history);

        public string GetActiveExpression();

        public void SetActiveExpression(string expression);
    }

}