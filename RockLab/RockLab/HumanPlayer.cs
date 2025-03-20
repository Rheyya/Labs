using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockLab
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
        
            Name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            while (true)
            {
                Console.WriteLine("Choose a move: (0) Rock, (1) Paper, (2) Scissors");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int choice) && choice >= 0 && choice <= 2)
                {
                    return (Roshambo)choice; // returns the player's chosen move
                }
                else
                {
                    Console.WriteLine("Invaild input. Please try again");
                }
            }
        }
    }
}
