using System;

namespace inClassWeek3
{
    class inClass
    {
        static void Main(string[] args)
        {
            //declare the variables we will need for the program
            string gryffindor = "Gryffindor";
            string hufflepuff = "Hufflepuff";
            string ravenclaw = "Ravenclaw";
            string slytherin = "Slytherin";
            string name;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine(); //capture the name of the user

            Random r = new Random();
            int num = r.Next(0, 4);
            //Console.WriteLine(num); //for debugging...

            switch(num) //depending on what the number is, they will be assigned to a different group
            {
                case 0:
                    {
                        Console.WriteLine("Hello {0}, you are in...{1}", name, gryffindor);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Hello {0}, you are in...{1}", name, hufflepuff);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Hello {0}, you are in...{1}", name, ravenclaw);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Hello {0}, you are in...{1}", name, slytherin);
                        break;
                    }

            }

            //exit program
            Console.WriteLine("\nPress enter to continue...");
            Console.Read();
        }
    }
}
