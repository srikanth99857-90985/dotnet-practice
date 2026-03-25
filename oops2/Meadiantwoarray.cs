using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class Meadiantwoarray
    {

        public void CalculateMedian()
        {
            int[] num1 = { 1, 2, 3, 4, 5 };
            int[] num2 = { 1, 2, 3, 4, 5 };
            int k = 0;
            int[] num = new int[num1.Length + num2.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                num[k] = num1[i];
                k++;
            }

            for (int j = 0; j < num2.Length; j++)
            {
                num[k] = num2[j];
                k++;
            }

            int sum = 0;

            for (int z = 0; z < num.Length; z++)
            {
                sum = sum + num[z];
            }

            Console.WriteLine(sum / (double)num.Length);
        }
    }
}