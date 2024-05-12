using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    internal class DemoClassPractice
    {
        public static void ReplaceWord(String s,string old,string n)
        {
            string[] arr= s.Split(' ');
            string replace = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == old)
                {
                    replace = replace + n;
                }
                else
                {
                    replace = replace + arr[i];
                }
                replace = replace + " ";
            }
            Console.WriteLine(replace);
        }
        static void Main(string[] args)
        {
            string str = "I love to learn java";
            ReplaceWord(str,"java","c#");
        }
    }
}
