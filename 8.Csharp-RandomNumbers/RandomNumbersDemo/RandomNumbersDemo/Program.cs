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
				SimpleMethod(random);
			}

			Console.ReadLine();
		}
		private static void SimpleMethod(Random random)  // 3. Create private static method
		{
			Console.WriteLine(random.Next());
		}
	}
}

/*OUTPUT FIRST ATTEMPT( 10 whole numbers)
200294297
9625400
180075971
2093405899
1050823125
218307568
842187541
1731040482
1093104048
252448969
 
/*OUTPUT SECOND ATTEMPT( 10 whole numbers)
1639188983
1059563538
544986068
751871878
1311898542
498438722
304793607
952429039
718958311
173445454
 */
