using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            double c=1;

            Console.WriteLine("Введите вещественное число A ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите целое число N");
            N = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
                c += Math.Pow(A, i);
            }
            Console.WriteLine(" число A равно {0} ", c);
            Console.Read();
        }
    }
}
