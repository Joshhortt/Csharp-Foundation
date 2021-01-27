using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	public class DataAccess
	{
		// 1. Method copied from SqliteDatAccess and SqlDataAccess. Both serve the same purpose. Both now are childeren from DataAcces (Base).
		// They bring along the same method.
		public string LoadConnectionString(string name)
		{
			Console.WriteLine("Load Connection String");
			return "testConnectionString";
		}
	}
}

