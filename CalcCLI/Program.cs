Console.WriteLine("Простой калькулятор");
Console.Write("x = ");
float x = float.Parse(Console.ReadLine() ?? "0.0f");
Console.Write("y = ");
float y = float.Parse(Console.ReadLine() ?? "0.0f");

Console.Write("op : ");
char op = (Console.ReadLine() ?? " ")[0];

float result = op switch
{
    '+' => x + y,
    '-' => x - y,
    '*' => x * y,
    _ => throw new Exception("Invalid op")
};
Console.WriteLine($"{x} {op} {y} = {result}");