using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace common_denominator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            GCD(array);

        }

        public static string GCD(int[,] array)
        {
            int c = array.GetLength(0);
            long l = 1;
            for (var i = 0; i < c; i++) { l = LCM(array[i, 1], l); };
            var sb = new StringBuilder();
            for (var i = 0; i < c; i++)
            {
                sb.AppendFormat("({0},{1})", array[i, 0] * l / array[i, 1], l);
            }
            WriteLine(sb.ToString());
            return sb.ToString();
        }

        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static long LCM(long a, long b)
        {
            return a * b / GCD(a, b);

        }

    }
}
