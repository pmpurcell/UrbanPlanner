using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.PlannerFolder
{
    class Building
    {
        // Fields

        private string _designer = "Madden Purcell";
        private DateTime _dateConstructed;
        private string _address;
        private string _city;
        private string _owner;

        //Constructor
        public Building(string address, string city)
        {
            _address = address;
            _city = city;
        }
        // Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //Methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase( string newOwner)
        {
            _owner = newOwner;
        }

        public void GiveDetails()
        {
            string output = $@"
{_address}, {_city}----------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space";
            Console.WriteLine(output);
        }
    }
}
