using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
  
    public class EventExample
    {
        public event Action Click;

        public void buttonclick()
        {
            Console.WriteLine("Button Clicked");

            Click?.Invoke();
        }

    }
    public class Notification
    {
        

        public void SendSMS()
        {
            Console.WriteLine("SMS Sent");
        }

    }
}
