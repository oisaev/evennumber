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

        /// <summary>
        /// Проверкой остатка от деления на 2
        /// </summary>
        /// <param name="inpNumber"></param>
        /// <returns></returns>
        static bool Method1(int inpNumber)
        {
            return inpNumber % 2 == 0;
        }

        /// <summary>
        /// Проверкой, является ли последняя цифра в числе четной
        /// </summary>
        /// <param name="inpNumber"></param>
        /// <returns></returns>
        static bool Method2(int inpNumber)
        {
            return "02468".Contains(inpNumber.ToString()[^1]);
        }

        /// <summary>
        /// Использованием побитового И для определения младшего разряда в бинарной записи числа
        /// (в нечетном числе всегда 1)
        /// </summary>
        /// <param name="inpNumber"></param>
        /// <returns></returns>
        static bool Method3(int inpNumber)
        {
            return ! Convert.ToBoolean(inpNumber & 1);
        }

        /// <summary>
        /// То же, что и метод 2, но в записи с использованием регулярного выражения
        /// </summary>
        /// <param name="inpNumber"></param>
        /// <returns></returns>
        static bool Method4(int inpNumber)
        {
            string input = inpNumber.ToString();
            string pattern = @"[02468]$";
            return Regex.Match(input, pattern).Success;
        }

        /// <summary>
        /// Побитовым сдвигом на 31 бит влево и проверкой последнего бита
        /// (в четном всегда 0)
        /// </summary>
        /// <param name="inpNumber"></param>
        /// <returns></returns>
        static bool Method5(int inpNumber)
        {
            return inpNumber << 31 == 0;
        }

        /// <summary>
        /// Использование поведения целочисленного деления
        /// </summary>
        /// <param name="inpNumber"></param>
        /// <returns></returns>
        static bool Method6(int inpNumber)
        {
            return inpNumber / 2 * 2 == inpNumber;
        }

    }
}
