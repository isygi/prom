using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Элементы массива в обратном порядке:");
            PrintArrayReverse(myArray, myArray.Length - 1);
        }

        static void PrintArrayReverse(int[] arr, int index)
        {
            if (index >= 0)
            {
                Console.Write(arr[index] + " ");
                PrintArrayReverse(arr, index - 1);
            }
        }
    }
}
