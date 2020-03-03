/*Ryan Deleurme
 * 
 * This is a program that will simulate a game of war between two players. 
 * the game will keep going until a player has 0 cards, then the winnder and the rounds will be displayed at the end. 
 * 
 */

using System;

namespace Assignment6
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nameP1;
            string nameP2;

            Console.WriteLine("Player 1, what is your name?");
            nameP1 = Console.ReadLine();

            Console.WriteLine("Player 2, what is your name?");
            nameP2 = Console.ReadLine();

            War(nameP1,nameP2);
            
        }

        public static int Draw() //needs to return as int since that is the variable type we are returning, not void.
        {
            int num;
            Random r = new Random();
            num = r.Next(1, 11);

            return num;
        }

        public static void War(string nameP1, string nameP2)
        {
            int p1Cards = 26; //card decks
            int p2Cards = 26;
            int rounds = 0; //need this variable since i is scoped to the loop, we wont be able to retrieve the round counter

            for (int i = 0; p1Cards >= 1 && p2Cards >= 1; i++) //we need an && statement because if it was ||, the loop would never finish. >=1 because we need a player to reach 0 cards. > 0 would also work.
            {
                int p1Hand = Draw();
                int p2Hand = Draw();

                if (p1Hand > p2Hand)
                {
                    p2Cards -= 1; 
                    p1Cards += 1;
                    Console.WriteLine("{0}: {1}, {2}: {3}\n",nameP1, p1Hand, nameP2, p2Hand);
                    Console.WriteLine("{0} won the round!\n",nameP1);
                }
                else if (p1Hand == p2Hand)
                {
                    Console.WriteLine("{0}: {1}, {2}: {3}\n", nameP1, p1Hand, nameP2, p2Hand);
                    Console.WriteLine("Its a tie!\n");
                    continue; //skip this iteration of the loop
                }
                else //if player 2 wins
                {
                    p1Cards -= 1;
                    p2Cards += 1;
                    Console.WriteLine("{0}: {1}, {2}: {3}\n", nameP1, p1Hand, nameP2, p2Hand);
                    Console.WriteLine("{0} won the round!\n",nameP2);
                }
                rounds++; //count up our round counter so we can grab it for output at the end
                Console.WriteLine("{0}'s deck: {1}",nameP1, p1Cards);
                Console.WriteLine("{0}'s deck: {1}",nameP2, p2Cards);
            }

            if (p1Cards == 52)
            {
                Console.WriteLine("{0} won the game!\n", nameP1);
                Console.WriteLine("It only took {0} rounds...", rounds);
            }
            else
            {
                Console.WriteLine("{0} won the game!\n", nameP2);
                Console.WriteLine("It only took {0} rounds...", rounds);
            }
        }
    }
}
