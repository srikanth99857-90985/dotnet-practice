using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class OpenClosedPrinciple
    {
        public void AddDiscount(string employeeType, double discount)
        {
            if (employeeType =="permanent")
            {
                 discount =0.2* discount;
            }
            else if (employeeType == "Contract")
            {
                discount = 0.1 * discount; // Half discount for clothing
            }
        }
    }

    public interface IEmployee
    {
        double CalculateDiscount(double discount);
    }

    public class PermanentEmployee1 : IEmployee
    {
        public double CalculateDiscount(double discount)
        {
            return 0.2 * discount; // 20% discount for permanent employees
        }
    }
    public class ContractEmployee1: IEmployee
    {
        public double CalculateDiscount(double discount)
        {
            return 0.1 * discount; // 20% discount for permanent employees
        }
    }

}
