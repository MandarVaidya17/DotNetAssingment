using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr=new int[3][];

            arr[0] = new int[] {1,2,3,4,5};
            arr[1] = new int[] { 10, 20, 30 };
            arr[2] = new int[] { 100, 200 };

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} " );
                }
                Console.WriteLine();
            }

            //with foreach
            Console.WriteLine("using foreach");
            foreach (int[] item in arr)
            {
                foreach(int i in item)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine() ;
            }
        }
    }
}
