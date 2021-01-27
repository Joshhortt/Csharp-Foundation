using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

    // 1. Three methods that just do Console.Writeline():
    public class SqliteDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
