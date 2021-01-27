using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

    public class SqliteDataAccess : DataAccess  // 3. Note that 'SqliteDataAccess' creates an error
    {

        public override void LoadData(string sql)    // 4. We have to include 'override'. It overrides and makes implementation possible
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)   // 4a. We have to include 'override' and above Error desappears. It overrides and makes implementation possible
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
