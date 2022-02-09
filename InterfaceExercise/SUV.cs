using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {

        public SUV()
        {

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public bool FourWheelDrive { get; set; }
        public string RimColor { get; set; }

    }
}
