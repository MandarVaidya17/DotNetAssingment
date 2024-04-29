using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{

    public class NameException:Exception
    {
        public NameException(string error):base(error) {

        }
    }
    public class Person
    {
        public string name;
        public void AcceptName(string name)
        {
            if(string.IsNullOrEmpty(name))
            { 
                throw new NameException("Name is Not provided or emty");
            }
            else
            {
                this.name = name;
            }
        }

    }
}
