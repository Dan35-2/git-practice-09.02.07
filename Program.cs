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
            Console.WriteLine("--- Калькулятор сложения двух чисел ---");

            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine($"Результат сложения: {number1} + {number2} = {sum}");

        }
    }
}
