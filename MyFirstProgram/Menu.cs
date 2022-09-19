namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math game. That's great that you are working on improving yourself.");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGAmeOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplaction
D - Division
Q - Quit the program");
                Console.WriteLine("-----------------------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        engine.MultiplcationGame("Multiplacation game");
                        break;
                    case "d":
                        engine.DivisionGame("Division game");
                        break;
                    case "q":
                        engine.QuitGame();
                        isGAmeOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGAmeOn);


        }
    }
}
