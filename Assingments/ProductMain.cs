using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assingments
{
    public class ProductMain
    {
        static void Main(string[] args)
        {
            Product[] pr=new Product[5];
            pr[0] = new Product();
            pr[0].Name = "Sugar";
            pr[0].Price = 48;
            pr[0].Code = 112;

            pr[1] = new Product();
            pr[1].Name = "Oil";
            pr[1].Price = 109;
            pr[1].Code = 113;

            pr[2] = new Product();
            pr[2].Name = "Masala";
            pr[2].Price = 10;
            pr[2].Code = 114;

            pr[3] = new Product();
            pr[3].Name = "Fan";
            pr[3].Price = 980;
            pr[3].Code = 115;

            pr[4] = new Product();
            pr[4].Name = "Bulb";
            pr[4].Price = 190;
            pr[4].Code = 116;


            for(int i = 0; i < pr.Length; i++)
            {
                Console.WriteLine($"ID={pr[i].Code} Name={pr[i].Name} Price={pr[i].Price}");
            }

        }
    }
}
