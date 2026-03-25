using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class MinMaxFunction
    {
        public void MinMaxFunction1()
        {
            int[] numbers = { 3, 5, 1, 8, 2 };
            int min = numbers[0];
            int max = numbers[0];
            int sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }
            Console.WriteLine($"Minimum: {sum-min}");
            Console.WriteLine($"Maximum: {sum-max}");
        }
    }
}
