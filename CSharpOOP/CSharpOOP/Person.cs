using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Person
    {

        // Public items can be seen anywhere.
        // Auto-Implemented Property (Automatically generates a default "getter" (accessor) and "setter" (mutator).
        // AccessModifier DataType PropertyName { get; set; }
        public string FirstName { get; set; }

        // Private items cannot be seen outside of the class. Marking it as private enforces that all data to be stored MUST go through the property.
        private string _lastName;
        // Fully-Implemented Property (You specify the beahviour for the "getter" (accessor) and "setter" (mutator).
        public string LastName
        {
            get
            {
                // For the getter, typically you will want to return the value from the backing variable.
                // You may format it first, etc. but that is not necessary.
                return _lastName;
            }
            set
            {
                // For the setter, typically you will want to assign the backing variable to the keyword "value" which represents what is being assigned to the property.
                // You may perform validation here as well.
                _lastName = value;
            }
        }


    }
}
