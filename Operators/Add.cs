namespace calculator;

public class Add : IOperator
{
    public OperatorType Type { get; set; } = OperatorType.Add;
    public decimal Calculate(decimal a, decimal b) => a + b;
}