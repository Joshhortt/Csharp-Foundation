/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
// IMPORTANT NOTE: Change one thing at a time so that you know what you are doing/solving.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, ttl, t;  
           
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            t = int.Parse(Console.ReadLine());
            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time (yes/no):");
            //  bool cont = bool.Parse(Console.ReadLine()); 
            string answer = Console.ReadLine(); 
            bool cont = false;                 

            if (answer.ToLower() == "yes")
            {
                cont = true;
            }
            
             while (cont == true)//do
{
    Console.Write("Enter what you did: ");  
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                t = int.Parse(Console.ReadLine());
                ent = new TimeSheetEntry(); // added this ne Line. Step 19.
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);
                Console.Write("Do you want to enter more time (yes/no):");
                // cont = bool.Parse(Console.ReadLine()); 
                answer = Console.ReadLine(); 
                cont = false;                

                if (answer.ToLower() == "yes")
                {
                    cont = true;
                }
            } //while (cont == true); 
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("Acme"))
                {
                    ttl += ents[i].HoursWorked; //ttl += i;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");
            ttl = 0; // copied from Line 57. ro reset to zero again
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ABC"))
                {
                ttl += ents[i].HoursWorked;//ttl += i;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");
            ttl = 0; // copied from Line 69. ro reset to zero again
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked; 
    }
}
*/
// Step by Step Approach to Debug this Aplication:

// Step 1. Start or F5. answer all question appear
// Error message: After writing 'No' as a answer to the 3. question
// Error was: string was not recognized as a Valid boolean.
// Step 2. We konw the error started here Line 30
// Step 3. Looks like the progam doesn't recognize No' as boolean
// Step 4. Let's try something new. Start or F5 again and instead of No' or Yes'answer False or True.
// Step 5. It worked. It stepped over to this Line 41. Question number 4. So we know were the problem lays
// Step 6. New Solution. (32) Cut this line off.
// Step 7. (31-37). This is the new block of code I entered 
// Step 8. Cut this Line 57 off and change to a while loop in line 39
// Step 9. Instead of a do' loop insert a while loop line 39
// Step 10. Cut this line of code Line 49 and replace it withy (31 -37), placing in (50-56).
// Step 11: After placing a breakpoint at Line 58 and start the program again I got this response over here:
/*
Enter what you did: worked at Acme
How long did you do it for: 5
Do you want to enter more time:yes
Enter what you did: worked extras
How long did you do it for: 2
Do you want to enter more time:no
Simulating Sending email to Acme
Your bill is $0 for the hours worked. SOMETHING IS WRONG HERE I ENTERED 5 AND GET ZERO ??? Let's Debug this.
Simulating Sending email to ABC
Your bill is $0 for the hours worked.
You will get paid $40 for your time.
 */
// Step 12. After realizing that there was something wrong on Step 11. even the code didn't spit out any error The program is
// not doing correctly what it should. Let's find a solution.
// Step 13. Line 64 instead of i we replaced it with .... ents[i].HoursWorked; and after running the code it worked
/*
Enter what you did: I worked at Acme
How long did you do it for: 5
Do you want to enter more time:no
Simulating Sending email to Acme
Your bill is $750 for the hours worked. HERE YOU CAN SEE I HAVE MY HOURS RATE MULTIPLIED BY 5.
Simulating Sending email to ABC
Your bill is $625 for the hours worked.  BUT WAIT A MINUTE WHY IS MY BILL 625 $ FOR HOURS WORKED. DOESN T MAKE ANY SENSE. ANOTHER PROBLEM.
You will get paid $100 for your time.
 */
// Step 14. So at Line 74 we can see straight away the problem again with ttl +=i; Se we have to replace it again to ttl += ents[i].HoursWorked; NOB it didn t work
// Do not panic, undesrtand de code, do not try to change code without understanding the underlying problem first.
// Step 15. Let's put a breakpoint at Line 69 and run the program
/*
Enter what you did: I worked at Acme
How long did you do it for: 5
Do you want to enter more time:no
Simulating Sending email to Acme
Your bill is $750 for the hours worked.
 */
// Step 16. Let's step into or F11 the code. Note that in Line 78 ttl is 5 when you hover over. That means the ttl wasn't reset to zero as it should have. Let´s fix this issue.
// Step 17. Stop the debugger and fix. I copied ttl = 0; // copied from Line 57 to Line 69 . ro reset to zero again
// Step 18. I copied ttl = 0; // copied from Line 69. ro reset to zero again Aand run the program to see what happens.
/*
 Enter what you did: I worked for Acme
How long did you do it for: 5
Do you want to enter more time:yes
Enter what you did: worked for ABC
How long did you do it for: 4
Do you want to enter more time:no
Simulating Sending email to Acme
Your bill is $0 for the hours worked.    ------         WAIT A MINUTE ZERO??
Simulating Sending email to ABC
Your bill is $1000 for the hours worked.      ------         WAIT A MINUTE 1.000 $??
You will get paid $80 for your time.              ------         WAIT A MINUTE 80?? should be 90 right???
 */
