using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//check no is krishnamurthi or not
//153 = 1! + 5! + 3 != 153

namespace Assingments.LabAssingments
{
    internal class KrishnmurthiNum
    {
        static void KrishNum(int n)
        {
           
            int sum=0;
            int temp = n;

            while (temp != 0)
            {
                int fact = 1;
                int rem = temp % 10;
                for(int i = 1; i <= rem; i++)
                {
                    fact =fact*i;
                }
                sum = sum + fact;
                temp = temp / 10;
            }
           Console.WriteLine(sum);
            if (sum == n)
            {
                Console.WriteLine("Krishmurthi num");
            }
            else
            {
                Console.WriteLine("Not Krishmurthi nnum");
            }
        }
        static void Main(string[] args)
        {
            KrishNum(145);
        }
    }
}
