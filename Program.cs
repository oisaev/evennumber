using System;
using System.Text.RegularExpressions;

namespace evennumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = -21; i <= 21; i++)
                Console.WriteLine(i.ToString() + " " + Method6(i).ToString());
        }

        static bool Method1(int inpNumber)
        {
            return inpNumber % 2 == 0;
        }

        static bool Method2(int inpNumber)
        {
            return "02468".Contains(inpNumber.ToString()[^1]);
        }

        static bool Method3(int inpNumber)
        {
            return ! Convert.ToBoolean(inpNumber & 1);
        }

        static bool Method4(int inpNumber)
        {
            string input = inpNumber.ToString();
            string pattern = @"[02468]$";
            return Regex.Match(input, pattern).Success;
        }

        static bool Method5(int inpNumber)
        {
            return inpNumber << 31 == 0;
        }

        static bool Method6(int inpNumber)
        {
            return inpNumber / 2 * 2 == inpNumber;
        }

    }
}
