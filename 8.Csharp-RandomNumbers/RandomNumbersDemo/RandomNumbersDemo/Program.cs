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
				Console.WriteLine(random.NextDouble()*10);  // 4. Adding times 10
				// SimpleMethod(random);    3. Comment
			}

			Console.ReadLine();
		}
		private static void SimpleMethod(Random random) 
		{
			Console.WriteLine(random.Next());
		}
	}
}

/*OUTPUT FIRST ATTEMPT( 10 double numbers * 10)
0,139265204844654
3,82976169410616
0,80990890078708
1,41330418708422
1,24125268368109
9,70188010004436
2,31688420396153
8,62122371728589
2,96912741054275
5,64087316190865
 
/*OUTPUT SECOND ATTEMPT( 10 double numbers * 10)
7,55958123484607
6,04187799898995
4,76878221368826
3,09801962370892
5,38336959452525
2,19276398988104
2,54288801110484
1,32242888273784
7,29699967303174
1,29073349353426

 */
