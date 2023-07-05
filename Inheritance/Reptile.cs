using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() { }

        public string Color {get; set;}
        public string reptileType { get; set;}
        public bool hasScales { get; set;}
        public double MaxLength { get; set;}
    }
}
