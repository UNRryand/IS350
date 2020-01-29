/*This is a comment header
  Alan Yang
  Notes file for IS 350
 */

//This is a comment
//These lines tell the program we want to use the code in these namespaces
//Bold text means the namespace is being used
using System;
using System.Collections.Generic;
using System.Text;

namespace projectZero //This is the name of our current namespace and project
{
    class Notes2020s //this is the name of our class
    {
        static void Main(string[] args) //this is the main method
        {

            ////week 1-----------------------------------------------------------------------

            //System.Console.WriteLine("hello");
            /*dfdfd
              dfdf
              dfdfd
             fdfdfd
              fdfdfdf
              dfdfdf
             */

            //Console.WriteLine("my name is computer"); //this is a line of output
            //Console.WriteLine("Yo");
            //    //int x = divide(6, 2);
            //    //console.writeline(x);
            //    Console.WriteLine("press enter to close");
            //Console.Read(); //this is a line of input

            //    //char c = '!';
            //    //char b = '8';
            //    //char d = 'd';

            //    //errors
            //    //syntax
            //    //console.readline();

            //    ////runtime
            //double solution = divide(4, 2);
            //Console.WriteLine(solution);
            //    //    divide(4, 0);
            //    //logic
            //    //console.writeline("calling divide method, 4 divided by 2 is: ");
            //    //int x = divide(4, 2);
            //    //console.writeline(x);
            //    //console.writeline(divide(4, 2));
            //    //comment shortcut (control + k + c)
            //    //uncomment shortcut (control + k + u)
            //    //macs (cmd + /) or (cmd + k + c and cmd + k + u)

            //week 2-----------------------------------------------------------------------
            //Creating a circle area program

            //Problem: given a circle with radius of 20, what is the area?

            ////store information on this circle
            //double radius = 20;
            //double PI;
            //double area;
            //PI = 3.14;

            ////perform the circle area calculation
            ////area = PI * radius * radius
            //area = PI * radius * radius;
            ////display the results to the user
            ////Console.WriteLine(area);
            ////Console.WriteLine("The area of a circle with radius of {0} is {1}", radius, area);
            ////Console.WriteLine("radius");
            ////Console.WriteLine(radius);
            //////end the program
            //Console.WriteLine("Press enter...");
            //Console.Read();




            ////Enhancing the circle program by allowing user to input value for radius and their name
            ////create information for the circle
            ////create variables
            //double radius = 0;
            //double area = 0;
            //double PI = 3.14;
            //string name = "";
            //////know that pi is 3.14
            //////calculate area
            //////radius is going to be supplied by the user

            //////ask the user for input
            //Console.WriteLine("Enter a value for radius");

            //////capture and store user input 
            //radius = Convert.ToDouble(Console.ReadLine());


            ////ask for their name
            //Console.WriteLine("What's your name?");
            //name = Console.ReadLine();
            //////perform the calculation
            //area = PI * radius * radius;
            //////output the result
            //Console.WriteLine("{0}, area of a circle of radius {1} is {2}", name, radius, area);


            ////Textual data
            //char c = '!';
            //char b = '8';
            //char d = 'd';

            //string s = "keep it 100";
            //string textN = "100";
            //int numN = 100;
            //////adding numeric values 
            // int sum = numN + 29;
            //Console.WriteLine(sum);
            ////trying to add numeric values with textual values
            //sum = textN + 29;


            ////Concatanation
            //string s1 = "Star Wars: ";
            //string s2 = "A New Hope";
            //string s3 = s1 + s2;
            //Console.WriteLine(s3);
            //string s4 = s3 + " part " + 2;
            //Console.WriteLine(s4);


            //Console.WriteLine(s1 + "The Phantom Menance");
            //Console.WriteLine("The sum of " + numN + " and 29 is " + sum);
        }//main method
        //division method
        static int divide(int x, int y)
        {
            //This method has 2 integer parameters 
            //The method returns the quotient of the two numbers using whole number divsion
            return (x / y);
        }//divide method

    }// Notes2020s class
}//namespace
