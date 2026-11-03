namespace Calc_You_Later;

public class Calculator
{
    public float Add(float num1, float num2) => num1 + num2;
    public float Subtract(float num1, float num2) => num1 - num2;
    public float Multiply(float num1, float num2) => num1 * num2;

    public float Divide(float num1, float num2)
    {
        if (num1 == 0 || num2 == 0)
        {
            Console.WriteLine("Dividing by zero is illegal, the police are on their way");
            return 0;
        }
        return num1 / num2;
    }

}