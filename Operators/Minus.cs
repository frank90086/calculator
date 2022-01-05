namespace calculator;

public class Minus : IOperator
{
    public OperatorType Type { get; set; } = OperatorType.Minus;
    public decimal Calculate(decimal a, decimal b) => a - b;
}