using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class LargestCommonPrefix
    {

        public string LargestCommonPrefix1() {
            string[] str = { "flower", "flow", "flight" };
            for (int i = 0; i < str[0].Length; i++)
            {
                char c = str[0][i];

                for (int j = 1; j < str.Length; j++)
                {

                    if (i >= str[j].Length || str[j][i] != c)

                        return str[0].Substring(0, i);


                }
            }
            return string.Empty;

        }

    }
}

