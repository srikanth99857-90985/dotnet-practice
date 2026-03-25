using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class ReverseOfString
    {

        public void ReverseOfString1()
        {
            string input = "Hello, World!";
            StringBuilder reversed = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            Console.WriteLine(reversed.ToString());

        }
    }
}
