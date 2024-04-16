using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Employee
    {
        private int empid;
        private string empname;
        private double bs, hra, pf, gross;

        //working with method
        public void Assign()
        {
            empid = 1;
            empname = "Pablo";
            bs = 4000;
            hra = 2000;
            pf = 1000;
        }

        //method which accept the values from parameter

        public void Accept(int id,String name,double b,double h,double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;
        }

        public void CalculateSalary()
        {
            gross = (bs + hra) - pf;

        }

        public string Display()
        {
            return $"empid={empid}, empname={empname}, gross={gross}";
        }

    }
}
