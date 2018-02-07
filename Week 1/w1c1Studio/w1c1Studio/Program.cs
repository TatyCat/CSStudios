using System;

namespace Area
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            /*
             1. User input a number
             2. Check if the number is greater than / = 0
             3. if it IS: continue with the program
             4. If it is NOT: loop until the number is greater than 0
             */

            //User inputs number
            Console.WriteLine("Provide a number for radius to calculate the area of your circle");
            string inputRad = Console.ReadLine();

            //convert the input into a number
            decimal radius = decimal.Parse(inputRad);
            
            //Re-prompt if number is negative
            while(radius<0)
            {
                Console.WriteLine("Provide a positive number for radius");
                string input = Console.ReadLine();
                radius = decimal.Parse(input);
            }

            //Calculates the area of a circle with the radius input
            decimal pi = 3.14m;
            decimal area = pi * radius * radius;

            //Output
            Console.WriteLine($"The area of your circle is {area}");
            Console.ReadLine();
        }
    }
}


/*
 *Bonus Mission #2:
 Extend your program further by using a while or do-while loop, so that when the user enters a negative number they are re-prompted. 
 */
