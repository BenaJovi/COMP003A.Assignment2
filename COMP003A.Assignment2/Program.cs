/*  Author: Jovani Benavides
 *  Course: Comp-003A
 *  Purpose: Lecture assignment1 100 things about me 
 */

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************");
            Console.WriteLine("String Section");
            Console.WriteLine("*********************************");
            Console.Write("Enter First Name:");
            string FirstName = Console.ReadLine();
            Console.Write("Enter Middle Name:");
            string MiddleName = Console.ReadLine();
            Console.Write("Enter Last Name:");
            string LastName = Console.ReadLine();
            Console.Write("Enter Age In 2023:");
            string InputAge = Console.ReadLine();
            int YearBorn = 2023 - Convert.ToInt32(InputAge);
            Console.WriteLine($"Hello, {FirstName} {MiddleName} {LastName}. You were born in {YearBorn}.");

            Console.WriteLine("*********************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("*********************************");

            Console.Write("Enter an number for Integer1:");
            string integerone = Console.ReadLine();
            int integer1 = Convert.ToInt32(integerone);
            Console.Write("Enter an number for Integer2:");
            string integertwo = Console.ReadLine();
            int integer2 = Convert.ToInt32(integertwo);

            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

            Console.WriteLine("*********************************");
            Console.WriteLine("Circle Area & Circumfrence Calculator Section");
            Console.WriteLine("*********************************");

            Console.Write("Enter the radius:");
            string inputradius = Console.ReadLine();
            double radius = Convert.ToDouble(inputradius);
            double area = Math.PI * Math.Pow(radius, 2);
            Console.Write("The area is: ");
            Console.WriteLine(area);
            Console.Write("The circumference is: ");
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine(circumference);





        }

    }
}
