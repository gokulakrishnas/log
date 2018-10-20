using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class logger:ilog
    {
        private static ILog Log { get; set; }

        static logger()
        {
            Log = LogManager.GetLogger(typeof(Logger));
        }

        public  void Error(object msg)
        {
            Log.Error(msg);
        }
        public  void Debug(object msg)
        {
            Log.Debug(msg);
        }
        public  void Error(object msg, Exception ex)
        {
            Log.Error(msg, ex);
        }

        public  void Error(Exception ex)
        {
            Log.Error(ex.Message, ex);
        }

        public  void Info(object msg)
        {
            Log.Info(msg);
        }

       

        public  void Fatal(object message)
        {
            Log.Fatal(message);
        }

        public void Warn(object message)
        {
            Log.Warn(message);
        }

      

       
    }
}