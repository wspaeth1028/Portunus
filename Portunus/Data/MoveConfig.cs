using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portunus
{
    class MoveConfig
    {
        public int MoveID { get; private set; }
        public string MoveDescription { get; private set; }
        public string DirLocal { get; private set; }
        public string DirSFTP { get; private set; }
        public string DirBackup { get; private set; }
        public string PreProcess { get; private set; }
        public string PostProcess { get; private set; }
        public string PushPull { get; private set; }
        public List<FileNameConfig> FileNameConfigs { get; private set; }
        //public List<FileNa> Extensions

        public static List<MoveConfig> MoveConfigs()
        {   //Factory Method to build list of this type of objects
            DataSet AllMoveConfig = DataManager.GetPortunusMoveData();

            List<MoveConfig> MoveConfigs = new List<MoveConfig>();
            foreach (DataRow MoveConfigRow in AllMoveConfig.Tables[0].Rows)
            {
                MoveConfigs.Add(new MoveConfig(MoveConfigRow));
            }
            return MoveConfigs;
        }

        private MoveConfig(DataRow MoveConfigRow)
        {
            MoveID = (int)MoveConfigRow["IDMove"];
            MoveDescription = MoveConfigRow["Description"].ToString();
            DirLocal = MoveConfigRow["DirLocal"].ToString();
            DirSFTP = MoveConfigRow["DirSFTP"].ToString();
            DirBackup = MoveConfigRow["DirBackup"].ToString();
            PreProcess = MoveConfigRow["PreProcess"].ToString();
            PostProcess = MoveConfigRow["PostProcess"].ToString();
            PushPull = MoveConfigRow["PushToPullFromSFTP"].ToString();
            FileNameConfigs = FileNameConfig.FileNameConfigs(this.MoveID);
        }
        
        private MoveConfig() { }
    }
}
