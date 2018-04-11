using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Portunus
{
    static class PrePostProcess
    {
        public static void CallPreProcess(MoveConfig ConfigObj)
        {
            switch(ConfigObj.PreProcess)
            {
                case "PortunusKeySecure":
                    break;
                case "":
                    break;
            }
        }

        
        public static void CallPostProcess(MoveConfig ConfigObj)
        {
            switch(ConfigObj.PostProcess)
            {
                case "PortunusKeySecure":
                    break;
                case "":
                    break;
            }
        }
    }
}
