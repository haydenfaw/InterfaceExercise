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
    public class Truck : IVehicle , ICompany
    {
        public int BedLength  { get; set; } //in feet
        public bool HasFourWheelDrive { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public bool IsForeign { get; set; }
        public bool HasChangedGears { get; set; }
        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"The {GetType().Name} is driving!");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving!");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"Four wheel drive {GetType().Name} is reversing!");
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
