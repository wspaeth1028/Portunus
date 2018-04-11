using System;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portunus
{
    class Program
    {
        static void Main(string[] args)
        {
            Network.SelectNetwork();
            DataManager.IsServerConnected();

            List<MoveConfig> MoveConfigs = MoveConfig.MoveConfigs();

            foreach(MoveConfig MoveConfig in MoveConfigs)
            {
                //PrePostProcess.Call(MoveConfig.DirPostProcessExe);
                //Using Open Source Nuget Package SSH.NET by Renci
                using (var sftp = new Renci.SshNet.SftpClient(SFTP.host, SFTP.user, SFTP.pass))
                {
                    sftp.Connect();
                    var files = sftp.ListDirectory(MoveConfig.DirSFTP);

                    foreach (var file in files)
                    {
                        string remoteFileName = file.Name;
                        if (!file.Name.StartsWith(".") && (file.LastWriteTime.Date == DateTime.Today))
                        {
                            using (Stream file1 = File.OpenWrite(MoveConfig.DirSFTP + remoteFileName))
                            {
                                //sftp.DownloadFile(remoteDir + remoteFileName, file1);
                                break;
                            }
                        }
                    }   //foreach fileInSFTP
                }   //using
            }   //foreach moveConfig
        }   //Main()
    }   //Class Program
}   //Namespace Portunus
