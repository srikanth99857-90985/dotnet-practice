using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class SecondHighestNumber
    {
        public void SecondHighestNumber1()
        {
            int[] numbers = { 3, 5, 1, 8, 2 };
            int max = int.MinValue;
            int secondMax = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    secondMax = max;
                    max = number;
                }
                else if (number > secondMax && number != max)
                {
                    secondMax = number;
                }
            }
            Console.WriteLine($"Second Highest Number: {secondMax}");
        }
    }
}
