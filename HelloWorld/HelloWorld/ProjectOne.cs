/*Ryan Deleurme
 * 
 * This program will have 5 lines of output and will be our first project. 
 * First, It will say hello world, then it will give a short, mid, and long term goals I have for the semester.
 * last it will say "press enter to continue..." to exit the program.
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class ProjectOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Short Term Goal: Get Visual Studio up and running.");
            Console.WriteLine("Mid Term Goal: Understand classes and objects better, write a basic program.");
            Console.WriteLine("Long Term Goal: Use everything I learned to write a semi-advanced program.");
            Console.WriteLine("Press Enter to Continue...");
            Console.Read();        
        }
    }
}