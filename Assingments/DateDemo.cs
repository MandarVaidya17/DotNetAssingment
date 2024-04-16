using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class DateDemo
    {
        private int day;
        private int month;
        private int year;

        public DateDemo()
        {
            day = 12;
            month = 1;
            year = 2023;
        }

        public DateDemo(int day,int month,int year)
        {
            this.day = day;
            this.month = month; 
            this.year = year;
        }

        public string Display()
        {
            return $"Date ={day}/{month}/{year}";
        }
    }
}


