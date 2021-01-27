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
			// 1. Just printing out random generated numbers
			Random random = new Random();
			//for(int i = 0; i < 10; i++)
				for (int i = 0; i < 10; i++)
				{
				Console.WriteLine(random.Next());
			}
			Console.ReadLine();
		}
	}
}

/*OUTPUT FIRST ATTEMPT( 10 whole numbers)
1735068141
458828833
1978960402
2105941021
750729128
299430000
414993441
1285919177
971344789
1302444363
 

OUTPUT SECOND ATTEMPT (10 whole numbers)
53365996
614834425
17580216
446546647
495751920
194571714
1507621949
1641285800
1290424958
186302080


OUTPUT THIRD ATTEMPT (5 whole numbers)
854285811
1705189089
1175556858
1857248375
1887450935
 */
