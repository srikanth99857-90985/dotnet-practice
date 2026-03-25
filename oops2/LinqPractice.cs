using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class LinqPractice
    {
        public void Top3smallest()
        {
            var numbers = new List<int> { 5, 2, 9, 1, 5, 6 };
            var reult = numbers.Distinct().OrderBy(x => x).Take(3);
            foreach (var item in reult)
            {
                Console.WriteLine(item);
            }
        }
        public void EachDepartmentHighestSalary()
        {
            var employees = new List<Employee>
            {
             new Employee { Name = "A", Salary = 5000, Dept = "IT" },
             new Employee { Name = "B", Salary = 7000, Dept = "IT" },
             new Employee { Name = "C", Salary = 6000, Dept = "HR" },
             new Employee { Name = "D", Salary = 8000, Dept = "HR" },
             new Employee { Name = "D", Salary = 9000, Dept = "MEC" },
             new Employee { Name = "D", Salary = 8000, Dept = "Mech" },
             new Employee { Name = "D", Salary = 8000, Dept = "CSC" }
            };

            var reult = employees.GroupBy(e => e.Dept)
                  .Select(g => g.OrderByDescending(e => e.Salary).First());
            foreach (var employee in reult)
            {
                Console.WriteLine($"Department: {employee.Dept}, Name: {employee.Name}, Salary: {employee.Salary}");
            }
        }
    }
}
