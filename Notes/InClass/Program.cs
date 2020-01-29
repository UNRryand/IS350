using System;

namespace InClass
{
    class Program
    {
        static void Main()
        {
            double radius = 20;
            double pi = 3.14;
            double area;
            area = pi * radius * radius;
           
            Console.WriteLine(area);
            Console.WriteLine("the area of a circle with a radius of {0} is {1}", radius, area);
        }
    }
}
