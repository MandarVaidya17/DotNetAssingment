using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    //12.	WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be
    //[78, 37, 29, 45, 90, 3] without using temporary array.
    internal class ArrayReverse
    {
        public static void ReverseArraytest(int[] arr)
        {
            int j=arr.Length-1;
            
            for (int i = 0; i <arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }


        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };

            ReverseArraytest(arr);



        }
    }
}
