using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int N2=0;
            Console.WriteLine("Введите целое число N (N>0)");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                N2 = N2 + 2 * i - 1;
            }
                
            Console.WriteLine(+N2);
            Console.ReadKey();
        }
    }
}
