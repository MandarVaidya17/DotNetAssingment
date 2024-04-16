using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a  program to count number of digits in any number
namespace LabAssignment
{
    public class CountInNum
    {
        static void Main(string[] args)
        {
            int n = 12345;
            int rem = n / 10;
            int count = 0;
            while(n!=0) {

                n = n / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
