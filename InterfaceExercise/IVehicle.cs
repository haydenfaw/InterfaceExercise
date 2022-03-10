using System;
using System.Collections.Generic;
using System.Text;

//In your IVehicle

/* DONE -- Create 4 members that Car, Truck, & SUV all have in common.
 * DONE -- Example: All vehicles have a number of wheels... for now..
 */

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool hasChanged);
    }
}
