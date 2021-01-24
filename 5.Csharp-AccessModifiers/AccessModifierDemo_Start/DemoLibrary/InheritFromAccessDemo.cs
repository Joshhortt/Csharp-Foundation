using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	class InheritFromAccessDemo : AccessDemo    
	{
		public void Test()
		{
			//ProtectedDemo();  
			//InternalDemo();
			//PrivateProtectedDemo();
			//PublicDemo();
			//InternalDemo();
			ProtectedInternalDemo();   // 3.Protected Internal can be called from here
									   
		}
	}
}
