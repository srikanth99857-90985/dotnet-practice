using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public abstract class Abstraction
    {
        public abstract void Show();


    }
    public class DerivedAbstraction : Abstraction
    {
        public override void Show()
        {
            Console.WriteLine("This is the implementation of the abstract method in the derived class.");
        }

    }


    public interface IAbstraction
    {
        void Show();

    }
    public class DerivedInterface : IAbstraction
    {
        public void Show()
        {
            Console.WriteLine("This is the implementation of the interface method in the derived class.");
        }

    }
}