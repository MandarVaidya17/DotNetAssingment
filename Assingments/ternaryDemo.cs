using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class ternaryDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int num=Convert.ToInt32(Console.ReadLine());

            string res = (num > 0) ? "positive no" : (num < 0) ? "negative" : "zero";
            Console.WriteLine(res);
        }
    }
}
