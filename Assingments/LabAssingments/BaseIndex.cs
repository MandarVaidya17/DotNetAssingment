using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment
{
    internal class BaseIndex
    {
        static void Power(int b,int i)
        {
            int power=1;
            for(int j = 1; j <= i; i++)
            {
            power=power*b;
            }
            Console.WriteLine(power);
        }
        static void Main(string[] args)
        {
            Power(2,3);
        }
    }
}
