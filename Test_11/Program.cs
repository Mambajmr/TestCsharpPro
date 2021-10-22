using System;

namespace Test_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составить программу вывода на экран «столбиком» четырех любых чисел.
            int[] a = new int[4];
            for(int i = 0; i<4; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = 0; j < 4; j++)
            {
                Console.WriteLine(a[j]);
            }
        }
    }
}
