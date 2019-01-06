

namespace CrashReportLibrary
{
    public static class CrashKey
    {
        public static string GetKey(string Env , string Country)
        {
            // Best practice is to host the key somewhere in a data store . called in a secure manner with both parameters . 
            if(Env == Constant.Env.BlueGreen)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.Dev)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.TestUI)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.Pilot)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.TestBE)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.Live && Country == Constant.Country.De)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.Live && Country == Constant.Country.My)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.Live && Country == Constant.Country.Ne)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.Live && Country == Constant.Country.Fr)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            if (Env == Constant.Env.Live && Country == Constant.Country.Sg)
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
            else
                return "SampleKey-72b3-41be-b01a-2152d70448c7";
        }
    }
}
