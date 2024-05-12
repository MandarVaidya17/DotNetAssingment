using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments.LabAssingments
{
    public class StringHighFrequency
    {
        
        public static void HighFreqChar(string s)
        {
            char[] chars = s.ToCharArray();
            char temp=' ';
            int count = 0;
            for(int i = 0; i < chars.Length; i++)
            {
                int c = 0;
                for(int j=0;j< chars.Length;j++) {
                    if (chars[i].Equals(chars[j]))
                    {
                        c++;
                        if (count <= c)
                        {
                            count = c;
                            temp = chars[j];
                        }
                    }
                }
               
            }
            Console.WriteLine(temp+" Count of high freq is "+count);
        }

        //18.	WAP to find longest word in the given sentence

        public static void LongWord(string s)
        {
            string[] arr = s.Split(" ");
            int l= 0;
            string temp = "";
            for(int i = 0;i < arr.Length;i++)
            {                   
                    if (arr[i].Length > l)
                    {
                        l = arr[i].Length;  
                        
                       temp = arr[i];
                    }
                
            
            }
            Console.WriteLine(l + " " + temp);
        }

        public static void HighFreqWord(string s)
        {
            string[] arr= s.Split(" ");
            int l=0;
            string temp = "";
            foreach(string s2 in arr)
            {
                int c = 0;
                foreach(string s3 in arr)
                {
                    if(s2.ToLower().Equals(s3.ToLower()))
                    {
                        c++;
                        
                    }
                    if(c > l)
                    {
                        l = c;
                        temp = s3;
                    }
                }
            }
            Console.WriteLine(temp + " " + l);
        }
        static void Main(string[] args)
        {
            string str = "Im mandar madmn monkey mandatory mandar im madmn im";
            HighFreqChar(str);
           // LongWord(str);
            //HighFreqWord(str);
        }
    }
}
