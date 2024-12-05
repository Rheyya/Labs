using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockLab
{
    internal abstract class Player
    {
        public string Name { get; set; }
        public Roshambo RoshamboValue { get; set; }

        public abstract Roshambo GenerateRoshambo();

    }
}
