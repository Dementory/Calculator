namespace Calculator.Data
{

    public interface IActiveExpressionRepository
    {
        public string GetActiveExpression();

        public void SetActiveExpression(string expression);
    }
}
