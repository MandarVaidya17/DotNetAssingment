using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assingments
{
    public class Manager :Employee1
    {
        private double food;

        public Manager():base() { 
                   
        }

        public Manager(int id, String name, double b, double h, double p,double food)
            :base(id, name,b,h,p)
        {
            this.food = food;
        }

        public override void CalculateSalary()
        {
            gross = (bs + hra+food) - pf;
        }

        public override string Display()
        {
            return $"Manager salary empid={empid}, empname={empname}, gross={gross}";

        }
    }
}
