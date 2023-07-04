using System.Collections.Generic;

namespace Calculator.Data
{

    public interface IHistoryRepository
    {
        public IEnumerable<ExpressionModel> GetHistory();

        public void AddHistory(ExpressionModel history);
    }

}