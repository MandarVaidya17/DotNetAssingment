using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class SearchInArray
    {
        public void SearchEle(string[] arr,string element)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (element == arr[i])
                {
                    Console.WriteLine(element + " is available in array position " + i);
                }
            }
        }
        static void Main(string[] args)
        {
            string[] name = { "Pablo", "Amar", "Sagar", "Aish", "Sandesh" };   
            SearchInArray obj= new SearchInArray();
            obj.SearchEle(name, "Amar");
        }
    }
}
