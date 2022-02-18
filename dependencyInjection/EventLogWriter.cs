using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    class EventLogWriter : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine(message+  " using EventLoggerClass");
        }
    }
}
