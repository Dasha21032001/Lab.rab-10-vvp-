using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, znak=1;
            double step = 1, s=1;

            Console.WriteLine("Введите вещественное число A ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите целое число N");
            N = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= N; i++)
            {
            znak = -znak;
            step = step * A;
            s = s + znak * step;
            }
            Console.WriteLine(" число A равно {0} ", s);
            Console.Read();
        }
    }
}
