using UnityEngine;

namespace Calculator.Data
{

    public class ActiveExpressionRepository : IActiveExpressionRepository
    {
        private string _activeExpression;
        private const string ACTIVE_EXPRESSION_DATA_KEY = "CurrentExpression";

        public ActiveExpressionRepository()
        {
            _activeExpression = LoadActiveExpression();
        }

        public string GetActiveExpression()
        {
            return _activeExpression;
        }

        public void SetActiveExpression(string expression)
        {
            _activeExpression = expression;
            SaveActiveExpression();
        }

        private void SaveActiveExpression()
        {
            PlayerPrefs.SetString(ACTIVE_EXPRESSION_DATA_KEY, _activeExpression);
            PlayerPrefs.Save();
        }

        private string LoadActiveExpression()
        {
            return PlayerPrefs.GetString(ACTIVE_EXPRESSION_DATA_KEY, "");
        }
    }
}
