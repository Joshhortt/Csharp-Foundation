using BrownfieldLibrary;
using BrownfieldLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
0:00 - Intro
1:01 - application code walk-through
5:02 - where to start with refactoring
10:20 - splitting code into discrete methods 
25:44 - creating a class library (dealing with repeating logic)
49:48 - simulating loading data from the database
 */
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimeSheetEntryModel> timeSheets = LoadTimesheets();
            List<CustomerModel> customers = DataAccess.GetCustomers();
            EmployeeModel currentEmployee = DataAccess.GetCurrentEmployee();

            customers.ForEach(x => BillCustomer(timeSheets, x));

            PayEmployee(timeSheets, currentEmployee);

            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        private static void PayEmployee(List<TimeSheetEntryModel> timeSheets, EmployeeModel employee)
        {
            decimal totalPay = TimeSheetProcessor.CalculateEmployeePay(timeSheets, employee);
            Console.WriteLine($"You will get paid ${ totalPay } for your time.");
            Console.WriteLine();
        }

        private static void BillCustomer(List<TimeSheetEntryModel> timeSheets, CustomerModel customer)
        {
            double totalHours = TimeSheetProcessor.GetHoursWorksForCompany(timeSheets, customer.CustomerName);

            Console.WriteLine($"Simulating Sending email to { customer.CustomerName }");
            Console.WriteLine("Your bill is $" + (decimal)totalHours * customer.HourlyRateToBill + " for the hours worked.");
            Console.WriteLine();
        }

        private static List<TimeSheetEntryModel> LoadTimesheets()
        {
            List<TimeSheetEntryModel> output = new List<TimeSheetEntryModel>();
            string enterMoreTimesheets = "";

            do
            {
                Console.Write("Enter what you did: ");
                string workDone = Console.ReadLine();

                Console.Write("How long did you do it for: ");
                string rawTimeWorked = Console.ReadLine();

                double hoursWorked;

                while (double.TryParse(rawTimeWorked, out hoursWorked) == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid number given");
                    Console.Write("How long did you do it for: ");
                    rawTimeWorked = Console.ReadLine();
                }

                TimeSheetEntryModel timeSheet = new TimeSheetEntryModel();
                timeSheet.HoursWorked = hoursWorked;
                timeSheet.WorkDone = workDone;
                output.Add(timeSheet);

                Console.Write("Do you want to enter more time (yes/no): ");
                enterMoreTimesheets = Console.ReadLine();
                
            } while (enterMoreTimesheets.ToLower() == "yes");

            Console.WriteLine();

            return output;
        }
    }
}

/*
 

Enter what you did: worked for acme
How long did you do it for: 15
Do you want to enter more time (yes/no): yes
Enter what you did: I worked for acme
How long did you do it for: 7
Do you want to enter more time (yes/no): yes
Enter what you did: I worked for abc corp
How long did you do it for: 14
Do you want to enter more time (yes/no): no

Simulating Sending email to Acme
Your bill is $3300 for the hours worked.

Simulating Sending email to ABC
Your bill is $1750 for the hours worked.

You will get paid $540 for your time.


Press any key to exit application...
 
 */
