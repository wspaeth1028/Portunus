using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portunus
{
    class FileNameConfig
    {
        public int FileMoveID { get; private set; }
        public int MoveID { get; private set; }
        public string Extension { get; private set; }

        public static List<FileNameConfig> FileNameConfigs(int MoveID)
        {   //Factory Method to build list of this type of objects
            DataSet AllFileNameConfig = DataManager.GetPortunusFileNameData(MoveID);

            List<FileNameConfig> MoveConfigs = new List<FileNameConfig>();
            foreach (DataRow FileNameConfigRow in AllFileNameConfig.Tables[0].Rows)
            {
                MoveConfigs.Add(new FileNameConfig(FileNameConfigRow));
            }
            return MoveConfigs;
        }

        private FileNameConfig(DataRow FileNameConfigRow)
        {
            FileMoveID = (int)FileNameConfigRow["IDMove"];
            MoveID = (int)FileNameConfigRow["Description"];
            Extension = FileNameConfigRow["DirLocal"].ToString();
        }

        private FileNameConfig() { }
    }
}
