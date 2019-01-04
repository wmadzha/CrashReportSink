using CrashReportLibrary;
namespace ClientUsage
{
    public class Client
    {
        public void OnStart()
        {
            AppCenterStart.Start(Config.Env, Config.Country);
        }
        public void Sample()
        {
            try
            {
                int Zeros = 0;
                int temp = 1 / Zeros;
            }
            catch (System.Exception ex)
            {
                // Call The AppCenter CrashReport Helper Like Below
                Report.SendReport(ex);
                // Handle Exception
            }
        }
    }
}
