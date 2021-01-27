using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1. Using Random well ...
			Random random = new Random();

			for (int i = 0; i < 10; i++)
				
				{
				// 2. Comment -- >> Console.WriteLine(random.Next(5, 8));  
				Console.WriteLine(random.NextDouble());  // 2. Adding Double to next
				// SimpleMethod(random);    3. Cooment
			}

			Console.ReadLine();
		}
		private static void SimpleMethod(Random random) 
		{
			Console.WriteLine(random.Next());
		}
	}
}

/*OUTPUT FIRST ATTEMPT( 10 double numbers)
0,620261125555384
0,626037095033581
0,192714978099202
0,658925515440724
0,84009393576537
0,749256377922956
0,03695912195228
0,0407107477265926
0,0368781406604117
0,440451943986328
 
/*OUTPUT SECOND ATTEMPT( 10 double numbers)
0,844076678549907
0,111769080679756
0,738599690021295
0,362422578205551
0,413602239644901
0,497160597470198
0,0484613171072962
0,754646947027485
0,374913536652417
0,286118351987618

 */
