using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class Plusminus
    {


        public void PlusMinus1()
        {
            int[] arr = { -4, 3, -9, 0, 4, 1 };

            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            foreach (var item in arr)
            {


                if (item > 0)
                {
                    positiveCount++;
                }
                else if (item < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;


                }
            }

            var total = arr.Length;

            Console.WriteLine((float)positiveCount / total);
            Console.WriteLine((float)negativeCount / total);
            Console.WriteLine((float)zeroCount / total);



        }
    }
}