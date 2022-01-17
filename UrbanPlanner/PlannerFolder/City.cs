using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.PlannerFolder
{
    class City
    {
        // Fields
        private string _cityName;
        private int _dateFounded = DateTime.Now.Year;

        //Properties
        public string cityMayor { get; set; }
        public List<Building> Buildings{ get; set; } = new List<Building>(); 

        // Constructor
        public City (string name)
        {
            _cityName = name;
        }

        // Methods
    public void electMayor( string mayor)
        {
            cityMayor = mayor;
        }

    public void AddBuilding(Building building)
        {
            //if(Buildings == null)
            //{
            //    Buildings = new List<Building>();
            //}
            Buildings.Add(building);
            //throw new NotImplementedException("AddBuilding method is not yet defined.");
        }

     public void cityDetails()
        {
            Console.WriteLine($"{_cityName}, Founded in {_dateFounded}, Mayor: {cityMayor}");
        }

     //public void cityBuildings()
     //   {
     //       foreach (var b in City.Buildings) {
     //           b.GiveDetails();
     //       }
     //   }
    }
}
