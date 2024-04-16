using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Student
    {
        private int rollno;
        private string name;

        //constructor which assign default value to members
        public Student()
        {
            rollno = 1;
            name = "PAblo";
        }

        //constructor with parameter

        public Student(int rollno,String name)
        {
            this.rollno = rollno; //this refers to the data member
            this.name = name;   
        }

        public string Display()
        {
            return $"Roll no={rollno}, name={name}";
        }
    }
}
