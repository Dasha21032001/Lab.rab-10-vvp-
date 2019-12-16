using System;

namespace задание__2
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, pr = 1;
            Console.WriteLine("Введите целое число N (N>0)");
            N = Convert.ToDouble(Console.ReadLine());
            for (double i = 0; i <= N / 10; i = i + 0.1)
            {
                pr = pr * (i + 1);
            }
            Console.WriteLine(pr);
            Console.ReadKey();
        }
    }
}
