using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class ExtensionMethod
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }

    public static class ExtensionMethodClass
    {
        public static string Welcome(this ExtensionMethod extension)
        {
           return $"Welcome to {extension.FirstName}, {extension.LastName}";
        }
    }
}
