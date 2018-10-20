using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace WebApplication3
{
    public partial class _Default : Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            //hierarchy.Root.RemoveAllAppenders(); /*Remove any other appenders*/

            //FileAppender fileAppender = new FileAppender();
            //fileAppender.AppendToFile = true;
            //fileAppender.LockingModel = new FileAppender.MinimalLock();
            //fileAppender.File = Server.MapPath("/") + "log.txt";
            //PatternLayout pl = new PatternLayout();
            //pl.ConversionPattern = "%d [%2%t] %-5p [%-10c]   %m%n%n";
            //pl.ActivateOptions();
            //fileAppender.Layout = pl;
            //fileAppender.ActivateOptions();

            //log4net.Config.BasicConfigurator.Configure(fileAppender);

            ////Test logger
            //ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //log.Debug("Testing!");
        }
    }
}