using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);


                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Press any key to continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!Press any key to continue");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubtractionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                if (firstNumber - secondNumber > 0)
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Your answer was correct! Press any key to continue");
                        Console.ReadLine();
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer was incorrect! Press any key to continue");
                        Console.ReadLine();
                    }

                    if (i == 4)
                    {
                        Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    // decrement the i variable so the loop/attempt doesn't count against the user
                    i--;
                    
                }

            }
            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplcationGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);


                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was incorrect! Press any key to continue");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Press any key to continue");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();


                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score} . Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);

        }


        internal void QuitGame()
        {
            Console.WriteLine("goodbye");
            Environment.Exit(1);
        }
    }
}
