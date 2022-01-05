using System.Reflection;

namespace calculator;

public class Calculator
{
    private IEnumerable<IOperator> operators;

    public Calculator()
    {
        operators = Assembly.GetExecutingAssembly()
                            .GetTypes()
                            .Where(t => typeof(IOperator).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                            .Select(s => Activator.CreateInstance(s) as IOperator);
    }

    public decimal Do(decimal a, decimal b, OperatorType type)
    {
        var op = operators.FirstOrDefault(f => f.Type == type);

        if (op == null) throw new ArgumentOutOfRangeException();

        return op.Calculate(a, b);
    }
}