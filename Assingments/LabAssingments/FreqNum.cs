using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment
{
    internal class FreqNum
    {
        static void Main(string[] args)
        {
            int num = 122344;
            int count,digit;
            for(int i = 0; i <= 9; i++)
            {
                count = 0;
                int temp = num;
                while (temp > 0)
                {
                    digit = temp % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count > 0)
                {
                    Console.WriteLine(i+" count ="+count);
                }
            }
        }
    }
}
