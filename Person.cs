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

        public string Name
        {
            get { return _name; }
            set { _name = value; }

            // The need for using private fields is for  storing data that is not accessible from outside the class.
            // And public properties provide controlled access to these fields by allowing encapsulation. 
            // And the benefits if this exposition are, helping to maintain a clean orderly state of objects. Not allowing for unwanted modifications.
        }
    }
}
