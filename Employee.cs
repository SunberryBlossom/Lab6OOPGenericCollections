using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPGenericCollections
{
    // Creating an enum for the gender variable, in order to only allow specific values I allow.
    enum Gender { Male, Female, NonBinary}

    internal class Employee
    {
        //----------PROPERTIES------------//
        public string Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
    }
}
