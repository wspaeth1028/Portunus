using System.Configuration;

namespace Portunus
{
    static class SFTP
    {
        private static string _host = ConfigurationSettings.AppSettings["sFTPHost"];
        private static string _user = ConfigurationSettings.AppSettings["sFTPUser"];
        private static string _pass = ConfigurationSettings.AppSettings["sFTPPass"];

        public static string host { get { return _host; } }
        public static string user { get { return _user; } }
        public static string pass { get { return _pass; } }
    }
}
