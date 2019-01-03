using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
namespace CrashReportLibrary
{
    public static class AppCenterStart
    {
        public static void Start(string ConfigEnv , string Country)
        {
            AppCenter.Start(CrashKey.GetKey(ConfigEnv, Country),typeof(Crashes));
        }
    }
}
