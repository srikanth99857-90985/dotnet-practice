using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class FuncandPredicatedelegate
    {

        public int calculate(int a, int b,Func<int,int,int> operation)
        {
            return operation(a,b);
        }
            public bool IsEven(int number, Predicate<int> condition)
            {
                return condition(number);
        }

        public int add(int x, int y)
        {
            return x + y;
        }
            public bool isEvenNumber(int number)
            {
                return number % 2 == 0;
            }
    }
}
