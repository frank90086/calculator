namespace calculator;

public class Log : IOperator
{
    public OperatorType Type { get; set; } = OperatorType.Log;

    public decimal Calculate(decimal a, decimal b) => (decimal)Math.Log((double)a, (double) b);
}