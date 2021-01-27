using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqlDataAccess : DataAccess   // 5. Note that 'SqlDataAccess' creates an error
    {

        public override void LoadData(string sql)   // 6. We have to include 'override'. It overrides and makes implementation possible
        {
            Console.WriteLine("Loading Microsoft SQL Data"); 
        }

        public override void SaveData(string sql)   // 6a. We have to include 'override' and above Error desappears. It overrides and makes implementation possible
        {
            Console.WriteLine("Saving data to Microsoft SQL Server");  
        }
    }
}
