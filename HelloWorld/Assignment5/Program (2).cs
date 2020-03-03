
/*Megan Figlenski
 * This program will listen to what the user inputs and deliver a math problem accordingly*/
using System;

namespace Assignment4
{
    class Program
    {
        static void main(string[] args)
        {
            String name;
            String quiz1 = "addition";
            String quiz2 = "subtraction";
            String quiz3 = "multiplication";
            String quiz4 = "division";

            try
            {
                Console.WriteLine("Hello, what is your name?");
                name = Convert.ToString(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error! Please enter your name");
            }//To make sure user enters name and no empty string

            //Find out what kind of problem they want
            Console.WriteLine("Would you like to have a (1)addition, (2)subtration, (3)multiplication, or (4)division problem?");
            int quiz = Convert.ToInt32(Console.ReadLine());

            if (quiz == 1)
            {
                //Give addition problem with two random numbers between 1 and 9
                Random r = new Random();
                int x = r.Next(1, 10);
                int y = r.Next(1, 10);
                Console.WriteLine("{0} + {1} is equal to what?",x,y);
            }

            if (quiz == 2)//selected subtraction
            {
                Random r = new Random();
                int x = r.Next(1, 10);
                int y = r.Next(1, 10);
                Console.WriteLine("{0} - {1} is equal to what?", x, y);
            }

        }//Main
    }//Class
}//Namespace
