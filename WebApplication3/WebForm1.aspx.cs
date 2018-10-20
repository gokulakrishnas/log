using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
            
        protected void Page_Load(object sender, EventArgs e)
        {
            //WebApplication3.logger.ConfigureNlog(new WebApplication3.Loggerdata()
            //{
               
               
            //    Filename = "C://NLog//AID_Log|C://NLog//STF_Log|C://NLog//GIM_Log",
            //    Filterlevel = "AID|STF|GIM"
            ////LevelsToFilter = levelsToFilter,
               
            //});

        }
        protected void button1_Click(object sender, EventArgs e)
        {
         ILog op = manager.getlogger("AID");

            //op.Info("info");
            //op.Error("fatal");
            //op.Warn(
            op.Debug("kn");
            op.Error("aid info");
            op.Fatal("fat");
            
        }
    }
}