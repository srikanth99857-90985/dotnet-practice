using System;
using System.Collections.Generic;
using System.Linq;

class LinqExamples
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 2, 3, 4 };

        var distinctNumbers = numbers.Distinct();

        foreach (var num in distinctNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
