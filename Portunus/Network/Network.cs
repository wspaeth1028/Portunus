using System;
using System.IO;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portunus
{
    class Network
    {
        private static string LocalAddress = Directory.GetCurrentDirectory();
        private static string nl = Environment.NewLine;

        private static string Corp = "Corp";
        private static string Secure = "Secure";
        private static string[] CorpServers = ConfigurationSettings.AppSettings["CorporateServers"].Split(',');
        private static string[] SecureServers = ConfigurationSettings.AppSettings["SecureServers"].Split(',');
        private static bool ShouldBeSecure = false;
        private static bool ShouldBeCorp = false;

        private static bool IsSecure { get; set; }
        private static bool IsCorp { get; set; }
        public static string CorpSecure
        {
            get
            {
                if (IsSecure)
                {
                    return Secure;
                }
                else if (IsCorp)
                {
                    return Corp;
                }
                else
                {
                    return "";
                }
            }
        }


        public static void SelectNetwork()
        {
            if(LocalAddress.Contains(CorpServers[0]) || LocalAddress.Contains(CorpServers[1]))
            {   //Test if program is living on Corporate Network
                IsCorp = true;
                IsSecure = false;
            }
            else if(LocalAddress.Contains(SecureServers[0]) || LocalAddress.Contains(SecureServers[1]))
            {   //Test if program is living on Secure Network
                IsSecure = true;
                IsCorp = false;
            }
            else
            {   //Look at Network.csv to see what network the program is configured to 
                ShouldBeCorp = CSV.GetNetwork(Corp);
                ShouldBeSecure = CSV.GetNetwork(Secure);

                try
                {   //If Network.csv is configured correctly, this should find what network program is on
                    if (ShouldBeCorp)
                    {
                        IsCorp = new Ping().Send(CorpServers[0]).Status == IPStatus.Success;
                        IsSecure = false;
                    }
                    else if (ShouldBeSecure)
                    {
                        IsSecure = new Ping().Send(SecureServers[0]).Status == IPStatus.Success;
                        IsCorp = false;
                    }
                }
                catch(PingException Pe1)
                {
                    try
                    {   //If Network.csv is configured incorrectly, this should find what network program is on
                        //Also changes Network.csv to be configured correctly.
                        if (!ShouldBeCorp)
                        {   
                            IsCorp = new Ping().Send(CorpServers[0]).Status == IPStatus.Success;
                            IsSecure = false;
                            CSV.SetNetwork(Corp, IsCorp);
                            CSV.SetNetwork(Secure, IsSecure);
                        }
                        else if (!ShouldBeSecure)
                        {
                            IsSecure = new Ping().Send(SecureServers[0]).Status == IPStatus.Success;
                            IsCorp = false;
                            CSV.SetNetwork(Corp, IsCorp);
                            CSV.SetNetwork(Secure, IsSecure);
                        }
                    }
                    catch(PingException Pe2)
                    {
                        throw new PingException(Pe2.Message);
                    }
                }
            }   
        }

    }
}
