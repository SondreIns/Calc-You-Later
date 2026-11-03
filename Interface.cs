namespace Calc_You_Later;

public static class Interface
{  
    private static float _num1;
    private static char _op = ' ';
    public static void Write(bool first)
    {
        string order = first == true ? "first" : "second";
        Console.Write("Input " + order + " number: ");
        string? input = Console.ReadLine();
        if(!Single.TryParse(input, out float num))
        {
            Console.Clear();
            Console.WriteLine("Error - input a valid number");
            Write(first);
        }
        if(first)
        {
            _num1 = num;
            Console.WriteLine();
            _op = GetOperator();
            Write(false);
        }

        else
        {
            float result = Operate(_num1, num);
            Console.WriteLine($"{_num1} {_op} {num} = {result}");
        }
    }

    private static char GetOperator()
    {
        Console.WriteLine(
        "1. Add\n" +
        "2. Subtract\n" +
        "3. Multiply\n" +
        "4. Divide");

        string? input = Console.ReadLine();
        if(!Int32.TryParse(input, out int result))
        {
            Console.WriteLine("Error - invalid operator");
            GetOperator();
        }
        switch(result)
        {
            case 1:
                return '+';
            case 2:
                return '-';
            case 3:
                return '*';
            case 4:
                return '/';
            default:
                Console.WriteLine("Error - invalid operator");
                GetOperator();
                break;
        }
        return '?';
    }

    private static float Operate(float num1, float num2)
    {
        switch(_op)
        {
            case '+':
                return new Calculator().Add(num1, num2);
            case '-':
                return new Calculator().Subtract(num1, num2);
            case '*':
                return new Calculator().Multiply(num1, num2);
            case '/':
                return new Calculator().Divide(num1, num2);
            default:
                return 0;
        }
    }
}