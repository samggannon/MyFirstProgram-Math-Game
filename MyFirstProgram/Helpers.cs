﻿using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class Helpers 
    {

        internal static List<Game> games = new List<Game>();

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;



            Console.WriteLine(result);

            return result;
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} : {game.Score} pts");
            }
            Console.WriteLine("------------------------- \n");
            Console.WriteLine("Press any key to go to the main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
    }
}
