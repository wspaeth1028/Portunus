using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Portunus
{
    class CSV
    {
        private static string LocalAddress = Directory.GetCurrentDirectory();
        private static string NetworkFile = @"\Network.csv";
        private const char FieldSeparator = ',';

        private Dictionary<Tuple<int, int>, string> _data;
        private int _rows;
        private int _cols;

        private int Rows { get { return _rows; } }
        private int Cols { get { return _cols; } }

        private CSV()
        {
            Clear();
        }

        private void Clear()
        {
            _rows = 0;
            _cols = 0;
            _data = new Dictionary<Tuple<int, int>, string>();
        }

        private void Open(StreamReader stream, char delim = ',')
        {
            string line;
            int col = 0;
            int row = 0;

            Clear();

            while ((line = stream.ReadLine()) != null)
            {
                if (line.Length > 0)
                {
                    string[] values = line.Split(delim);
                    col = 0;
                    foreach (var value in values)
                    {
                        this[col, row] = value;
                        col++;
                    }
                    row++;
                }
            }
            stream.Close();
        }

        private void Save(StreamWriter stream, char delim = ',')
        {
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _cols; col++)
                {
                    stream.Write(this[col, row]);
                    if (col < _cols - 1)
                    {
                        stream.Write(delim);
                    }
                }
                stream.WriteLine();
            }
            stream.Flush();
            stream.Close();
        }

        private string this[int col, int row]
        {
            get
            {
                try
                {
                    return _data[new Tuple<int, int>(col, row)];
                }
                catch
                {
                    return "";
                }
            }

            set
            {
                _data[new Tuple<int, int>(col, row)] = value.ToString().Trim();
                _rows = Math.Max(_rows, row + 1);
                _cols = Math.Max(_cols, col + 1);
            }
        }


        public static void SetNetwork(string Location, bool Value)
        {
            CSV WriteCSV = new CSV();
            string sLocalAddress = System.IO.Directory.GetCurrentDirectory();
            string sLocationFile = @"\Network.csv";
            string filepath = sLocalAddress + sLocationFile;
            try
            {
                using (StreamReader SR = new StreamReader(filepath))
                {
                    WriteCSV.Open(SR);

                    for (int row = 0; row < WriteCSV.Rows; row++)
                    {
                        if (WriteCSV[0, row] == Location)
                        {
                            WriteCSV[1, row] = Value.ToString();
                            break;
                        }
                    }
                }
            }   //try
            catch (IOException Ex)
            {
                throw new IOException(Ex.Message);
                //MessageBox.Show(Ex.Message + "Could not find CSV: " + nl + filepath);
            }  

            try
            {
                using (StreamWriter SW = new StreamWriter(filepath))
                {
                    WriteCSV.Save(SW);
                }
            }   
            catch (IOException Ex)
            {
                throw new IOException(Ex.Message);
                //MessageBox.Show(Ex.Message + "Could not find CSV: " + nl + filepath);
            }   
        }   //SetLocation()


        public static bool GetNetwork(string Network)
        {
            string filepath = LocalAddress + NetworkFile;
            try
            {
                using (StreamReader SR = new StreamReader(filepath))
                {
                    while (!SR.EndOfStream)
                    {
                        List<string> CSValues = SR.ReadLine().Split(FieldSeparator).ToList();
                        //CSValues is zero based and CSValues[i] pulls back the ith element in a row
                        if (Network == CSValues[0])
                            return Convert.ToBoolean(CSValues[1]);
                        else
                            continue;
                    }
                }
            }   //try
            catch (IOException Ex)
            {
                throw new IOException(Ex.Message);
                //MessageBox.Show(Ex.Message + "Could not find CSV: " + nl + filepath);
            }   
            return false;
        }   //GetNetwork()
    }
}
