using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
                int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int b=Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($" Addition is {c}");

        }
    }
}
