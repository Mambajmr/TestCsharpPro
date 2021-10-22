using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести на экран число  с точностью до десятых.
            double a = Convert.ToDouble(Console.ReadLine());
            a = Math.Round(a, 1);
            Console.WriteLine(a);
        }
    }
}
