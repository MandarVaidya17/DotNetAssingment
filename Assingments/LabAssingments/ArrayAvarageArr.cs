using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    public class ArrayAvarageArr
    {
         public static int Average(int[] array)
        {
            int sum = 0;
            int avg=0;
            for(int i=0;i<array.Length; i++)
            {
                sum = sum + array[i];
                avg = sum / array.Length;
            }
            return avg;
        }
        public static double Average(double[] array)
        {
            double sum = 0;
            double avg=0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                avg = sum / array.Length;
            }
            return avg;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] array2 = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine(Average(array));
           Console.WriteLine(Average(array2));
        }
    }
}
