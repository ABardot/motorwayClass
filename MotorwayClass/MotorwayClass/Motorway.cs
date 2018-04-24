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

        // Complete constructor
        public Motorway(string name, string type, char direction, string surface, int numberOfLanes, bool toll, string maintainance)
        {
            Name = name;
            MotorwayType = type;
            Direction = direction;
            Surface = surface;
            NumberOfLanes = numberOfLanes;
            Toll = toll;
            Maintainance = maintainance;
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

        public Motorway(string name, int numberOfLanes)
        {
            Name = name;
            NumberOfLanes = numberOfLanes;
        }

       

        public override string ToString()
        {
            return $"Motorway Name: {Name}\n" + 
                   $"Motorway Type: {MotorwayType}\n" +
                   $"Direction: {Direction}\n" +
                   $"Surface: {Surface}\n" +
                   $"Number of Lanes: {NumberOfLanes}\n" +
                   $"Toll: {Toll}\n" +
                   $"Maintenance: {Maintainance}\n";
        
        }
    }
}
