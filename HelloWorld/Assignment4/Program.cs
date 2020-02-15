/* Ryan Delurme
 * This program will ask the user for their name and what kind of math problem they would like. 
 * if they do not prompt anything, this will bring up a warning. if they do give us a problem, 
 * we will reandomly generate two numbers and perform a math function from the users choice. 
 */

using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {  try
            {
                //declare our variables and objects
                string name;
                string userAns; //user answer to the problem
                int num1;
                int num2;
                int pAns; //problem answer
                int chk = 0;
                Random r = new Random();


                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                //check if the string is NULL
                if (String.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Please enter a valid name below!\n");
                    name = Console.ReadLine();
                    // if empty again, throw to catch block.
                    if(String.IsNullOrEmpty(name))
                    {
                        throw new Exception();
                    }
                }

                Console.WriteLine("Hello {0}, what type of quiz would you like?\n", name);
                Console.WriteLine(@"Quiz Type: 
Addition [1]
Subtraction [2]
Multiplication [3]
Division [4]");

                int qType = Convert.ToInt32(Console.ReadLine());

                if (qType == 1)
                {
                    num1 = r.Next(1, 9);
                    //Console.WriteLine("First number is {0}", num1); for debugging
                    num2 = r.Next(1, 9);
                    //Console.WriteLine("Second number is {0}", num2);
                    pAns = num1 + num2;

                    Console.WriteLine("What is {0} + {1}", num1, num2);
                    userAns = Console.ReadLine();

                    //check if the user input a number
                    if (Int32.TryParse(userAns, out chk))
                    {
                        chk = Convert.ToInt32(userAns);
                    }
                    else
                    {
                        Console.WriteLine("Please input an integer for:\n");
                        Console.WriteLine("What is {0} + {1}", num1, num2);
                        userAns = Console.ReadLine();
                        chk = Convert.ToInt32(userAns);
                    }

                    if (chk == pAns)
                    {
                        Console.WriteLine("Correct! {0} + {1} is {2}", num1, num2, pAns);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, {0} + {1} is not {2}, it is {3}...", num1, num2, userAns, pAns);
                    }


                }
                else if (qType == 2)
                {
                    num1 = r.Next(1, 9);
                    //Console.WriteLine("First number is {0}", num1); for debugging
                    num2 = r.Next(1, 9);
                    //Console.WriteLine("Second number is {0}", num2);
                    pAns = num1 - num2;

                    Console.WriteLine("What is {0} - {1}", num1, num2);
                    userAns = Console.ReadLine();

                    //check if the user input a number
                    if (Int32.TryParse(userAns, out chk))
                    {
                        chk = Convert.ToInt32(userAns);
                    }
                    else
                    {
                        Console.WriteLine("Please input an integer for:\n");
                        Console.WriteLine("What is {0} - {1}", num1, num2);
                        userAns = Console.ReadLine();
                        chk = Convert.ToInt32(userAns);
                    }

                    if (chk == pAns)
                    {
                        Console.WriteLine("Correct! {0} - {1} is {2}", num1, num2, pAns);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, {0} - {1} is not {2}, it is {3}...", num1, num2, userAns, pAns);
                    }
                }
                else if (qType == 3)
                {
                    num1 = r.Next(1, 9);
                    //Console.WriteLine("First number is {0}", num1); for debugging
                    num2 = r.Next(1, 9);
                    //Console.WriteLine("Second number is {0}", num2);
                    pAns = num1 * num2;

                    Console.WriteLine("What is {0} x {1}", num1, num2);
                    userAns = Console.ReadLine();

                    //check if the user input a number
                    if (Int32.TryParse(userAns, out chk))
                    {
                        chk = Convert.ToInt32(userAns);
                    }
                    else
                    {
                        Console.WriteLine("Please input an integer for:\n");
                        Console.WriteLine("What is {0} x {1}", num1, num2);
                        userAns = Console.ReadLine();
                        chk = Convert.ToInt32(userAns);
                    }

                    if (chk == pAns)
                    {
                        Console.WriteLine("Correct! {0} x {1} is {2}", num1, num2, pAns);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, {0} x {1} is not {2}, it is {3}...", num1, num2, userAns, pAns);
                    }
                }
                else
                {
                    num1 = r.Next(1, 9);
                    //Console.WriteLine("First number is {0}", num1); for debugging
                    num2 = r.Next(1, 9);
                    //Console.WriteLine("Second number is {0}", num2);
                    pAns = num1 / num2;

                    Console.WriteLine("What is {0}/{1}", num1, num2);
                    userAns = Console.ReadLine();

                    //check if the user input a number
                    if (Int32.TryParse(userAns, out chk))
                    {
                        chk = Convert.ToInt32(userAns);
                    }
                    else
                    {
                        Console.WriteLine("Please input an integer for:\n");
                        Console.WriteLine("What is {0}/{1}", num1, num2);
                        userAns = Console.ReadLine();
                        chk = Convert.ToInt32(userAns);
                    }

                    if (chk == pAns)
                    {
                        Console.WriteLine("Correct! {0}/{1} is {2}", num1, num2, pAns);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, {0}/{1} is not {2}, it is {3}...", num1, num2, userAns, pAns);
                    }
                }
            }
            catch (FormatException) // in a perfect world we already created a method for the above code, and we would just call it again inside the catch blocks... 
            {
                Console.WriteLine("Please use the correct input when specified. Restart the program...");
            }
            catch  (Exception)
            {
                Console.WriteLine("Please do not enter a blank name. Restart the program...");
            }
        }
    }
}
