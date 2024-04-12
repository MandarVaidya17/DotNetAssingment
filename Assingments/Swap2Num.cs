using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
     public class Swap2Num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap");
                Console.WriteLine("num1=" + num1 + " num2=" + num2);
            num1=num1+num2;
            num2=num1-num2;
            num1 = num1 - num2;
            Console.WriteLine("After swap");
            Console.WriteLine("num1=" + num1 + " num2=" + num2);

        }
    }
}
