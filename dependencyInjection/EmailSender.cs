using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    class EmailSender : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine(message + " Using email Sender class");
        }
    }
}
