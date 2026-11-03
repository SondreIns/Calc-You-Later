namespace Calc_You_Later;

public class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public float Add(float num1, float num2)
    {
        return num1 + num2;
    }

    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    public float Subtract(float num1, float num2)
    {
        return num1 - num2;
    }

    public int Divide(int num1, int num2)
    {
        if(num1 == 0 || num2 == 0) return 0;
        return num1 / num2;
    }

    public float Divide(float num1, float num2)
    {
        if (num1 == 0 || num2 == 0) return 0;
        return num1 / num2;
    }

    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public float Multiply(float num1, float num2)
    {
        return num1 * num2;
    }
}