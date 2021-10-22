using System;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести на экран число  с точностью до сотых. Начало теста 15:00
            double a = Convert.ToDouble(Console.ReadLine());
            a = Math.Round(a, 2);
            Console.WriteLine(a);
        }
    }
}
