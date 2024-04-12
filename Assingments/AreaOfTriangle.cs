using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height");
            int h=Convert.ToInt32(Console.ReadLine());

            double area = 0.5 * (b * h);
            Console.WriteLine("Area of Triangle is " + area);
        }
    }
}
