using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StructDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			dimension objecto = new dimension();
			objecto.length = 100;
			objecto.height = 100;
			objecto.nome = "Square";

			dimension obj2 = new dimension() { length = 10, height = 20, nome = "test" };

			obj2.length.ToString();  // For example .ToString for future use of a label
		}
	}
	struct dimension
	{
		public int length;
		public int height;
		public string nome;
	}
}
