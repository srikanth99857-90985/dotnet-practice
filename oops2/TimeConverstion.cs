using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    public class TimeConverstion
    {
        public void TimeConversion1()
        {
            string time12HourFormat = "07:05:45PM";

            string period = time12HourFormat.Substring(time12HourFormat.Length-2);
            string timeWithoutPeriod = time12HourFormat.Substring(0, time12HourFormat.Length - 2);

            string[] parts = timeWithoutPeriod.Split(':');
            int hour = int.Parse(parts[0]);
           if(hour == 12)
            {
                hour = 0;
            }
            if (period == "PM")
            {
                hour += 12;
            }
            string time24HourFormat = $"{hour:D2}:{parts[1]}:{parts[2]}";
            Console.WriteLine(time24HourFormat);
        }
    }
}
