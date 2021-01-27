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


			// 2. Comment this block of code
			//for (int i = 0; i < 10; i++)

			//	{
			//	Console.WriteLine(random.Next(5, 8));  
			//	Console.WriteLine(random.NextDouble()*10); 
			// SimpleMethod(random);    
			//}

			List<PersonModel> people = new List<PersonModel>  // 4. Adding a List of Person model with some random  first names
			{
				new PersonModel{FirstName = "Josh"},
				new PersonModel{FirstName = "Maria"},
				new PersonModel{FirstName = "Sonia"},
				new PersonModel{FirstName = "Josef"},
				new PersonModel{FirstName = "Ana"},
				new PersonModel{FirstName = "Sofia"},
				new PersonModel{FirstName = "Alex"},
				new PersonModel{FirstName = "Peter"}
			};

			//6.  Order by alphabetical order baseline.

			var sortedPeople = people.OrderBy(x => x.FirstName);

			foreach(var p in sortedPeople)
			{
				Console.WriteLine(p.FirstName);
			}



			Console.ReadLine();
		}
		private static void SimpleMethod(Random random) 
		{
			Console.WriteLine(random.Next());
		}
	}

	public class PersonModel //  3. Creating a class
	{
		public string FirstName { get; set; }
	}
}

/*OUTPUT names of Person model by alphabetical order
Alex
Ana
Josef
Josh
Maria
Peter
Sofia
Sonia


 */
