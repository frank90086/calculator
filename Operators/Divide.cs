namespace calculator;

public class Divide : IOperator
{
    public OperatorType Type { get; set; } = OperatorType.Divide;
    public decimal Calculate(decimal a, decimal b)
    {
        if (b is 0)
            throw new ArgumentException();

        return a / b;
    }
}