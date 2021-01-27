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
			// 1. Printing out random numbers less than 8 including 5 with passing in a seed number of 1
			Random random = new Random(1);  // 2.  with passing in a seed number of 1
			for (int i = 0; i < 10; i++)
				
				{
				
				Console.WriteLine(random.Next(5, 8));  
			}
			Console.ReadLine();
		}
	}
}

/*OUTPUT FIRST ATTEMPT( 10 whole numbers), less than 8 including 5 with passing in a seed number of 1
5
5
6
7
6
6
6
7
5
6
 
/*SAME OUTPUT FIRST ATTEMPT( 10 whole numbers), less than 8 including 5 with passing in a seed number of 1
5
5
6
7
6
6
6
7
5
6
 */
