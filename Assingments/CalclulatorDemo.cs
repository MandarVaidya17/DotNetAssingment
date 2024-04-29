using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public delegate int MyDelegate(int x, int y);
    public class CalclulatorDemo
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        { 
            return a - b; 
        }
        public int Mul(int a,int b)
        {
            return a * b;
        }
    }
}
