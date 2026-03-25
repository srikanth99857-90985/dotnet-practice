using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public  class CompareTriplet
    {
       public void CompareTriplet1()
        {
            int[] a = { 5, 6, 7 };
            int[] b = { 3, 6, 10 };
            int aliceScore = 0;
            int bobScore = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    aliceScore++;
                }
                else if (a[i] < b[i])
                {
                    bobScore++;
                }
            }
          
            Console.WriteLine($"Alice's score: {aliceScore}");
            Console.WriteLine($"Bob's score: {bobScore}");
        }
    }
}
