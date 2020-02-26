using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Diagnostics;
using MobileWebApiLibrary;
using MobileWebApiLibrary.Controllers;

namespace mConstruct_WebApi.Controllers
{
    public class mConstructErrorController : ErrorController
    {     
        protected override void logError(IExceptionHandlerPathFeature feature)
        {
            try
            {
                //create a event log source if not present
                if (!EventLog.SourceExists(ApiLoggingKeys.mConstructApi.ToString()))
                    EventLog.CreateEventSource(ApiLoggingKeys.mConstructApi.ToString(), string.Format("{0}Log", ApiLoggingKeys.SessionApi.ToString()));

                //create new log instance
                EventLog myLog = new EventLog();

                //point to session api source
                myLog.Source = ApiLoggingKeys.mConstructApi.ToString();

                // Write an informational entry to the event log.
                string message = string.Format("Message : {0}\nStacktrace : {1}", feature?.Error.Message, feature?.Error.StackTrace);
                myLog.WriteEntry(message, EventLogEntryType.Error);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Event Log Error : {0}", ex.StackTrace);
            }
        }
    }
}