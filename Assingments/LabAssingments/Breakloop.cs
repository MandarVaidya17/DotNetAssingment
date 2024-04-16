using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//..2.WAP to show the use of break statement ( in for loop)
namespace LabAssignment
{
    public class Breakloop
    {
        static void bLoop()
        {
            for(int i = 0; i <= 20; i++)
            {
                if (i == 11)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            bLoop();
        }
    }
}
