using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal() { }

        public int Legs { get; set; }

        public string Name { get; set; }

        public bool CanFly { get; set; }

        public string NaturalHabitat {get; set; }

        public static string CanFlyResult(Animal animal)
        {
            bool canFly = animal.CanFly;

            if (canFly == true)
            {
                return "The animal can fly.";
            }
            else
            {
                return "The animal cannot fly.";
            }


        }

    }

    
}
