using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Shopping
    {
        private int Pid;
        private String PName;
        private double Price;
        private int que;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Product id");
            Pid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product Name");
            PName = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            Price= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quentity of product");
            que=Convert.ToInt32(Console.ReadLine());
        }

        public double Bill()
        {
            return Price*que;
        }

        public void Display()
        {
            if (que > 0)
            {
                Console.WriteLine($"pid={Pid} pname={PName} price={Price} quentity={que} Bill={Bill()}");
            }else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
