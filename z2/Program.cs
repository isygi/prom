﻿
using System;

namespace AckermannFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение m: ");
            int m = int.Parse(Console.ReadLine()!);

            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine()!);

            int result = Ackermann(m, n);
            Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно {result}");
        }

        static int Ackermann(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return Ackermann(m - 1, 1);
            else
                return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
