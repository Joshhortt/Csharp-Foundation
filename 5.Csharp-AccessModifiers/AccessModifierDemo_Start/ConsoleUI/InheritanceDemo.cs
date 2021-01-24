using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	class InheritanceDemo : AccessDemo
	{
		private void Demo()
		{
			ProtectedDemo();  

			ProtectedInternalDemo();  // 4. Protected Internal is accessible too from here, inside the same assembly and also from were it inherits

		}
	}
}
