using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
    static void Main(string[] args)
        { 
            Random random = new Random();
            int secretNumber = random.Next(0, 11);
            int attempts = 3; // Кількість спроб
            Console.WriteLine("Вгадайте число від 0 до 10.");
            for (int i = 0; i < attempts; i++)
            {
                Console.Write($"Спроба {i + 1}: Введіть своє число: ");
                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    if (userGuess == secretNumber)
                    {
                        Console.WriteLine("Вітаємо, ви вгадали число!");
                        break;
                    }
                    else if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Загадане число більше.");
                    }
                    else
                    {
                        Console.WriteLine("Загадане число менше.");
                    }
                }
                else
                {
                    Console.WriteLine("Невірний ввід. Будь ласка, введіть ціле число.");
                    i--; // Повторити спробу
                }
                if (i == attempts - 1)
                {
                Console.WriteLine($"Ви не вгадали. Загадане число було {secretNumber}.");
                }
            }
        }
    }
}

