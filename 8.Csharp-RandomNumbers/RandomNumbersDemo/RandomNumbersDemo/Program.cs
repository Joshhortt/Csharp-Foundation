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
			// 1. Printing out random numbers less than 8 including 5
			Random random = new Random();
			for(int i = 0; i < 10; i++)
				
				{
				
				Console.WriteLine(random.Next(5, 8));  // 2. less than 8. including 5
			}
			Console.ReadLine();
		}
	}
}

/*OUTPUT FIRST ATTEMPT( 10 whole numbers), less than 8 including 5
6
5
6
5
7
6
7
6
7
7
 
 */
