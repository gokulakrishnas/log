using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
   public interface ilog
    {
        void Debug(object message);
        void Info(object message);
        void Warn(object message);
        void Error(object message);
        void Fatal(object message);
        //void Trace(object message);
    }
}
