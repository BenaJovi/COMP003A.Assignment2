/*  Author: Jovani Benavides
 *  Course: Comp-003A
 *  Purpose: This code take the users full name and shows what year they are born
 *  This code also takes two numbers and will do basic arithmetic with those two numbers.
 *  This code will take a radius of a circle and find the area and circumference
 */

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";                      //Lines 14-16 will change the output background and font color.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************");
            Console.WriteLine("String Section");
            Console.WriteLine("*********************************");
            Console.Write("Enter First Name:");                             // Lines 20-29 will take the users Full name and age in the year 2023 and will output the year they were born.
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

            Console.Write("Enter an number for Integer1:");                 // Lines 35-46 will ask the user to input two numbers 
            string integerone = Console.ReadLine();                         // and will then use basic arthimetic with those two numbers.
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

            Console.Write("Enter the radius:");                             // Lines 52-60 will ask the user for the radius of the circle 
            string inputradius = Console.ReadLine();                        // and will then find the area and circumference of that circle.
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
