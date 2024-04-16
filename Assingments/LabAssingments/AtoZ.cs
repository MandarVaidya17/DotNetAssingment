using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.	Write a program to print all alphabets from a to z. - using  for loop
namespace LabAssignment
{
    public class AtoZ
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'Z'; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
