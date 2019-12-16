using System;

namespace Лаб.раб__10
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            Console.WriteLine("Введите цену за 1 кг конфет:");
            A = Convert.ToDouble(Console.ReadLine());//вывод А
            for (double i = 0.1; i < 1.0; i += 0.1)
                Console.WriteLine($"Цена за {i}: " + A * i);

        }
    }
}
