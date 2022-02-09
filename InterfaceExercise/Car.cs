using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {

        public Car()
        {

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public string CarColor { get; set; }
        public bool Automatic { get; set; }
    }
}
