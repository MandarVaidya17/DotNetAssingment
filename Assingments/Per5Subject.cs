using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Per5Subject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 subject");
            int s1=Convert.ToInt32(Console.ReadLine());
            int s2=Convert.ToInt32(Console.ReadLine()); 
            int s3=Convert.ToInt32(Console.ReadLine()); 
            int s4=Convert.ToInt32(Console.ReadLine()); 
            int s5=Convert.ToInt32(Console.ReadLine());
            
            double percentage=(s1 + s2 + s3 + s4 + s5)*100/500;
            Console.WriteLine("Percentage is " + percentage);
            
        }
    }
}
