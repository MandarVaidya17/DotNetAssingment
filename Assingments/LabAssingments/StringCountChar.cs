using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    //5.	Write a C# program to count total number of words in a string. 
    public class StringCountChar
    {
        public static void CountChar(string s)
        {
            char[] chars = s.ToCharArray();
            int count = 0;
            foreach (char c in chars)
            {
                if(c != ' ')
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
        //10.	Write a C# program to find reverse of a string.

        public static void ReverseStr(string s)
        {
            char[] chars = s.ToCharArray();
            string rev = "";
            for(int i = chars.Length - 1; i >= 0; i--)
            {
                rev += chars[i];
            }
            Console.WriteLine(rev);
        }
        //17.	Write a C# program to reverse a given string with preserving the position of spaces
        public static void ReverseWord(string s)
        {
            string[] arr=s.Split(' ');
            string rev = "";
           for(int i=0;i<arr.Length; i++)
            {
                char[] chars = arr[i].ToCharArray();
                for(int j =chars.Length-1;j>=0;j-- )
                {
                    rev = rev + chars[j];
                }
                rev = rev + " ";
            }
           Console.WriteLine(rev);

        }

        //13.	Write a C# program to find total number of alphabets, digits or special character in a string.
        public static void TotalTypes(string s)
        {
            char[] arr=s.ToLower().ToCharArray();
            int alpha = 0, dig = 0, sc = 0;
            foreach(char c in arr)
            {
                if (c >= 'a' && c <= 'z')
                {
                    alpha++;
                }
                else if(c>=48 && c <= 57)
                {
                    dig++;
                }else
                {
                    sc++;
                }
            }
            Console.WriteLine("Total Alphabets in String is "+alpha);
            Console.WriteLine("Total NUmbers in String is " + dig);
            Console.WriteLine("Total special characters in String is " + sc);
        }
        //14.	Write a program using Regular Expression to check valid mobile number or not .Use matches method

        public static void CheckMobile(string s)
        {
            if (s.Length == 10)
            {
                
                for(int i=0;i<s.Length;i++)
                {
                    
                }
            }
        }
        //15.	Write a C# program to find the duplicate words and their number of occurrences in a string
        public static void CheckDuplicate(string s)
        {
            string[] arr = s.Split(' ');
            int count;
            
            HashSet<string> strNameSet = new HashSet<string>();
            for(int i = 0; i < arr.Length; i++)
            {
                count = 0;
                if (!strNameSet.Contains(arr[i].ToLower()))
                {
                    for (int j = arr.Length - 1; j >= 0; j--)
                    {
                        if (arr[j].ToLower().Equals(arr[i].ToLower()))
                        {
                            count++;

                        }
                    }
                    strNameSet.Add(arr[i].ToLower());
                    Console.WriteLine(arr[i] + " " + count);
                }
            }
        }
        //19.	How do you swap two string variables without using third or temp variable in C#
        public static void SwapString()
        {
            string s1 = "Good";
            string s2 = "Morning";

            s1 = s1 + s2;
            Console.WriteLine(s1);

            s2 = s1.Substring(0, s1.Length - s2.Length);
            Console.WriteLine(s2);
            s1 = s1.Substring(s2.Length);
            Console.WriteLine(s1);
        }
        static void Main(string[] args)
        {
            string str = "Mandar vaidya Mandar yeda peda mandar vaidya peda";
           // CountChar(str);
           // ReverseStr(str);
           //ReverseWord(str);
           //TotalTypes(str);
           //SwapString();
           CheckDuplicate(str);
        }
    }
}
