using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    internal class Array2D
    {
        static void Main(string[] args)
        {
            int[,] num = new int[2, 3];
            int[,] num1 = new int[2, 3];


            Console.WriteLine("Enter array num");
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter array num1");
            for (int i = 0; i < num1.GetLength(0); i++)
            {
                for (int j = 0; j < num1.GetLength(1); j++)
                {
                    num1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] add = new int[2, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    add[i, j] = num[i, j] + num1[i, j];
                    Console.WriteLine($"{num[i, j]}+{num1[i, j]} =" + add[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
