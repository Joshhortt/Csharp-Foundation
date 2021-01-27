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

            // 3. Comment out this block of code 
            //List<IDataAccess> databases = new List<IDataAccess>()
            //{
            //    new SqlDataAccess(),
            //    new SqliteDataAccess()
            //};

            
            //foreach (var db in databases)
            //{
            //    db.LoadConnectionString("demo");
            //    db.LoadData("select * from table");
            //    db.SaveData("insert into table");
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
