using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Employee1
    {
        protected int empid;
        protected string empname;
        protected double bs, hra, pf, gross;

        public Employee1()
        {
            empid = 1;
            empname = "Pablo";
            bs = 4000;
            hra = 2000;
            pf = 1000;
        }

        

        public Employee1(int id, String name, double b, double h, double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;
        }

        public virtual void CalculateSalary()
        {
            gross = (bs + hra) - pf;

        }

        public virtual string Display()
        {
            return $"Employee salary empid={empid}, empname={empname}, gross={gross}";
        }

    }
}
