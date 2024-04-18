using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12.	s=1!+2!+3!.........+n! find s
namespace Assingments.LabAssingments
{
    public class FindS
    {
     
        static void Main(string[] args)
        {
          
            int res = 1;
            int sum = 0;
            for (int i = 1; i <= 4; i++)
            {
                res = res * i;
                sum = sum + res;
            }
           
            Console.WriteLine(sum);
        }
    }
}
