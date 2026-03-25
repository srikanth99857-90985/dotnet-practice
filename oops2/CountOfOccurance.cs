using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class CountOfOccurance
    {
        public void CountOfOccurance1()
        {
            string input = "hello world";
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
             StringBuilder result = new StringBuilder();
            foreach (var kvp in charCount)
            {
                result.Append($"{kvp.Key}: {kvp.Value} ");
            }
            Console.WriteLine(result.ToString());
        }
    }
}
