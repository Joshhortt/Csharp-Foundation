/*

We are going to creating thsi simple Aplication by:
- creating a demo console application
- reading all directories in the path specified
- reading all files in the path specified (directories included)
- reading all files (directories excluded), omitting file extensions, getting file path only
- information about the file
- automation with c# - manipulating file systems and files.
- verify if directory exists
- creating a new directory
- copying files
- moving files
- utilize - create your own utility apps

 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{

			string rootPath = @"D:\Temp\Demos\Filesystem";
			// I - ONLY READING (1-7)
			// 1. Directories
			/*
			 string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
			
			foreach (string dir in dirs)
			{
				Console.WriteLine(dir);
			}
			*/
			// 2. Files in Top Directory
			/*
			var files = Directory.GetFiles(rootPath, "*", SearchOption.TopDirectoryOnly);
			 foreach (string file in files)
			{
				Console.WriteLine(file); ;
			}
			 */
			// 3. Files in All Directories
			/*
			var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
			foreach (string file in files)
			{
				Console.WriteLine(file); 
			}
			*/
			// 4. Just the File Names
			/*
			var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
			
			foreach (string file in files)
			{
				//Console.WriteLine(file); 1. 2. 3. 

				// 4. Console.WriteLine(Path.GetFileName(file));  4.

				//Console.WriteLine(Path.GetFileNameWithoutExtension(file));  5.

				//Console.WriteLine(Path.GetFullPath(file)); // 6.	

				// 7. Info about a file
				//var info = new FileInfo(file);
				//Console.WriteLine($"{Path.GetFileName(file)}:{info.Length} bytes");
			}*/



			// II  - FILESYSTEM MANIPULATION ( AUTOMATION TESTS - Make C# do it for you )
			// 1. Verify if a Directory exists
			/*
			bool directoryExists = Directory.Exists(@"D:\Temp\Demos\Filesystem\SubFoldera"); // We have actually a SubFolderA but here it's not case sensitive. So it's output will be ... exists.
			//bool directoryExists = Directory.Exists(@"D:\Temp\Demos\Filesystem\SubFoldera");      It will print out .. does not exist.                                                                           
			if (directoryExists)
			{
				Console.WriteLine("The directory exists");
			}
			else
			{
				Console.WriteLine("The directory does not exist");
			}
			*/


			// 2. Create Directory in specified path
			//string newPath = @"D:\Temp\Demos\Filesystem\SubFolderX\SubSubFolderY";  // create a variable - two sublayers that don' exist.

			//bool directoryExists = Directory.Exists(newPath); 

			//if (directoryExists)
			//{
			//	Console.WriteLine("The directory exists");
			//}
			//else
			//{
			//	Console.WriteLine("The directory does not exist");
			//	Directory.CreateDirectory(newPath); // if these don't exist we 're gonna create these directories.
			//}


			// 3. Copying Files

			//string[] files = Directory.GetFiles(rootPath);
			//string destinationFolder = @"D:\Temp\Demos\Filesystem\SubFolderA";

			//foreach (string file in files)
			//{
			//	File.Copy(file, $"{destinationFolder}{Path.GetFileName(file)}", true );
			//}


			// 3.1 more copying files - renaming as we go.

			//string[] files = Directory.GetFiles(rootPath);
			//string destinationFolder = @"D:\Temp\Demos\Filesystem\SubFolderA\";
			//for (int i =0; i < files.Length; i++)
			//{
			//	File.Copy(files[i], $"{destinationFolder}{i}.txt", true);
			//}

			// 3.2 move files
			//string[] files = Directory.GetFiles(rootPath);
			//string destinationFolder = @"D:\Temp\Demos\Filesystem\SubFolderA\";
			//foreach (string file in files)
			//{
			//	File.Move(file, $"{destinationFolder}{Path.GetFileName(file)}");
			//}


			// 4. utilize - create your own utility apps
			// var files = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
			//var files = Directory.GetFiles(rootPath, "*.xlsx", SearchOption.AllDirectories); // only .xlsx files
			var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories); // only Files that have folder in their name
			
			foreach (string file in files)
			{
				Console.WriteLine(file);

				//Console.WriteLine(Path.GetFileName(file)); 

				//Console.WriteLine(Path.GetFileNameWithoutExtension(file));

				//Console.WriteLine(Path.GetDirectoryName(file));

				//Console.WriteLine(Path.GetFullPath(file)); 	

			    //var info = new FileInfo(file);

				//Console.WriteLine($"{Path.GetFileName(file)}:{info.Length} bytes");
			}
			Console.ReadLine();
		}
	}
}

/*OUTPUTS:
 1.
D:\Temp\Demos\Filesystem\SubFolderA
D:\Temp\Demos\Filesystem\SubFolderB
D:\Temp\Demos\Filesystem\SubFolderA\SubSubFolderC


 2.
D:\Temp\Demos\Filesystem\RootFile1.txt
D:\Temp\Demos\Filesystem\RootFile2.txt
 

 3.
D:\Temp\Demos\Filesystem\RootFile1.txt
D:\Temp\Demos\Filesystem\RootFile2.txt
D:\Temp\Demos\Filesystem\SubFolderA\MyFileInA.txt
D:\Temp\Demos\Filesystem\SubFolderA\MySecondFileInA.txt
D:\Temp\Demos\Filesystem\SubFolderA\MyThirdFileInA.txt
D:\Temp\Demos\Filesystem\SubFolderA\SubSubFolderC\NestedFile1.txt
D:\Temp\Demos\Filesystem\SubFolderB\Bfolder1.txt
D:\Temp\Demos\Filesystem\SubFolderB\Bfolder2.xlsx
D:\Temp\Demos\Filesystem\SubFolderB\Bfolder3.odg


4.
RootFile1.txt
RootFile2.txt
MyFileInA.txt
MySecondFileInA.txt
MyThirdFileInA.txt
NestedFile1.txt
Bfolder1.txt
Bfolder2.xlsx
Bfolder3.odg


5.
RootFile1
RootFile2
MyFileInA
MySecondFileInA
MyThirdFileInA
NestedFile1
Bfolder1
Bfolder2
Bfolder3

6.
p\Demos\Filesystem\RootFile1.txt
D:\Temp\Demos\Filesystem\RootFile2.txt
D:\Temp\Demos\Filesystem\SubFolderA\MyFileInA.txt
D:\Temp\Demos\Filesystem\SubFolderA\MySecondFileInA.txt
D:\Temp\Demos\Filesystem\SubFolderA\MyThirdFileInA.txt
D:\Temp\Demos\Filesystem\SubFolderA\SubSubFolderC\NestedFile1.txt
D:\Temp\Demos\Filesystem\SubFolderB\Bfolder1.txt
D:\Temp\Demos\Filesystem\SubFolderB\Bfolder2.xlsx
D:\Temp\Demos\Filesystem\SubFolderB\Bfolder3.odg

7.
RootFile1.txt:0 bytes
RootFile2.txt:0 bytes
MyFileInA.txt:0 bytes
MySecondFileInA.txt:0 bytes
MyThirdFileInA.txt:0 bytes
NestedFile1.txt:0 bytes
Bfolder1.txt:0 bytes
Bfolder2.xlsx:6547 bytes
Bfolder3.odg:7813 bytes
 */
