public class Calculator
{
    public float Calculate(float x, float y, char op)
    {
        return op switch
        {
            '+' => Add(x, y),
            '-' => Subtract(x, y),
            '*' => Multiply(x, y),
            '/' => Divide(x, y),
            _ => throw new ArgumentException("Invalid operator", nameof(op))
        };
    }

    public float Add(float a, float b) => a + b;

    public float Subtract(float a, float b) => a - b;

    public float Multiply(float a, float b) => a * b;
    public float Divide(float a, float b) => a / b;
}