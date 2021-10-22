using System;

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {a}");
        }
    }
}
