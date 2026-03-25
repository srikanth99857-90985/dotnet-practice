using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class TwoSumProblem
    {

        public void TwoSum()
        {

            int[] num = { 1, 2, 3, 4, 5, 6 };


            var result = twoSumProblem(num);
          Console.WriteLine($"[{result[0]}] [{result[1]}] ");


        }

        public int[] twoSumProblem(int[] array)
        {
            int target = 11;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {

                int x = target - array[i];
                if (dict.ContainsKey(x))
                {

                    return new int[] {dict[ x], i };
                }
                dict[array[i]] =i;
            }
            return new int[0];

        }

    }
}
