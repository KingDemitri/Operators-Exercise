using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {


        static void Main(string[] args)
        {
            {   //Exercise 1
                Console.WriteLine("Hello, World!");

                int a = 17;
                int b = 4;

                int quotient = a / b;
                int remainder = a % b;

                if (a == 17 && b == 4)
                {
                    Console.WriteLine($"{a} / {b} is 4 remainder 1");
                }

            }

            {     //Exercise 2
                
                Console.WriteLine("What is the radius of your circle?");
                var radius = double.Parse(Console.ReadLine());

                AreaOfCircle(radius);
                Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
            }
            static double AreaOfCircle(double radius)

            {
                var area = (Math.PI * radius * radius);
                return area;
            } //For some reason, when I had this method in its own class (Methods.cs) it wouldn't read it here.
              //I think it wasn't reading it in the correct order so it didn't "See" it, but I couldn't figure out a way to make it work.

        }
    } 
}
