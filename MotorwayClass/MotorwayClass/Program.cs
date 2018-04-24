using System;

namespace MotorwayClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Created four different Constructors and called all four Constructors
            var motorway1 = new Motorway("Motorway 1", "Highway", 'S', "Asphalt", 3, false, "Acme Asphalt Company");
            Console.WriteLine(motorway1 + "\n");

            var motorway2 = new Motorway("Motorway 2", true);
            Console.WriteLine(motorway2 + "\n");

            var motorway3 = new Motorway("Motorway 3");
            Console.WriteLine(motorway3 + "\n");

            var motorway4 = new Motorway("Motorway 4", 2);
            Console.WriteLine(motorway4 + "\n");
        }
    }
}

//Create a Motorway class that can be used as extra documentation with directions.Include data members such as name of motorway, type (i.e., Road, Street, Avenue, Blvd., Lane, etc.), direction (i.e., E, W, N, or S), surface (i.e., blacktop, gravel, sand, concrete), number of lanes, toll or no toll, and the party that maintains it.
//Write instance methods that returns the full name of the motorway, full name of the motorway and whether it is toll or not, and full name of the motorway and the number of lanes.
//Also include a ToString( ) method that returns all data members with appropriate labels.
//Include enough constructors to make the class flexible.