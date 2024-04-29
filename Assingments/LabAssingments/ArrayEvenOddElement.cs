using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    public class ArrayEvenOddElement
    {
       
        public static void EvenOdd(int[] ar)
        {
            int index = 0, index2 = 0;
            int[] even=new int[index];
            int[] odd=new int[index];

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    even[index2] = ar[i];
                }
                else
                {
                    odd[index2] = ar[i];
                }
                index++;
                index2++;
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55 };
            EvenOdd(arr);
        }

    }
}
