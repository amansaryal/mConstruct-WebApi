using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MobileWebApiLibrary;
using MobileWebApiLibrary.Middlewares;
using System;
using System.Diagnostics;

namespace mConstruct_WebApi.Middlewares
{
    public class MyExceptionHandlerAndLoggerMiddleware : ExceptionHandlerAndLoggerMiddleware
    {
        public MyExceptionHandlerAndLoggerMiddleware(RequestDelegate next, ILoggerFactory logFactory, IHostingEnvironment webHostEnvironment) : base(next, logFactory, webHostEnvironment)
        {
        }

        protected override void logError(HttpContext httpContext)
        {
            var feature = httpContext.Features.Get<IExceptionHandlerPathFeature>();

            try
            {
                //create a event log source if not present
                if (!EventLog.SourceExists(ApiLoggingKeys.mConstructApi.ToString()))
                    EventLog.CreateEventSource(ApiLoggingKeys.mConstructApi.ToString(), string.Format("{0}Log", ApiLoggingKeys.mConstructApi.ToString()));

                //create new log instance
                EventLog myLog = new EventLog();

                //point to mConstruct api source
                myLog.Source = ApiLoggingKeys.mConstructApi.ToString();

                // Write an informational entry to the event log.
                string message = string.Format("Message : {0}\nStacktrace : {1}", feature?.Error.Message, feature?.Error.StackTrace);
                myLog.WriteEntry(message, EventLogEntryType.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Event Log Error : {0}", ex.StackTrace);
            }
        }
    }
}