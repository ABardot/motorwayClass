using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorwayClass
{
    class Motorway
    {
        // Properties
        public string Name { get; set; }
        public string MotorwayType { get; set; }
        public char Direction { get; set; }
        public string Surface { get; set; }
        public int NumberOfLanes { get; set; }
        public bool Toll { get; set; }
        public string Maintainance { get; set; }

        // Constructors
        public Motorway()
        {
            // Default
        }

        public Motorway(string name)
        {
            Name = name;
        }

        public Motorway(string name, bool toll)
        {
            Name = name;
            Toll = toll;
        }
    }
}
