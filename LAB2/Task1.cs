using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введіть {i + 1}-е число: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    numbers[i] = inputNumber;
                }
                else
                {
                    Console.WriteLine("Невірний ввід. Введіть ціле число.");
                    i--; // Повторити введення для цього числа
                }
            }
            int minPositiveNumber = FindMinPositiveNumber(numbers);
            if (minPositiveNumber == int.MaxValue)
            {
                Console.WriteLine("Серед введених чисел немає додатніх чисел.");
            }
            else
            {
                Console.WriteLine($"Найменше додатнє число: {minPositiveNumber}");
            }
        }

        static int FindMinPositiveNumber(int[] numbers)
        {
            int minPositive = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num > 0 && num < minPositive)
                {
                    minPositive = num;
                }
            }
            return minPositive;
        }
    }
}
