using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;
using System.Collections.Generic;
using Calculator.Data;

namespace Calculator.Presentation
{

    public class CalculatorView : MonoBehaviour, ICalculatorView
    {
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private TMP_Text _historyText;
        [SerializeField] private Button _resultButton;

        private CalculatorPresenter _calculatorPresenter;

        private const string ERROR_MESSAGE = "ERROR";

        private void Start()
        {
            _calculatorPresenter = new CalculatorPresenter(this);

            _resultButton.onClick.AddListener(() => _calculatorPresenter.CalculateResult());
            _inputField.onValueChanged.AddListener(text => _calculatorPresenter.SaveCurrentExpression());
        }

        public string GetExpression()
        {
            return _inputField.text;
        }

        public void SetExpression(string expression)
        {
            _inputField.text = expression;
        }

        public void SetHistoryText(List<ExpressionModel> history)
        {
            StringBuilder historyText = new StringBuilder();

            foreach (ExpressionModel historyExpression in history)
            {
                string result = historyExpression.Success ? historyExpression.Result.ToString() : ERROR_MESSAGE;
                string expression = $"{historyExpression.Expression}={result}\n";

                historyText.Append(expression);
            }

            _historyText.text = historyText.ToString();
        }
    }

}