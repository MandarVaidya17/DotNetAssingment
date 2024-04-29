using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Merge2Array
    {
        public void MergeArr(int[] a1, int[] a2) {
            int len1=a1.Length;
            int len2=a2.Length;

            int[] MArr=new int[len1+len2];
            int k = 0;

            for(int i = 0; i < len1; i++)
            {
                MArr[k++] = a1[i];
            }
            for (int i = 0; i < len2; i++)
            {
                MArr[k++] = a2[i];
            }

            for(int i = 0;i< MArr.Length; i++)
            {
                Console.Write(MArr[i]); 
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 4, 5, 6, 3 };
            Merge2Array obj=new Merge2Array();
            obj.MergeArr(arr1, arr2);

        }
    }
}
