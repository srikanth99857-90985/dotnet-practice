using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class RaceConditionExample
    {

        public int Counter = 0;

        List<int> ints = new List<int> ();

        public void Print()
        {

            for (int i = 0; i < 1000000; i++)
            {
                ints.Add(i);
            }
            Parallel.ForEach(ints, i => { Interlocked.Increment(ref Counter); });

            Console.WriteLine($"Counter: {Counter}");

        }



    }
}
