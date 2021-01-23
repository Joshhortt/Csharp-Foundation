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
			// ProtectedDemo();  
			//InternalDemo();
			 PrivateProtectedDemo(); // 3.Private Protected can be called from here
			//PublicDemo();
			//InternalDemo();
		}
	}
}
