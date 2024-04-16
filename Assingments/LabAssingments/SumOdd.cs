using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//rite a program to find sum of all odd numbers between 1 to n.
namespace LabAssignment
{
    internal class SumOdd
    {
        static void Sodd(int n)
        {
            int res = 0;

           for(int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    res = res + i; 
                }
            }
           Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            int n = 10;

            Sodd(n);
        }
    }
}
