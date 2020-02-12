using Microsoft.AspNetCore.Diagnostics;
using System;
using System.Diagnostics;

namespace MobileWebApiLibrary.Controllers
{
    public class SessionErrorController : ErrorController
    {
        protected override void logError(IExceptionHandlerPathFeature feature)
        {
            try
            {
                //create a event log source if not present
                if (!EventLog.SourceExists(ApiLoggingKeys.SessionApi.ToString()))
                    EventLog.CreateEventSource(ApiLoggingKeys.SessionApi.ToString(), string.Format("{0}Log", ApiLoggingKeys.SessionApi.ToString()));

                //create new log instance
                EventLog myLog = new EventLog();

                //point to session api source
                myLog.Source = ApiLoggingKeys.SessionApi.ToString();

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
