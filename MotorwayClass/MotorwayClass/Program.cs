using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorwayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorway1 = new Motorway("Motorway 1", "Highway", 'S', "Asphalt", 3, false, "Maintenance company");

        }
    }
}

//Create a Motorway class that can be used as extra documentation with directions.Include data members such as name of motorway, type (i.e., Road, Street, Avenue, Blvd., Lane, etc.), direction (i.e., E, W, N, or S), surface (i.e., blacktop, gravel, sand, concrete), number of lanes, toll or no toll, and the party that maintains it.
//Write instance methods that returns the full name of the motorway, full name of the motorway and whether it is toll or not, and full name of the motorway and the number of lanes.
//Also include a ToString( ) method that returns all data members with appropriate labels.
//Include enough constructors to make the class flexible.