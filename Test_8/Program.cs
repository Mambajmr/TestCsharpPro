using System;

namespace Test_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними.

            int[] a = new int[4];
            for (int i = 0; i < 4; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = 0; j<4; j++)
            {
                Console.Write(a[j] + " ");
            }
        }
    }
}
