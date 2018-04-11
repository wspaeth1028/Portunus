using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace Portunus
{
    static class DataManager
    {
        private static string ConnectionString
        {
            get
            {
                if (Network.CorpSecure == "Secure")
                {   //connection string for CODATASRV, but with IP rather than name
                    return ConfigurationSettings.AppSettings["SecureConnectionString"];
                }
                else if (Network.CorpSecure == "Corp")
                {
                    return ConfigurationSettings.AppSettings["CorpConnectionString"];
                }
                else
                {
                    return "";
                }
            }
        }   //ConnectionString

        public static bool IsServerConnected()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
                catch (SqlException ex)
                {
                    //MessageBox.Show("Unable to open database");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }   //using
        }   //IsServerConnected()

        public static DataSet GetPortunusMoveData()
        { 
            DataSet ds = new DataSet();
            string sqlString = string.Format("SELECT * FROM PortunusMoveConfig where SecureCorp = '{0}'", Network.CorpSecure);
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter(sqlString, connection))
            {
                try
                {
                    connection.Open();
                    try
                    {
                        Adapter.Fill(ds);
                    }
                    catch(SqlException ex)
                    {
                        //MessageBox.Show("Unable to get Atlas Record: " + AtlasID, "Database Connection Error");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                catch (SqlException)
                {
                    //MessageBox.Show("Unable to open database");
                }
            }   //using
                
            return ds;
        }   //GetPortunusMoveData()

        public static DataSet GetPortunusFileNameData(int MoveID)
        {
            DataSet ds = new DataSet();
            string sqlString = string.Format("SELECT * FROM PortunusFileNameConfig where IDMove = '{0}'", MoveID);

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter(sqlString, connection))
            {
                try
                {
                    connection.Open();
                    try
                    {
                        Adapter.Fill(ds);
                    }
                    catch (SqlException ex)
                    {
                        //MessageBox.Show("Unable to get Atlas Record: " + AtlasID, "Database Connection Error");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                catch (SqlException)
                {
                    //MessageBox.Show("Unable to open database");
                }
            }   //using

            return ds;
        }   //GetPortunusMoveData()

    }   //Class DataManager
}   //Namespace Portunus
