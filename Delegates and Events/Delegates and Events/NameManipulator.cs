using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_Events
{
       // Delegate is async type that defines a method signature, it is useful to hold
        //reference to one or more methods

        public delegate string UserDetails(string a, string b);
        class NameManipulator
        {
            public string ConcatenateName(string firstname, string lastname)
            {
                return firstname + " " + lastname;
            }
            public string ExtractInitials(string firstname, string lastname)
            {
                return firstname[0].ToString() +" " + lastname[0].ToString();
            }
        }
  
}
