using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public interface ICustomer
    {
        string Print();
    }

    public interface IOrder
    {
        string Print();
    }

    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.Print()
        {
            return "Customer Details";
        }

        string IOrder.Print()
        {
           return "Order details";
        }
    }
}
