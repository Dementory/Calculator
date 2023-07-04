using System.Collections.Generic;
using System.Linq;

namespace Calculator.Data
{

    public class CalculatorRepository : ICalculatorRepository
    {
        private IHistoryRepository _historyRepository;
        private IActiveExpressionRepository _activeExpressionRepository;

        public CalculatorRepository()
        {
            _historyRepository = new HistoryRepository();
            _activeExpressionRepository = new ActiveExpressionRepository();
        }

        public List<ExpressionModel> GetHistory()
        {
            return _historyRepository.GetHistory().ToList();
        }

        public void AddHistory(ExpressionModel history)
        {
            _historyRepository.AddHistory(history);
        }

        public string GetActiveExpression()
        {
            return _activeExpressionRepository.GetActiveExpression();
        }

        public void SetActiveExpression(string expression)
        {
            _activeExpressionRepository.SetActiveExpression(expression);
        }
    }
}
