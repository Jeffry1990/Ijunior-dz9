﻿namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int numbersOfRepeat;
            string exitCommand = "выход";
            bool isRunning = true;

            while (isRunning == true)
            {
                Console.Write($"Напишите любое слово для начала или {exitCommand} для завершения: "); ;
                userMessage = Console.ReadLine();

                if (userMessage != exitCommand)
                {
                    Console.Write("Сколько раз его вывести на экран?: ");
                    numbersOfRepeat = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < numbersOfRepeat; i++)
                    {
                        Console.WriteLine(userMessage);
                    }
                }
                else
                {
                    isRunning = false;
                    Console.WriteLine("Выход из приложения!");
                }
            }
        }
    }
}