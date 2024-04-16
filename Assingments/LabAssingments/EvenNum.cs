using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	WAP to print even numbers from 121 to 229 using do-while loop. 
namespace LabAssignment
{
    public class EvenNum
    {
        public void EvenFind()
        {
            int num = 121;
            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even Nnm=" + num);
                    
                }
                num++;
             
            } while (num <= 229);
        }
        static void Main(string[] args)
        {
            EvenNum e = new EvenNum();
            e.EvenFind();
        }
    }
}
