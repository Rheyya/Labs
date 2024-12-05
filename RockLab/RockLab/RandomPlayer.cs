using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockLab
{
    internal class RandomPlayer : Player
    {
        private Random random = new Random();

        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)random.Next(0, 3);
        }
    }
}
