using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Калькулятор вычисления ---");

            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            bool vihod = false;
            do
            {
                Console.Write("Введите знак операции (+ * / v): ");
                char symbol = Convert.ToChar(Console.ReadLine());

                double sum = 0;
                switch (symbol)
                {
                    case '+':
                        sum = number1 + number2;
                        Console.WriteLine($"Результат сложения: {number1} + {number2} = {sum}");
                        break;
                    case '*':
                        sum = number1 * number2;
                        Console.WriteLine($"Результат умножения: {number1} * {number2} = {sum}");
                        break;
                    case '/':
                        sum = number1 / number2;
                        if (number2 == 0)
                        {
                            Console.WriteLine("Ошибка! Деление на ноль не возможно.");
                        }
                        else
                        {
                            Console.WriteLine($"Результат деления: {number1} / {number2} = {sum}");
                        }
                        break;
                    case 'v':
                        vihod = true;
                        break;
                    default:
                        Console.WriteLine("Неверный знак! Для выхода, введите символ 'v'.");
                        break;
                }
            } while (!vihod);

        }
    }
}
