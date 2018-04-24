namespace MotorwayClass
{
    internal class Motorway
    {
        // Added Enums so that output naming is not bool values or Non Applicable.
        public enum IsToll 
        {
            Yes, No, NA
        }

        // This enum allows me to use North, South, etc instead of N, S, E, W or Non Applicable. 
        public enum Directions
        {
            North, South, East, West, NA
        }

        // Properties
        public string Name { get; set; }

        public string MotorwayType { get; set; }
        public char Direction { get; set; }
        public string Surface { get; set; }
        public int? NumberOfLanes { get; set; }
        public bool? Toll { get; set; } // Made null in order to supply values called.
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

        // Methods

        private IsToll IsMotorWayToll()
        {
            switch (Toll)
            {
                case true:
                    return IsToll.Yes;
                case false:
                    return IsToll.No;
                default:
                    return IsToll.NA;
            }
        }

        private Directions GetDirections()
        {
            switch (Direction)
            {
                case 'N':
                    return Directions.North;
                case 'S':
                    return Directions.South;
                case 'E':
                    return Directions.East;
                case 'W':
                    return Directions.West;

                default:
                    return Directions.NA;
            }
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