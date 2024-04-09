using System;

namespace NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение M: ");
            int M = int.Parse(Console.ReadLine()!);

            Console.Write("Введите значение N: ");
            int N = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Натуральные числа от {M} до {N}:");
            PrintNaturalNumbers(M, N);
        }

        static void PrintNaturalNumbers(int start, int end)
        {
            if (start <= end)
            {
                Console.Write($"{start} ");
                PrintNaturalNumbers(start + 1, end);
            }
        }
    }
}

