using System;
using UrbanPlanner.PlannerFolder;


namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate - use the 'new' keyword to create the instance of an object.
            // initialize - give an instance an initial value.
            Building FiveOhTwo = new Building("502 SE Broad Street", "Nashville")
            {
                Width = 100,
                Depth = 10,
                Stories = 2,
            };

            Building oneTwoThree = new Building("123 Main Street", "Nashville");
            oneTwoThree.Width = 5;
            oneTwoThree.Stories = 2;
            oneTwoThree.Depth = 3;

            Building differentOne = new("1023 Something Ave", "Nashville")
            {
                Width = 3,
                Depth = 20,
                Stories = 1,
            };

            var Nashville = new City("Nashville");
            Nashville.AddBuilding(FiveOhTwo);
            Nashville.AddBuilding(differentOne);
            Nashville.electMayor("Madden Purcell");
            Nashville.cityDetails();
            Nashville.Buildings.ForEach(b => b.GiveDetails());

            //FiveOhTwo.Construct();
            //FiveOhTwo.Purchase("Jeff Bezos");
            //FiveOhTwo.GiveDetails();
        }
    }
}
