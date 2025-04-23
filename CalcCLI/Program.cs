Console.WriteLine("Простой калькулятор");
Console.Write("x = ");
float x = float.Parse(Console.ReadLine() ?? "0.0f");
Console.Write("y = ");
float y = float.Parse(Console.ReadLine() ?? "0.0f");

Console.Write("op : ");
char op = (Console.ReadLine() ?? " ")[0];

var calc = new Calculator();
try
{
    float result = calc.Calculate(x, y, op);
    Console.WriteLine($"{x} {op} {y} = {result}");
}
catch (ArgumentException e)
{
    Console.WriteLine($"Ошибка: {e.Message}");
}
