using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class addSub
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            int d = a - b;
            Console.WriteLine("Addition "+c);
            Console.WriteLine("Substraction "+d);


        }


    }
}
