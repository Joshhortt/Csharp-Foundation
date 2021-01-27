using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public abstract class DataAccess  // 1. Add 'abstract' class that says: 'You can't create me directly but anything that inherits from me gets this code'.
	{                                 // It's a blend of Interface and Base Class.
		
		public string LoadConnectionString(string name)
		{
			Console.WriteLine("Load Connection String");
			return "testConnectionString";
		}
	}
}

