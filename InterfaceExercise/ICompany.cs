using System;
using System.Collections.Generic;
using System.Text;

//In ICompany

/*DONE -- Create 2 members that are specific to each every company
 *DONE --  regardless of vehicle type.
 *
 *
 *DONE -- Example: public string Logo { get; set; }
 */

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Logo { get; set; }
        public bool IsForeign { get; set; }

    }
}
