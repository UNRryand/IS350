/* Ryan Deleurme
 * This is a program that is simulating a pirate and his gold pieces earnings. The pirate will specify 
 * the starting amount of gold, then the scenario. If the pirate presses 1, the program will simulate until two different conditions are met. 
 * The second option is to specify the amount of years and the program will simulate the growth or decline of gold pieces. 
 */

using System;

namespace Assignment5
{
    class Assignment5
    {
        static void Main(string[] args)
        {
            string trs; //treasure
            string qs; //market question
            string sYrs;
            int iYrs;
            int rand;
            int tre;
            int sim;
            int chk = 0; //to check integer values
            Random r = new Random();

            try
            {
                Console.WriteLine("what is your starting amount of gold matey?");
                trs = Console.ReadLine();
                if (String.IsNullOrEmpty(trs)) 
                {
                    Console.WriteLine("You must enter something after the question...");
                    Console.WriteLine("what is your starting amount of gold matey?");
                    trs = Console.ReadLine();
                    if(String.IsNullOrEmpty(trs))
                    {
                        throw new Exception();
                    }

                }
                //Format exception error will catch non integer or string.
                tre = Convert.ToInt32(trs); //real treasure amount
          
                Console.WriteLine("Would you like to automate the simulation [1]\nOr specify the amount of years [2] ?");
                qs = Console.ReadLine();

                if (String.IsNullOrEmpty(qs))
                {
                    Console.WriteLine("You must enter something after the question...");
                    Console.WriteLine("Would you like to automate the simulation [1]\nOr specify the amount of years [2] ?");
                    qs = Console.ReadLine();
                    if (String.IsNullOrEmpty(qs))
                    {
                        throw new Exception();
                    }

                }

                sim = Convert.ToInt32(qs); //real treasure amount, user input an integer

                if (sim == 1)
                {
                    for (int i = 0; tre > 0 && tre < 1000 ;i++)
                    {
                        rand = r.Next(0, 2);
                        if(rand == 1)
                        {
                            Console.WriteLine("Current year is {0}, treasure amount is: {1}",i,tre);
                            tre = tre + 50;
                        }
                        else
                        {
                            Console.WriteLine("Current year is {0}, treasure amount is: {1}", i, tre);
                            tre = tre - 50;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("How many years for the simulation?");
                    sYrs = Console.ReadLine();
                    if (String.IsNullOrEmpty(sYrs))
                    {
                        Console.WriteLine("You must enter something after the question...");
                        Console.WriteLine("How many years for the simulation?");
                        sYrs = Console.ReadLine();
                        if (String.IsNullOrEmpty(sYrs))
                        {
                            throw new Exception();
                        }

                    }
                    else
                    {
                        //format exception erorr will catch the non int.
                        iYrs = Convert.ToInt32(sYrs);
                        for(int i = 0; i < iYrs; i++)
                        {
                            rand = r.Next(0, 2);
                            if (rand == 1)
                            {
                                Console.WriteLine("Current year is {0}, treasure amount is: {1}", i, tre);
                                tre = tre + 50;
                            }
                            else
                            {
                                Console.WriteLine("Current year is {0}, treasure amount is: {1}", i, tre);
                                tre = tre - 50;
                            }
                        }
                    }
                }
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input the correct value type for the question...restart the program!");
            }
            catch (Exception)
            {
                Console.WriteLine("Please do not leave the question empty...restart the program!");
            }
        }
    }
}
