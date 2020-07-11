using FTLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace FTLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {

            if(db == DatabaseType.sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == DatabaseType.text)
            {
                //TODO set up text connection ?
                throw new InvalidOperationException();
            }
        }

        //public static string CnnString(string name)
        //{
        //    //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        //}
    }


}
