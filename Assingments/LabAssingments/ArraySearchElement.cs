using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    //1.	WAP to search for a given number in an array and accordingly print the index if exists
    public class ArraySearchElement
    {
        public void SearchArr(int[] arr,int n)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine($"Index of {arr[i]} is {i}");
                }
                
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 6, 7, 4, 8, 2, 9 };
            ArraySearchElement obj=new ArraySearchElement();
            obj.SearchArr(arr, 7);
        }
    }
}
