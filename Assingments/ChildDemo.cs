using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{

     public  interface InterfaceDEmo
    {
        int i { get; }
        static int j = 90;
    }
    public class ChildDemo: AbstractDemo,InterfaceDEmo
    {

        public int i { get; } = 10;
        public int AddVar()
        {
            return a + InterfaceDEmo.j;
        }

        static void Main(string[] args)
        {
            ChildDemo obj = new ChildDemo();
            Console.WriteLine("Addition of 2 Variables ="+obj.AddVar());
        }
    }
}
