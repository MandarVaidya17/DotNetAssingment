using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class forloopDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int a = Convert.ToInt32(Console.ReadLine());
     
            for(int i = 1; i <= 10; i++)
            {
                int ans = a * i;
               Console.WriteLine(a+"*"+i+"="+ans);
            }
        }
    }
}
