using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Birds prop1 = new Birds();
            prop1.WingSpan = (7.5);
            prop1.Feathers = (true);
            prop1.BeakLength = (6.83);
            prop1.FlightLength = (125);
            prop1.Eyes = (2);
            prop1.Ears = (2);
            prop1.Legs = (2);
            prop1.Feet = (2);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile prop2 = new Reptile();
            prop2.Height = (15);
            prop2.Aquatic = (true);
            prop2.Diet = ("Meat");
            prop2.AmountOfScales = ("Heavy");
            prop2.Eyes = (2);
            prop2.Ears = (2);
            prop2.Legs = (4);
            prop2.Feet = (4);

            Console.WriteLine($"Let's play a game and see if you can guess the bird first then Reptile. First up is the bird.");
            Console.WriteLine();
            Console.WriteLine($" This bird has:");
            Console.WriteLine();
            Console.WriteLine($" {prop1.Feet} feet with massive talons:" +
                $"\n {prop1.Legs} legs:" +
                $"\n {prop1.Ears} hidden ears:" +
                $"\n {prop1.Eyes} eyes that can see very far away:" +
                $"\n It's wingspan is {prop1.WingSpan} feet long:" +
                $"\n Very {prop1.Feathers} to most birds it has many feathers:" +
                $"\n It's average beak length is {prop1.BeakLength}cm:" +
                $"\n And has been reported to fly up to {prop1.FlightLength} miles before landing:");
            Console.WriteLine();
            Console.WriteLine("If you guessed the Bald Eagal you would be correct!");
            Console.WriteLine();
            Console.WriteLine("Now for the reptile.");
            Console.WriteLine();
            Console.WriteLine("This reptile has:");
            Console.WriteLine();
            Console.WriteLine($" {prop2.Feet} feet close to its body:" +
                $"\n {prop2.Legs} legs that are stubby:" +
                $"\n {prop2.Ears} hidden ears like our bird friend:" +
                $"\n {prop2.Eyes} eyes that work well at keeping out water:" +
                $"\n They can get as large as {prop2.Height} feet:" +
                $"\n And they are {prop2.Aquatic}ly most happy in the water:" +
                $"\n They mostly like to eat {prop2.Diet}:" +
                $"\n And are {prop2.AmountOfScales} in the amount of scales they have:");
            Console.WriteLine();
            Console.WriteLine("If you guessed Alligator then you are correct!");
            Console.WriteLine();
            Console.WriteLine("I hope you had a fun time trying to guess the animal!");
        }
    }
}
