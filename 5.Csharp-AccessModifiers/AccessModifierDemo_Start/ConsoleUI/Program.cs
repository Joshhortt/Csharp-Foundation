﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo(); 
            //  demo.   3. You cant access internal because Program.cs is inside the ConsoleUI
        }
    }
}
