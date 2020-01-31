/*Ryan Deleurme
 * 
 * This is a program that asks a user for their name,the length and width of a rectangle, and the length of a square.
 * After accepting the inputs, the program will ouput the users name,area and perimeter of a rectangle, and the area and 
 * perimeter of a square.
 * 
 */

using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {   //declare variables for our inputs
            string Name;
            double recL;
            double recW;
            int squareL;


            //ask for all inputs from user

            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();

            Console.WriteLine("Length of a rectangle?");
            recL = Convert.ToDouble(Console.ReadLine()); //need to convert the numeric values since readline can only take strings

            Console.WriteLine("Width of a rectangle?");
            recW = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Length of a square?");
            squareL = Convert.ToInt32(Console.ReadLine());

            //Declare area and perimeter variables for calculations
            double areaRec;
            double perimRec;
            int areaSquare;
            int perimSquare;

            //Calculations
   
            //Rectangle calculations
            areaRec = recL * recW;
            perimRec = (recL * 2) + (recW * 2);

            //Square calculations
            areaSquare = squareL * squareL;
            perimSquare = squareL * 4;

            //outputs to user 

            Console.WriteLine(""); //blank line, could also use \n in the last WriteLine();
            Console.WriteLine("Hello {0},",Name);
            Console.WriteLine("The area of the rectangle is {0}, and the perimeter is {1}",areaRec,perimRec);
            Console.WriteLine("The area of the square is {0}, and the perimeter is {1}", areaSquare,perimSquare);

            //program end

        }
    }
}
