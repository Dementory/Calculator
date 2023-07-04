using Calculator.Data;
using Calculator.Domain;

namespace Calculator.Presentation
{

    public class CalculatorPresenter
    {
        private ICalculatorView _view;
        private ICalculatorRepository _calculatorRepository;
        private ExpressionParser _expressionParser;

        public CalculatorPresenter(ICalculatorView view)
        {
            _view = view;
            _calculatorRepository = new CalculatorRepository();
            _expressionParser = new AdditionExpressionParser();

            UpdateView();
        }

        private void UpdateView()
        {
            _view.SetExpression(_calculatorRepository.GetActiveExpression());
            _view.SetHistoryText(_calculatorRepository.GetHistory());
        }

        public void CalculateResult()
        {
            string expression = _view.GetExpression();
            ExpressionModel calculationResult = _expressionParser.EvaluateExpression(expression);

            _calculatorRepository.AddHistory(calculationResult);
            _calculatorRepository.SetActiveExpression("");

            UpdateView();
        }

        public void SaveCurrentExpression()
        {
            _calculatorRepository.SetActiveExpression(_view.GetExpression());
        }
    }
}
