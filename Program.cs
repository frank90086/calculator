using calculator;

decimal a, b;
OperatorType opType;
var cal = new Calculator();

Console.WriteLine(">>> Please entry first number: ");
var first = Console.ReadLine();

while (!decimal.TryParse(first, out a))
{
    Console.WriteLine(">>> Please retry entry first number: ");
    first = Console.ReadLine();
}

Console.WriteLine(">>> Please entry second number: ");
var second = Console.ReadLine();

while (!decimal.TryParse(second, out b))
{
    Console.WriteLine(">>> Please retry entry second number: ");
    second = Console.ReadLine();
}

var opNames = string.Join('|', Enum.GetNames(typeof(OperatorType)));
Console.WriteLine($">>> Please entry operator ({opNames}): ");
var op = Console.ReadLine();

while (!Enum.TryParse<OperatorType>(op, true, out opType))
{
    Console.WriteLine($">>> Please retry entry operator ({opNames}): ");
    op = Console.ReadLine();
}

var result = cal.Do(a, b, opType);

Console.WriteLine($">>> Result: {result}");