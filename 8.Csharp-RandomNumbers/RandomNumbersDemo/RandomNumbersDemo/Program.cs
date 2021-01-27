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
			Random random = new Random();

			//for (int i = 0; i < 10; i++)

			//	{
			//	Console.WriteLine(random.Next(5, 8));  
			//	Console.WriteLine(random.NextDouble()*10); 
			// SimpleMethod(random);    
			//}

			List<PersonModel> people = new List<PersonModel>  
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

			//var sortedPeople = people.OrderBy(x => x.FirstName);  // 1. Comment this,
			var sortedPeople = people.OrderBy(x => random.Next());  // 2. And add random.Next() it will randomly print the out FirstNames
			foreach (var p in sortedPeople)
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

	public class PersonModel 
	{
		public string FirstName { get; set; }
	}
}

/*OUTPUT FIRST ATTEMPT: names of Person model by random order
Josef
Maria
Josh
Sonia
Peter
Ana
Sofia
Alex

OUTPUT SECOND ATTEMPT: names of Person model by random order
Sofia
Josef
Peter
Josh
Ana
Alex
Maria
Sonia
 */
