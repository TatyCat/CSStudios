using System;

namespace Area
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            //tell the user to enter a radius
            Console.WriteLine("Provide a number for radius");

            string inputRad = Console.ReadLine();

            //convert the input into a number
            decimal radius = decimal.Parse(inputRad);

            //Validation: Not a negative number
            if (radius >= 0)
            {
                //Calculates the area of a circle with the radius input
                decimal pi = 3.14m;
                decimal area = pi * radius * radius;

                //Output
                Console.WriteLine($"The area of your circle is {area}");
                Console.ReadLine();
            }
            else
            { 
                Console.WriteLine("Input cannot be a negative number. Sorry, try again later.");
                Console.ReadLine();
            }
        }
    }
}

/*
 *Bonus Mission #2:
 Add validation to your program. If the user enters a negative number, print an error message and quit.
 */
