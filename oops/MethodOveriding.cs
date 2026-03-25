using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class MethodOveriding
    {
        public virtual void Show()
        {
            Console.WriteLine("Base class method");
        }
    }

    public class DerivedClass : MethodOveriding
    {
        public override void Show()
        {
            Console.WriteLine("Derived class method");
        }
    }
    public class ChildClass : DerivedClass
    {
       
    }
}
