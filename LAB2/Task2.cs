using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Введіть значення елементів матриці 3x3:");
            // Зчитуємо значення елементів матриці з клавіатури
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                    if (int.TryParse(Console.ReadLine(), out int element))
                    {
                        matrix[i, j] = element;
                    }
                    else
                    {
                        Console.WriteLine("Невірний ввід. Будь ласка, введіть ціле число.");
                        j--; // Повторити введення для цього елемента
                    }
                }
            }
            int diagonalSum = 0;
            // Знаходимо суму елементів головної діагоналі
            for (int i = 0; i < 3; i++)
            {
                diagonalSum += matrix[i, i];
            }
            Console.WriteLine($"Сума елементів головної діагоналі: {diagonalSum}");
        }
    }
}
