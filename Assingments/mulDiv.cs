using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class mulDiv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int b=Convert.ToInt32(Console.ReadLine());

            int c = a * b;
            int d = a / b;

            Console.WriteLine("Multiplication " +c);
            Console.WriteLine("Division " + d);
        }
    }
}
