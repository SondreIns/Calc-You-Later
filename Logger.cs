using System.Collections.Generic;

namespace Calc_You_Later;

public static class Logger
{
    private static List<string> _log = new();

    public static void Write()
    {
        Console.Clear();
        foreach(string msg in _log)
        {
            Console.WriteLine(msg);
        }
    }
}