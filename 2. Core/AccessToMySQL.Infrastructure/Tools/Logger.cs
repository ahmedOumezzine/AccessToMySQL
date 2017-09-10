using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using AccessToMySQL.Infrastructure.Constantes;
using System.Configuration;

namespace AccessToMySQL.Infrastructure.Tools
{
    /// <summary>
    /// Types des traces.
    /// </summary>
    public enum TraceType
    {
        Info,
        Warning,
        Error,
        Fatal,
        Debug
    }

    public enum Destination
    {
        Synchro,
        SynchroBack,
    }

    /// <summary>
    /// Summary description for Logger.
    /// </summary>
    public class Logger
    {
        #region Member Variables

        //private static readonly string LOG_TRACE = "Trace";
        private static readonly string LOG_ERROR = "Error";

        private static string loggerFileName = ConfigurationManager.AppSettings[Globals.LOG_FILE_FOLDER];
        private static int nbMaxFile = 5;

        //Int32. ( ConfigurationManager.AppSettings[Globals.NB_FILE_MAX];

        //private static bool isSynchroFileConfigured = false;
        //private static bool isSynchroBackFileConfigured = false;

        private static log4net.Appender.FileAppender synchroFileAppender = null;
        private static log4net.Appender.FileAppender synchroBackFileAppender = null;
        private static ILog synchroLog = null;
        //private static ILog synchroMederiLog = null;
        private static Destination destination = Destination.Synchro;

        #endregion

        #region Methods
        public Logger()
        {

        }

        static Logger()
        {
            ConfigureLogging(destination);
        }

        private static object obj = new object();

        /// <summary>
        /// This method queues up a message to log
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logDestination"></param>
        public static void LogMessage(string message, TraceType traceType)
        {
            lock (obj)
            {
                //ConfigureLogging(destination);
                switch (traceType)
                {
                    case TraceType.Info:
                        Log_Info(message);
                        break;
                    case TraceType.Warning:
                        Log_Warn(message);
                        break;
                    case TraceType.Error:
                        Log_Error(message);
                        break;
                    case TraceType.Fatal:
                        Log_Fatal(message);
                        break;
                    case TraceType.Debug:
                        Log_Debug(message);
                        break;
                    default:
                        break;
                }
            }

        }


        private static void Log_Debug(string message)
        {
            synchroLog.Debug(message);
        }

        private static void Log_Fatal(string message)
        {
            synchroLog.Fatal(message);
        }

        private static void Log_Error(string message)
        {
            synchroLog.Error(message);
        }

        private static void Log_Warn(string message)
        {
            synchroLog.Warn(message);
        }

        private static void Log_Info(string message)
        {
            synchroLog.Info(message);
        }



        /// <summary>
        /// This method is used to configure the loggers required
        /// </summary>
        /// <param name="logDestination"></param>
        private static void ConfigureLogging(Destination logDestination)
        {
            try
            {

                synchroFileAppender = CreateAppender(loggerFileName + "\\" + "Log_Synchro.txt", LOG_ERROR);
                CreateLogger(synchroFileAppender, LOG_ERROR);
                synchroLog = LogManager.GetLogger(LOG_ERROR);

                //isSynchroFileConfigured = true;

            }
            catch
            {

            }
        }

        /// <summary>
        /// This method is used to create the appender
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="appenderName"></param>
        /// <returns></returns>
        private static log4net.Appender.FileAppender CreateAppender(string fileName, string appenderName)
        {
            log4net.Appender.RollingFileAppender fileAppender = new log4net.Appender.RollingFileAppender();
            fileAppender.Encoding = Encoding.UTF8;
            if (!Int32.TryParse(ConfigurationManager.AppSettings[Globals.NB_FILE_MAX], out nbMaxFile))
            {
                nbMaxFile = 5;
            }
            fileAppender.MaxSizeRollBackups = nbMaxFile;
            fileAppender.MaximumFileSize = "10MB";
            log4net.Layout.PatternLayout patternLayOut = new log4net.Layout.PatternLayout();
            patternLayOut.Header = "---Starts Here---" + System.Environment.NewLine;
            patternLayOut.Footer = "---Ends---";
            patternLayOut.ConversionPattern = "%p %date{ISO8601} %t %m%n";
            patternLayOut.ActivateOptions();

            fileAppender.RollingStyle = log4net.Appender.RollingFileAppender.RollingMode.Size;
            fileAppender.DatePattern = "ddMMyyyyhhmm";

            fileAppender.Layout = patternLayOut;
            fileAppender.AppendToFile = true;
            fileAppender.File = fileName;
            fileAppender.Name = appenderName;
            fileAppender.Encoding = Encoding.UTF8;
            fileAppender.ActivateOptions();

            return fileAppender;
        }

        /// <summary>
        /// This method creates the loggers
        /// </summary>
        /// <param name="fileAppender"></param>
        /// <param name="loggerName"></param>
        private static void CreateLogger(log4net.Appender.FileAppender fileAppender, string loggerName)
        {
            log4net.Repository.Hierarchy.Hierarchy hierarchy = (log4net.Repository.Hierarchy.Hierarchy)log4net.LogManager.GetRepository();
            log4net.Repository.Hierarchy.Logger logger = (log4net.Repository.Hierarchy.Logger)hierarchy.GetLogger(loggerName);
            logger.AddAppender(fileAppender);
            hierarchy.Configured = true;
        }


        /// <summary>
        /// This method is used to shut down the logger block.
        /// It should always be called on APPLICATION.EXIT() method.
        /// </summary>
        public static void ShutDownLogger()
        {
            if (synchroFileAppender != null)
                synchroFileAppender.Close();
            if (synchroBackFileAppender != null)
                synchroBackFileAppender.Close();
        }
        #endregion
    }
}
