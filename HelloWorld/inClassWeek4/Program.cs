using System;

namespace inClassWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;
            int chk = 0; // for checking int validation
            Random r = new Random();
            int num = r.Next(0, 10);
            Console.WriteLine(num); //cheating...

            Console.WriteLine("What is the random number?");
            guess = Console.ReadLine();

            if(Int32.TryParse(guess, out chk))
            {
                chk = Convert.ToInt32(guess);
            }
            else
            {
                Console.WriteLine("Please input a valid integer\n");
                Console.WriteLine("What is the random number?");
                guess = Console.ReadLine();

                chk = Convert.ToInt32(guess);
            }

            //check if the user guessed correctly
            if(num == chk)
            {
                Console.WriteLine("You are correct! The random number is {0}", num);
            }
            else
            {
                if (chk > num)
                {
                    Console.WriteLine("Sorry, the random number is {0}, not {1}...your answer was higher.", num, chk);
                }
                else
                {
                    Console.WriteLine("Sorry, the random number is {0}, not {1}...your answer was lower.", num, chk);
                }
            }
        }
    }
}
