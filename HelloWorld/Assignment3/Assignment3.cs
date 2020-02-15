/* Ryan Deleurme
 * 
 * This program will have a user guess if the randomly generated name is a musician or a writer. 
 * If the user guesses correctly, a prompt will display saying that they got it correct, repeat their name and the persons name. 
 * If they got the question incorrect, it will display they are wrong.   
 * 
 */

using System;

namespace Assignment3
{
    class Assignment3
    {
        static void Main(string[] args)
        {
            //declare our people and other variables we need

            string musician1 = "Kanye West";
            string musician2 = "CeddyBu";
            string writer1 = "Mitch Albom";
            string writer2 = "Ernest Hemingway";
            int musOrWriter; //for verifying later on
            string desc; //for the description later on

            //random generator to grab random string
            //do this so whatever number we get, we can assign to one of the 4 string variables we have

            Random r = new Random();
            int num = r.Next(0,4); //get random integer between 0 and 3
            // Console.WriteLine(num); //for debugging to make sure each value is assigned correctly

            //depending on the value, we assing the prompt varaible to one of the other 4 string variables
            //assign other variables we will use to help us verify userinput and display the description
            string prompt;

            if (num == 0)
            {
                prompt = musician1;
                musOrWriter = 1;
                desc = "musician";
            }
            else if (num == 1) 
            {
                prompt = musician2;
                musOrWriter = 1;
                desc = "musician";
            }
            else if (num == 2) 
            {
                prompt = writer1;
                musOrWriter = 2;
                desc = "writer";
            }
            else
            {
                prompt = writer2;
                musOrWriter = 2;
                desc = "writer";
            }

            //display the random prompt to the user and input variable
            int userInput;
            Console.WriteLine("Is {0} a musican (1) or a writer (2)?", prompt);
            userInput = Convert.ToInt32(Console.ReadLine());
            
            if(musOrWriter == userInput) //if the musOrWriter number is the same as the userinput...
            {
                Console.WriteLine("Congrats! {0} is a {1}!", prompt, desc);
            }
            else
            {
                Console.WriteLine("Sorry, {0} is a {1}...", prompt, desc);
            }

            //exit prompt
            Console.WriteLine("\nPress enter to continue...");
            Console.Read();
        }
    }
}
