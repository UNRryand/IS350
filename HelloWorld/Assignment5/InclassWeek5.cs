using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class InclassWeek5
    {
        public static void main()
        {
            double iStock;
            int days;
            Random r = new Random();

            Console.WriteLine("What is the initial value of the stock?");
            iStock = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the initial value of the stock?");
            days = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < days;i++)
            {
                int rand;
                rand = r.Next(0, 2);
                if(rand == 1)
                {
                    iStock = iStock * 1.03;
                    Console.WriteLine("Stock went up! New value of stockis  {0}",iStock);
                }
                else
                {
                    iStock = iStock * .97;
                    Console.WriteLine("Stock went down :( New value of stock is {0}", iStock);
                }
            }
        }
    }
}
