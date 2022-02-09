using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var corvette = new Car() { Year = 2008, Make = "Chevy", Model = "Corvette Z06", NumberOfWheels = 4, CompanyName = "GM", NumberOfEmployees = 50000, CarColor = "Red", Automatic = false };

            var silverado = new Truck() { Year = 2019, Make = "Chevy", Model = "Silverado", NumberOfWheels = 4, CompanyName = "GM", NumberOfEmployees = 50000, TowCapacity = 5000, BedLength = 8 };

            var fourRunner = new SUV() { Year = 2016, Make = "Toyota", Model = "4Runner", NumberOfWheels = 4, CompanyName = "Toyota", NumberOfEmployees = 80000, FourWheelDrive = true, RimColor = "Black" };
            
            var vehicleList = new List<IVehicle>() { corvette, silverado, fourRunner };

            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"{vehicle.Year} - {vehicle.Make} - {vehicle.Model}");
                Console.WriteLine("----------------------------");
            }


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
