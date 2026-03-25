using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class LiskovViolation
    {

        public virtual void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount}");
        }
    }
    public class CreditCardPayment : LiskovViolation
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class UPIPayment : LiskovViolation
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing UPI payment of {amount}");
        }

    }

    public class Employee1 : LiskovViolation
    {
        public override void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException("Employees cannot process payments");
        }
    }


}
