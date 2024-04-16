using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment
{
    internal class ProductNUm
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int p = 1;
            while (num!=0) {
                int rem = num % 10;
                if (rem != 0)
                {
                    p = p*rem;
                }
                num = num / 10;
            }

            Console.WriteLine(p);
        }

    }
}
