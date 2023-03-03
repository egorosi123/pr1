using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0; int num2 = 0;

            Console.WriteLine("Приложение: Калькулятор\r");

            Console.WriteLine("Введите первое число");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберете опцию из списка:");
            Console.WriteLine("\ta - Сложить");
            Console.WriteLine("\ts - Вычесть");
            Console.WriteLine("\tm - Умножить");
            Console.WriteLine("\td - Делить");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Ваш результат: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Ваш результат: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Ваш результат: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Ваш результат: {num1} / {num2} = " + (Convert.ToDouble(num1) / Convert.ToDouble(num2)));
                    break;
            }
            Console.Write("Нажмите любую клавишу для завершения работы");
            Console.ReadKey();
        }
    }
}
