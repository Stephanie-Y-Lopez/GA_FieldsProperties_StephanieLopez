using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_FieldsProperties_StephanieLopez
{
    internal class Person
    {
        private string _name;
        //Private fields are used to limit direct acess to certain data.
        //And its role is to store the individual's name privately. 

        private string ReadOnlyProperty = "Read only Initial Value";
        private string WriteOnlyProperty;

        public string Name
        {
            get { return _name; }
            set { if (!string.IsNullOrEmpty(value)) _name = value; }

            // The need for using private fields is for  storing data that is not accessible from outside the class.
            // And public properties provide controlled access to these fields by allowing encapsulation. 
            // And the benefits if this exposition are, helping to maintain a clean orderly state of objects. Not allowing for unwanted modifications.

            //Since get and set properties are already implemeted above, the purpose and functionality of get is to retrieve the field value.  While sets functionality is to assign a new value. 
            //above I demonstrated how get retrieve the field value by get being associated with _name property. While set assigns a new value to _name.

            //Here is where I chose to put my validation process. Validation logic is important because it helps to ensure a value is not null or empty before assigning. And the process is to check for nulls or empties before assigning the value.

        }

        public string _ReadOnlyProperty
        {
            get
            {
                // This property is helpful by allowing external code to read its value but not modify it. And this may be helpful in scenarios such as calculating values and certain settings. 
                Console.WriteLine("Reading the read-only property");
                return ReadOnlyProperty;
            }
        }

        public string _WriteOnlyProperty
        {
            set
            {
                // This property is helpful by allowing external code to set a value, but not retrieve it. And this may be helpful in scenarios such as keeping records and planning. 
                Console.WriteLine("Setting the write-only property to: " + value);
                WriteOnlyProperty = value;
            }
        }

    }
}
