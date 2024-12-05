// See https://aka.ms/new-console-template for more information


using RockLab;
using System.ComponentModel.Design;


bool playAgain;
do
{
    try
    {

        // Create a Human Player
        Console.WriteLine("What's your name?");
        string playerName = Console.ReadLine();
        HumanPlayer human = new HumanPlayer(playerName);

        // Choose an opponent
        Console.WriteLine("Choose your opponent: (1) RockPlayer, (2) RandomPlayer");

        Player opponent = new RockPlayer(); // Default 
        bool validChoice = false;

        while (!validChoice)
        {
            try
            {
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    opponent = new RockPlayer { Name = "RockPlayer" };
                    validChoice = true;
                }
                else if (choice == "2")
                {
                    opponent = new RockPlayer { Name = "RandomPlayer" };
                    validChoice = true;
                }
                else
                {
                    throw new ArgumentException("Invalid choice. Please enter 1 or 2");

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        // Generate players' moves
        Roshambo humanMove = human.GenerateRoshambo();
        Roshambo opponentMove = opponent.GenerateRoshambo();

        Console.WriteLine($"{human.Name} throws {humanMove}");
        Console.WriteLine($"{opponent.Name} throws {opponentMove}");

        // Tells us the winner
        if (humanMove == opponentMove)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((humanMove == Roshambo.Rock && opponentMove == Roshambo.Scissors) ||
                (humanMove == Roshambo.Paper && opponentMove == Roshambo.Rock) ||
                (humanMove == Roshambo.Scissors && opponentMove == Roshambo.Paper))
        {
            Console.WriteLine($"{human.Name} wins");

        }
        else
        {
            Console.WriteLine($"{opponent.Name} wins!");
        }

        Console.WriteLine("Do you want to play again? (yes/no)");
        string replayInput = Console.ReadLine().ToLower();

        playAgain = replayInput == "yes";
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unexpected error" + ex.Message);
        playAgain = false;
    }
} while (playAgain);
Console.WriteLine("Thanks for playing!");

Console.ReadKey();