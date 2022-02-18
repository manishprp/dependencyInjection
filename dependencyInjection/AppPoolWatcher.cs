using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    class AppPoolWatcher
    {

        // Handle to EventLog writer to write to the logs
        INofificationAction action = null;
        //public AppPoolWatcher (INofificationAction instanceOF)
        //{
        //    this.action = instanceOF;
        //}

        //// This function will be called when the app pool has problem
        public static void Main(String[] args)
        {
            AppPoolWatcher watcher = new AppPoolWatcher();
            watcher.Notify(new EmailSender(),"This is done ");
        }
        public void Notify(INofificationAction instanceOF, string message)
        {
            if (action == null)
            {
                // Here we will map the abstraction i.e. interface to concrete class 
                action = instanceOF;
            }
            action.ActOnNotification(message);
        }
    }
}
