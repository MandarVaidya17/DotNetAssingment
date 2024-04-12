using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Gretestin3Num
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter num1");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine(n1 + " Is a gretest no");
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine(n2 + " IS a gretest no");
            }
            else
            {
                Console.WriteLine(n3 + " is a gretest no");
            }

        }
    }
}
