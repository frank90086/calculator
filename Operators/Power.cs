namespace calculator;

public class Power : IOperator
{
    public OperatorType Type { get; set; } = OperatorType.Power;

    public decimal Calculate(decimal a, decimal b) => (decimal)Math.Pow((double)a, (double)b);
}