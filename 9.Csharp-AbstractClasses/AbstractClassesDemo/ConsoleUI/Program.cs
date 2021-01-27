// Abstract class: Main objective here is to show the difference between a 'Base class' and a 'Interface class'.
// Console Aplication with a class Library with two Data Access classes (they are juts simulators).

using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

			// 1. Uncomment the code below and remove 'I' from DataAccess

			List<DataAccess> databases = new List<DataAccess>()
			{
				new SqlDataAccess(),
				new SqliteDataAccess()
			};


			foreach (var db in databases)
			{
				db.LoadConnectionString("demo");
				db.LoadData("select * from table");
				db.SaveData("insert into table");
				Console.WriteLine();
			}

			Console.ReadLine();
        }
    }
}
/*OUTPUT that works fine now
Load Connection String
Loading Microsoft SQL Data
Saving data to Microsoft SQL Server

Load Connection String
Loading SQLite Data
Saving data to SQLite
 */