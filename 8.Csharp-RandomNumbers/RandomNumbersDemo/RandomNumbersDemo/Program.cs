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
			// 1. Printing out random numbers less than 11
			Random random = new Random();
			for(int i = 0; i < 10; i++)
				
				{
				//Console.WriteLine(random.Next(11));  // 2. less than 11. The max value will not be picked.
				Console.WriteLine(random.Next(8));  // 3. less than 8. The max value will not be picked.
			}
			Console.ReadLine();
		}
	}
}

/*OUTPUT FIRST ATTEMPT( 10 whole numbers), less than 11
2
10
10
2
9
8
2
5
6
1
 

OUTPUT SECOND ATTEMPT (10 whole numbers), less than 11
7
8
9
5
10
9
10
3
9
5

OUTPUT SECOND ATTEMPT (10 whole numbers), BUT with less than 8 values.
0
2
2
2
5
5
7
3
2
1

 */
