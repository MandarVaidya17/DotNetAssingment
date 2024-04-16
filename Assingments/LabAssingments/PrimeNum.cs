using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment
{
    internal class PrimeNum
    {
        static void findPrime(int n)
        {
            int count = 0;
            for(int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(n + " No is prime");
            }
        }
        static void Main(string[] args)
        {
            for(int i = 300; i <= 400; i++)
            {
               findPrime(i);
            }
        }
    }
}
