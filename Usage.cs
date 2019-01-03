using CrashReportLibrary;
namespace ClientUsage
{
    public class Client
    {
        public void OnStart()
        {
            AppCenterStart.Start(Config.Env, Config.Country);
        }
    }
}
