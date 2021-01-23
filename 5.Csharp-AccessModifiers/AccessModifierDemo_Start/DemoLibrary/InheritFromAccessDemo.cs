using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
	class InheritFromAccessDemo : AccessDemo    // 2. Create a new class to inherit from AccessDemo. Purpose is testing Protected
	{
		public void Test()
		{
			ProtectedDemo();  // 3. Protected I can call from here
			//InternalDemo();
			//PrivateProtectedDemo();
			//PublicDemo();
			//InternalDemo();
		}
	}
}
