using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public abstract class DataAccess  
	{                                 
		
		public string LoadConnectionString(string name)
		{
			Console.WriteLine("Load Connection String");
			return "testConnectionString";
		}

		public abstract void LoadData(string sql);  // 1. Add method with abstract. These are methods declarede but not implemented

		public abstract void SaveData(string sql);  // 2. Add method with abstract. These are methods declarede but not implemented
	}
}

