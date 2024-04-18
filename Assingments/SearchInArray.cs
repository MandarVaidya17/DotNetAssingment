using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class SearchInArray
    {
        public bool SearchEle(string[] arr,string element)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (element == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            string[] name = { "Pablo", "Amar", "Sagar", "Aish", "Sandesh" };   
            SearchInArray obj= new SearchInArray();
           if( obj.SearchEle(name, "Amar"))
            {
                Console.WriteLine("Element is in array");

            }else
            {
                Console.WriteLine("Element is not in array");
            }
        }
    }
}
