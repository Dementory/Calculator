namespace Calculator.Data
{

    [System.Serializable]
    public class ExpressionModel
    {
        public float Result { get; set; }
        public bool Success { get; set; }
        public string Expression { get; set; }

        public ExpressionModel() { }

        public ExpressionModel(string expression, float result, bool success)
        {
            Result = result;
            Success = success;
            Expression = expression;
        }
    }
}
