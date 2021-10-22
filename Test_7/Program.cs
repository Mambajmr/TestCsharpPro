using System;

namespace Test_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a}  {b}  {c}");
        }
    }
}
