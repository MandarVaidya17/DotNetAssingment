using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public interface ITaxable
    {
        double PayTax();//public abstract virtual
    }
    //implicit implement of interface

    public class Job:ITaxable
    {
        private double salary;
        private double taxamount;
        public Job() {
            salary = 10000;
        }
        public double PayTax()
        {
            taxamount = salary * 0.20;
            return taxamount;
        }
    }


    public class Businees : ITaxable
    {
        private double salary;
        private double taxamount;
        public Businees()
        {
            salary = 10000;
        }
        public double PayTax()
        {
            taxamount = salary * 0.30;
            return taxamount;
        }
    }
}
