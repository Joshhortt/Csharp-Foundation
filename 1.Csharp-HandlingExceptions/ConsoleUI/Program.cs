
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // ############################ 1. Try catch ####################################
            DemoCode demo = new DemoCode();

            try
            {
                int result = demo.GrandparentMethod(4);
                Console.WriteLine($"The value at the given position is { result }");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You gave us bad information. Bad user!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }

            Console.ReadLine();
            */



            // ############################ 2. Try catch ####################################
            /* try {

                 StreamReader file = new StreamReader("file.txt"); // 1. Block of code. We think it's going to give us an error

                     // ..... More code errors can occur here as well

             } catch (FileNotFoundException)  {// just for the file not found
               Debug.WriteLine("File name not found!");  // In this case after starting thsi aplication it will throw an messagae 'File name not found?

             } catch (Exception) {
                // throw;   // 2. Block of code is useful for only when the error occurs. Ex: If the file above doesn't exist then it will throw an errow here
               Debug.WriteLine("An Error occured!"); // Error message examplo
             }
            */



            // ############################ 3. Try catch finally ####################################

            StreamReader file = null;
            try
            {

                file = new StreamReader("file.txt"); // 1. Block of code. We think it's going to give us an error

                // ..... More code errors can occur here as well

            }
            catch (FileNotFoundException)
            {// just for the file not found
                Debug.WriteLine("File name not found!");  // In this case after starting thsi aplication it will throw an messagae 'File name not found?

            }
            catch (Exception)
            {
                // throw;   // 2. Block of code is useful for only when the error occurs. Ex: If the file above doesn't exist then it will throw an errow here
                Debug.WriteLine("An Error occured!"); // Error message examplo
            } finally
			{
                if(file != null)   file.Dispose();   // 3. Liberate the file when you don't want it anymore open 
			}
        }
    }
}
