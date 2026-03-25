using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
   public  abstract class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Salary { get; set; }
        public  void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Salary: {Salary}");
        }

        public abstract decimal CalculateBonus(decimal amount);


    }
}
