using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird - DONE
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile - DONE
            // Set this class to inherit from your Animal Class - DONE




            /*Create an object of your Bird class - DONE
             *  give values to your members using the object of your Bird class - DONE
             *  
             * Creatively display the class member values - DONE
             */

            /*Create an object of your Reptile class - DONE
             *  give values to your members using the object of your Reptile class - DONE
             *  
             * Creatively display the class member values - DONE
             */


            Bird bird1 = new Bird();
            bird1.birdSpecies = "Icterus galbula";
            bird1.beakLength = 2.5;
            bird1.FeatherColor = "orange";
            bird1.NumberOfWings = 2;
            bird1.Legs = 2;
            bird1.NaturalHabitat = "woodlands";
            bird1.Name = "Baltimore Oriole";
            bird1.CanFly = true;

            Console.WriteLine($"This animal is a {bird1.Name}, scientifically known as {bird1.birdSpecies}. It lives in {bird1.NaturalHabitat}, has {bird1.Legs} legs, {bird1.FeatherColor} feathers, and a beak that is {bird1.beakLength} inches long. {Bird.CanFlyResult(bird1)}");


            Reptile reptile1 = new Reptile();
            reptile1.reptileSpecies = "Crotalus atrox";
            reptile1.hasScales = true;
            reptile1.Color = "brown-olive";
            reptile1.MaxLength = 4.5;
            reptile1.Legs = 0;
            reptile1.Name = " Western Diamondback Rattlesnake";
            reptile1.CanFly = false;
            reptile1.NaturalHabitat = "deserts";

            Console.WriteLine($"This animal is a {reptile1.Name}, scientifically known as {reptile1.reptileSpecies}. It lives in {reptile1.NaturalHabitat}, has {reptile1.Legs} legs, has {reptile1.Color} color, and is {reptile1.MaxLength} feet long. {Reptile.CanFlyResult(reptile1)}");

            
        }
    }
}
