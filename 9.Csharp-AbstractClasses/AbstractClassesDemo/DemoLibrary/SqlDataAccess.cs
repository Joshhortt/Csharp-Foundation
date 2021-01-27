using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqlDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)  
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";  // 5. returns testConnectionString
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQL Data"); // 6. Loads Data (simulated)
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");  // 7. Saves data to Sql server (simulated)
        }
    }
}
