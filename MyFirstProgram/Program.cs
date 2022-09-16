using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;
using static System.Formats.Asn1.AsnWriter;

// credit to @discord memeber pablocappuccino
// this is project is a following to thecCsharpAcadmey.com tutorials


var date = DateTime.UtcNow;
var games = new List<string>();
string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
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
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplcationGame("Multiplacation game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "q":
                QuitGame();
                isGAmeOn = false;
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
   } while (isGAmeOn);

    
}

void AdditionGame(string message)
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

    AddToHistory(score, "Addition");
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType} : {gameScore} pts");
}

void SubtractionGame(string message)
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
AddToHistory(score, "Subtraction");
}

void MultiplcationGame(string message)
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

    AddToHistory(score, "Multiplaction");
}

void DivisionGame(string message)
{
    var score = 0;

    for (int i = 0; i< 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
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

    AddToHistory(score, "Division");

}

void QuitGame()
{
    Console.WriteLine("goodbye");
    Environment.Exit(1);
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    while (firstNumber % secondNumber !=0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    

    Console.WriteLine(result);

    return result;
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("-------------------------");
    foreach(var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("------------------------- \n");
    Console.WriteLine("Press any key to go to the main menu");
    Console.ReadLine();
}
