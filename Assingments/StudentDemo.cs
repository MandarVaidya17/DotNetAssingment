using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class StudentDemo
    {
        private int id;
        private string name;
        private int sub1,sub2,sub3;
        private double per;

        public void getStudDetails()
        {
            Console.WriteLine("Enter Student ID");
            id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter 3 Sub Marks");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2=Convert.ToInt32(Console.ReadLine());
            sub3=Convert.ToInt32(Console.ReadLine());
        }

        public double CalPer()
        {
            per = (sub1 + sub2 + sub3) * 100 / 300;
            return per;
        }

        public void Display()
        {
            Console.WriteLine($"StudId={id} Student Name={name} Student Percentage={CalPer()}");
        }
       
    }
}
