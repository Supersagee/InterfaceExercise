using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public Truck()
        {

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public int TowCapacity { get; set; }
        public int BedLength { get; set; }
        
    }
}
