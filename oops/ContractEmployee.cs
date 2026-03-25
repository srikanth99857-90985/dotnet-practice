using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class ContractEmployee : Employee
    {

        
        public override decimal CalculateBonus(decimal amount)
        {
            return  0.1m * amount;
        }
    }
}
