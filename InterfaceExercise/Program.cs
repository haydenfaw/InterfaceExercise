using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE -- Create 2 Interfaces called IVehicle & ICompany

            //DONE -- Create 3 classes called Car , Truck , & SUV

            //DONE -- In each of your car, truck, and suv classes

            //DONE -- Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicleList = new List<IVehicle>();
            var companyList = new List<ICompany>();
            //Civic dot notation
            var civic = new Car();
            civic.Logo = "H";
            civic.Model = "Civic";
            civic.TrunkSize = 15;
            civic.Make = "Honda";
            civic.NumberOfDoors = 2;
            civic.NumberOfWheels = 4;
            civic.HasSunRoof = false;
            civic.IsForeign = false;

            vehicleList.Add(civic);
            companyList.Add(civic);

            //Raptor object
            var raptor = new Truck()
            {
                Logo = "F",
                Make = "Ford",
                Model = "Raptor",
                BedLength = 66,
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                HasFourWheelDrive = true,
                IsForeign = false
            };

            vehicleList.Add(raptor);
            companyList.Add(raptor);

            //GX
            var gX = new SUV()
            {
                Logo = "L",
                Make = "Lexus",
                Model = "GX",
                CargoHoldSize = 12,
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                HasTowHitch = false,
                IsForeign = true
            };

            vehicleList.Add(gX);
            companyList.Add(gX);

            Console.WriteLine($"The spreadsheet will break down the following vehicles: {civic.Model}, {raptor.Model}, {gX.Model}:");

            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"-------------------------------------");
                Console.WriteLine($"Vehicle: {vehicle.Model} Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine($"Functionality Test: ");
                Console.WriteLine($"---------------------------------");
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
                vehicle.Park();
                
            }
        }
    }
}
