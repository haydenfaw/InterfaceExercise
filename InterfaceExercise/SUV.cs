using System;
using System.Collections.Generic;
using System.Text;

/*DONE -- Create 2 members that are specific to each class
*DONE -- Example: truck has a bed size while car has a trunk while suv has a cargo hold size
*
*DONE -- Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
* 
*/

namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public int CargoHoldSize { get; set; } //cubic feet
        public bool HasTowHitch { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public bool IsForeign { get; set; }
        public bool HasChangedGears { get; set; }
        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is driving!");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is reversing!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"Can't reverse until we change gears.");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is parking!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine($"Can't park until we change gears.");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
