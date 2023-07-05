using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() { }

        public string FeatherColor { get; set; }
        public string BirdType { get; set;}
        public int NumberOfWings { get; set; }

        public double beakLength { get; set; }
    }
}
