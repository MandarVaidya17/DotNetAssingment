using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public partial class Calc
    {
        public void Sub(int a,int b)
        {
            int res= a - b;
            Print(res);
        }

        public void Mul(int a,int b)
        {
            int res = a * b;
            Print(res);
        }
        partial void Print(int c)
        {
            Console.WriteLine("Result="+c);
        }
    }
}
