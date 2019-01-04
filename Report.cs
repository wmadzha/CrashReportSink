using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Crashes;
namespace CrashReportLibrary
{
    public static class Report
    {
        // Overload For Withuot Error Params
        public static void SendReport(Exception ex)
        {
            Crashes.TrackError(ex);
        }
        // Overload For Some Addition Params
        public static void SendReport(Exception ex , Dictionary<string,string> ErrorParams)
        {
            Crashes.TrackError(ex, ErrorParams);
        }
    }
}
