using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ExtensionMethodsDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "John";
			Debug.WriteLine(name.RepeatTwice());

			string surName = "Snow";
			surName.RepeatTwice();
			
		}
	}
	static class MyExtensions
	{
		public static string RepeatTwice(this string s)   // (this) is related to data type string in this case
		{
			return s + s;  // It´s going to print out John twice -- >> JohnJohn
		}
			}
}
