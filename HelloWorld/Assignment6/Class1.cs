using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Class1
    {
        static void main()
        {
            int tS1 = 0;
            int tS2 = 0;
            int tS3 = 0;

            for (int i = 0; i < 13; i++)
            {
                int s1;
                int s2;
                int s3;
                int before;
                Random r = new Random();

                s1 = r.Next(10, 21);
                Console.Write("Squirrel 1 stashed: ");
                for(int j = 0; j < s1; j++)
                {
                    Console.Write("*");
                }

                s2 = r.Next(10, 21);
                Console.Write("Squirrel 2 stashed: ");
                for (int j = 0; j < s2; j++)
                {
                    Console.Write("*");
                }

                s3 = r.Next(10, 21);
                Console.Write("Squirrel 2 stashed: ");
                for (int j = 0; j < s2; j++)
                {
                    Console.Write("*");
                }

                tS1 += s1;
                tS2 += s2;
                tS3 += s3;


                before = 12-i;
                Console.WriteLine("total acrons for squirrel 1 {0}", tS1);
                Console.WriteLine("There are {0} weeks before winter!\n", before);
            }
        }
    }
}
