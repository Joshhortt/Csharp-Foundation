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
			ProtectedDemo();  // 4. Created new class with inheritance to class AcessDemo
			                     // Because we have access to private protected in the Mothers' method class AcessDemo
							     // Cannot access any other Access Modifier only ProtectedInternal and public because of which assembly is in.
							 
			

		}
	}
}
