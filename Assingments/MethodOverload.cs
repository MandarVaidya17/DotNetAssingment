using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class MethodOverload
    {
        public double CalArea(double radius)
        {
            return 3.14 * radius * radius;
        }
        public int CalArea(int side)
        {
            return side * side;
        }
        public double CalArea(double b, double h)
        {
            return 0.5 * b * h;
        }
        public int CalArea(int len,int br)
        {
            return len * br;
        }
        

        static void Main(string[] args)
        {
            MethodOverload obj = new MethodOverload();

            Console.WriteLine("Enter a Choise");
            Console.WriteLine("1.Area Of circle   2.Area of Square");
            Console.WriteLine("3.Area of rectangle 4.Area of triangle");

            int choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Radius of circle");
                    double radius=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area Of Circle is " + obj.CalArea(radius));
                    break;
                case 2:
                    Console.WriteLine("Enter Side of Sqaure");
                    int side=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of Square is "+obj.CalArea(side));
                    break;
                case 3:
                    Console.WriteLine("Enter Length");
                    int len = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Height");
                    int br = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of Rectriangle is " + obj.CalArea(len, br));

                    break;
                case 4:
                    Console.WriteLine("Enter base");
                    double ba = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Height");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Trinagle is " + obj.CalArea(ba, h));
                    break;
            }
        }
    }
}
