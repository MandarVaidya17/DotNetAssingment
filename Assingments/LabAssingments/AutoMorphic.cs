using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    internal class AutoMorphic
    {
        static void Main(string[] args)
        {
            int num = 5;
            int temp = num;
            int power,count=0;
            int rem=0;
            power = num * num;
            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }
            Console.WriteLine(count);
            if (count == 1)
            {
                rem = power % 10;
               
            }else if(count == 2)
            {
                rem = power % 100;
               
            }
            Console.WriteLine(power);
            if (num == rem)
            {
                Console.WriteLine("Automorphic");
            }
            else
            {
                Console.WriteLine("NOt automorphic");
            }
        }
    }
}
