namespace Calc_You_Later;

public static class Interface
{  
    private static float _num1;
    private static char _op = ' ';
    private static bool _finished = false;
    public static void Write(bool first)
    {
        if(_finished) return;
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
            GetOperator();
            Write(false);
        }

        else
        {
            if(!_finished)
            {
                float result = Operate(_num1, num);
                Console.WriteLine($"{_num1} {_op} {num} = {result}");
                _finished = true;
                return;
            }
        }
    }

    private static void GetOperator()
    {
        if(_finished) return;
        Console.WriteLine(
        "1. Add\n" +
        "2. Subtract\n" +
        "3. Multiply\n" +
        "4. Divide");

        string? input = Console.ReadLine();
        if(!Int32.TryParse(input, out int result))
        {
            Console.Clear();
            Console.WriteLine($"Error - {input} is not a valid input");
            GetOperator();
            return;
        }
        switch(result)
        {
            case 1:
                _op = '+';
                break;
            case 2:
                _op = '-';
                break;
            case 3:
                _op = '*';
                break;
            case 4:
                _op = '/';
                break;
            default:
                Console.Clear();
                Console.WriteLine($"Error - {result} is not a valid input");
                GetOperator();
                break;
        }
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
                return 1;
        }
    }
}