// Step 19. So again we are still running issues. Don t panic again. Add in Line 45. this: ent = new TimeSheetEntry();
// Here I am saying here is the new addrees to put into the variable. Let's run it without any breakpoint to see what happens.
/*
Enter what you did: I worked for Acme
How long did you do it for: 5
Do you want to enter more time:yes
Enter what you did: I worked for ABC Corp
How long did you do it for: 4
Do you want to enter more time:no
Simulating Sending email to Acme
Your bill is $750 for the hours worked.
Simulating Sending email to ABC
Your bill is $500 for the hours worked.
You will get paid $90 for your time.
 */
// Looks like the Aplication is working right. At least for this specific scenario.
// Let's test some different scenarios to be totally sure.
// NOTE THAT: Only because it just worked fine you push it to production and that's a mistake sometimes.
// Step 20. Differente scenario is the following:
/*
 Enter what you did: I worked for Acme
How long did you do it for: 10
Do you want to enter more time:yes
Enter what you did: I worked for Acme
How long did you do it for: 20
Do you want to enter more time:yes
Enter what you did: I worked for Acme
How long did you do it for: 30
Do you want to enter more time:no
Simulating Sending email to Acme
Your bill is $9000 for the hours worked.
Simulating Sending email to ABC
Your bill is $0 for the hours worked.
You will get paid $900 for your work.
 */
// Looks good!! Let's Try a different scenario:

//################################################################################################################################################

// PART 2 of Debugging this Aplication
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
// IMPORTANT NOTE: Change one thing at a time so that you know what you are doing/solving.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w, rawTimeWorked;
            int i; // removed ttl, t;
            double ttl, t; // added ttl, t;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            rawTimeWorked = Console.ReadLine(); // Added this Line of code

            while (double.TryParse(rawTimeWorked, out t) == false) // added this new block of code
			{
				Console.WriteLine(); // add new line
				Console.WriteLine("Invalid number given"); // add new line
                Console.Write("How long did you do it for: "); // copied this block nof code from 236-237
                rawTimeWorked = Console.ReadLine();
            }
            //t = double.Parse(); //t = double.Parse(Console.ReadLine());
            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time (yes/no):");
            
            string answer = Console.ReadLine();
            bool cont = false;

            if (answer.ToLower() == "yes")
            {
                cont = true;
            }

            while (cont == true)
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                //t = double.Parse(Console.ReadLine());
                rawTimeWorked = Console.ReadLine(); // Added this Line of code

                while (double.TryParse(rawTimeWorked, out t) == false) // added this new block of code
                {
                    Console.WriteLine(); // add new line
                    Console.WriteLine("Invalid number given"); // add new line
                    Console.Write("How long did you do it for: "); // copied this block nof code from 236-237
                    rawTimeWorked = Console.ReadLine();
                }

                ent = new TimeSheetEntry(); 
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);

                Console.Write("Do you want to enter more time (yes/no):");
                answer = Console.ReadLine();
                cont = false;

                if (answer.ToLower() == "yes")
                {
                    cont = true;
                }
            }  
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("Acme"))
                {
                    ttl += ents[i].HoursWorked; 
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");

            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.Contains("ABC"))
                {
                    ttl += ents[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");

            ttl = 0; 
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked; //public int HoursWorked;
    }
}


// Step 21. Line 237 I get a ErrorSystem.FormatException  Character entry in wrong format.
// Step 22. We need to change the Function public int HoursWorked; -> to public double HoursWorked; 
// Step 23. We also need to change ttl' and t' as an int's to double's in Line 232.
// Step 24. We also need to change int.Parse' in Line 237. & in Line 257. to double.Parse
// Step 25. We add a string varaible value cllaed rawTimeWorked on Line 30.
// Step 26. 
*/


//################################################################################################################################################

// PART 3 of Debugging this Aplication

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w, rawTimeWorked;
            int i;
            double ttl, t;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            Console.Write("Enter what you did: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            rawTimeWorked = Console.ReadLine();

            while (double.TryParse(rawTimeWorked, out t) == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
            }

            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time (yes/no): ");

            string answer = Console.ReadLine();
            bool cont = false;

            if (answer.ToLower() == "yes")
            {
                cont = true;
            }

            while (cont == true)
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();

                while (double.TryParse(rawTimeWorked, out t) == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid number given");
                    Console.Write("How long did you do it for: ");
                    rawTimeWorked = Console.ReadLine();
                }

                ent = new TimeSheetEntry();
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);

                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();
                cont = false;

                if (answer.ToLower() == "yes")
                {
                    cont = true;
                }
            }
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.ToLower().Contains("acme")) // added.ToLower ... ("acme")
                {
                    ttl += ents[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");

            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                if (ents[i].WorkDone.ToLower().Contains("abc"))  // added.ToLower ... ("abc")
                {
                    ttl += ents[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");

            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40) // we still need to test this branch
            {
                Console.WriteLine("You will get paid $" + (((ttl - 40) * 15) + (40 * 10)) + " for your work."); // added more code here
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}



