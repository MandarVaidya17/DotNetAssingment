using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    //10.	WAP to merge 2 arrays to 3rd array. 
    internal class ArrayMerge
    {
        public static void MergeArr(int[] a, int[] b)
        {
            int count =0;
            int[] arr = new int[a.Length+b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                if (i < a.Length) { 
                arr[count++] = a[i];
            }
                if (i < b.Length)
                {
                    arr[count++] = b[i];
                }
            }
            

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 5, 6, 7, 8, 9 };

            MergeArr(a, b);
        }
    }
}
