namespace calculator;

public interface IOperator
{
    OperatorType Type { get; set; }
    decimal Calculate(decimal a, decimal b);
}