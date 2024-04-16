using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a  program to find sum of all even numbers between 1 to n. 
namespace LabAssignment
{
    public class SumEven
    {
        static void EvenNum(int n)
        {
            int res=0;
            for (int i = 1; i <= n; i++)
            {
                
                if (i % 2 == 0)
                {
                    res = res + i;
                }

            }
            Console.WriteLine(res);
           
        }
        static void Main(string[] args)
        {
            int num = 10;
            EvenNum(num);
        }
    }
}
