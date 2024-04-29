using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    //3.	WAP to print all negative elements in an array and also count total number of negative elements in an array
    public class ArrayNegativeNum
    {
        public static void NegativeElement(int[] ar)
        {
            int count = 0;
            for(int i=0;i<ar.Length; i++)
            {
                if (ar[i] < 0)
                {
                    Console.WriteLine(ar[i]);
                    count++;
                }
            }
            Console.WriteLine($"count of negative number is {count}");
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -9, 5, -2, 4, -8, -6, -1, 5, 8, -10 };
            NegativeElement(arr);
        }
    }
}
