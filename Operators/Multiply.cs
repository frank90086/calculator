namespace calculator;

public class Multiply : IOperator
{
    public OperatorType Type { get; set; } = OperatorType.Multiply;
    public decimal Calculate(decimal a, decimal b) => a * b;
}