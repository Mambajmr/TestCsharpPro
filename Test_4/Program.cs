using System;

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} \"- Вот какое число Вы ввели\"");
        }
    }
}
