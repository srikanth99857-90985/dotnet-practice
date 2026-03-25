using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class PermanentEmployee: Employee
    {
    
        public override decimal CalculateBonus(decimal amount)
        {
            return  0.2m *amount;
        }
    }
}
