using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net.Core;
using log4net;
using log4net.Repository.Hierarchy;
using log4net.Appender;
using log4net.Layout;
using log4net.Filter;

namespace WebApplication3
{
    public class manager:ilog
    {
        private ILog _logger;
        public static ILog  getlogger(string name)
        {
            string filterlevels = "AID|STF";
            string filenames = "C://NLog//AID_Log|C://NLog//STF_log|C://NLog//GIM_log";
            string LevelsToFilter = "Debug,Error|Error|Fatal";
            string[] levelsToFilters = LevelsToFilter.Split('|');
            string[] filterleveling = filterlevels.Split('|');
            string[] filenaming = filenames.Split('|');
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            Logger newLogger = hierarchy.GetLogger(name) as Logger;
            newLogger.Additivity = false;
            hierarchy.Configured = true;
            var filter = new LevelRangeFilter();
            var filter1 = new LevelRangeFilter();
            var filter2 = new LevelRangeFilter();

            for (int i = 0; i < filterleveling.Length; i++)
            {
                if (newLogger.Name.Equals(filterleveling[i]))
                {
                    var roller = new RollingFileAppender();
                    PatternLayout pl = new PatternLayout();
                    pl.ConversionPattern = "%d [%2%t] %-5p [%-10c]   %m%n%n";
                    pl.ActivateOptions();
                    roller.Name = filterleveling[i].ToString();
                    roller.AppendToFile = true;
                    roller.File = filenaming[i].ToString() + ".log";

                    roller.Layout = pl;

                    string[] LevelsToFiltersArr = levelsToFilters[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string levels in LevelsToFiltersArr)
                    {
                        if ("INFO".Equals(levels.ToUpper()))
                        {
                         
                            filter.LevelMax = Level.Info;
                            filter.LevelMin = Level.Info;
                          
                            roller.AddFilter(filter);
                           
                        }
                        if ("DEBUG".Equals(levels.ToUpper()))
                        {
                         
                            filter.LevelMax = Level.Debug;
                            filter.LevelMin = Level.Debug;
                            filter.Next = filter;
                            roller.AddFilter(filter);
                        }
                        if ("ERROR".Equals(levels.ToUpper()))
                        {
                            filter.LevelMax = Level.Error;
                            filter.LevelMin = Level.Error;
                           
                            roller.AddFilter(filter);
                        }
                        if ("FATAL".Equals(levels.ToUpper()))
                        {
                            filter.LevelMax = Level.Fatal;
                            filter.LevelMin = Level.Fatal;
                           
                            roller.AddFilter(filter);
                        }
                        if ("WARN".Equals(levels.ToUpper()))
                        {
                            filter.LevelMax = Level.Warn;
                            filter.LevelMin = Level.Warn;
                            
                            roller.AddFilter(filter);
                        }
                        filter.Next = filter;
                        roller.AddFilter(filter);
                      
                    }
                    
                    newLogger.AddAppender(roller);
                    roller.ActivateOptions();


                }  
                
            }
            return LogManager.GetLogger(name);

            
        }
      
        public void Debug(object message)
        {
            _logger.Debug(message);
        }

        public void Error(object message)
        {
            _logger.Error(message);
        }

        public void Fatal(object message)
        {
            _logger.Fatal(message);
        }

        public void Info(object message)
        {
            _logger.Info(message);
        }

     

        public void Warn(object message)
        {
            _logger.Warn(message);
        }
    }
}