using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class SumPrimeNum
    {
        public bool CheckPrime(int n)
        {
            if (n <= 1)
            { return false; }

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void CheckArray(int[] ar)
        {
            int sum = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                if (CheckPrime(ar[i]))
                {
                    sum=sum + ar[i];
                }
            }
            Console.WriteLine("Sum of array variables is " + sum);
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 6, 7, 8, 9,11};

            SumPrimeNum obj= new SumPrimeNum(); 
            obj.CheckArray(arr);
            
        }
    }
}
