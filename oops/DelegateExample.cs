using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class DelegateExample
    {

        public delegate int calculate(int x,int y);

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int calculateResult(int x, int y, calculate operation)
        {
            return operation(x, y);
        }


    }
}
