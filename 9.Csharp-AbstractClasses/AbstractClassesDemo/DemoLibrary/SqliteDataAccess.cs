﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

    public class SqliteDataAccess : DataAccess
    {
        // 2. Comment out this Method after copy to DataAccess.

        //public string LoadConnectionString(string name)
        //{
        //    Console.WriteLine("Load Connection String");
        //    return "testConnectionString";
        //}

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
