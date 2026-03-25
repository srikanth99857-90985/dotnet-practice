using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Encapsulation
    {

        private decimal BankBalance;
       
        public void SetBankBalance(decimal balance)
        {
            BankBalance = balance;
        }

        public decimal GetBankBalance()
        {
            return BankBalance;
        }

        public void Withdraw( decimal amount)
        {
                if (amount <= BankBalance)
                {
                BankBalance -= amount;
                    
                }
                
          
        }
    }
}
