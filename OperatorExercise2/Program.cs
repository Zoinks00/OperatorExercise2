using System;

namespace OperatorExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // prompt user for input
            Console.WriteLine("Please enter a radius for a circle to find its area.");
            var radius = double.Parse(Console.ReadLine());
            //call method to perform calculation
            AreaOfCircle(radius);

            //print result using input with method to cmd window
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle ( double r )
        {
            // PI unable to use alone, needs MATH. added before to allow 
            //use of PI to solve area of circle
            // formula used Area = PI * r^2
            double Area = Math.PI * (r * r);

            return Area;
        }
    }
}
