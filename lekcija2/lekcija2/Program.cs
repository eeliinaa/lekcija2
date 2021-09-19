using System;

namespace lekcija2
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterNumberQuestion = "Enter a number";
            string enterNumber2Question = "Enter one more number";

            string question = "Hey! What is your name?";
            Console.WriteLine(question);

            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "!");

            //=====

            string ageQuestion = "How old are you?";
            Console.WriteLine(ageQuestion);

            string age = Console.ReadLine();
            int ageNr = int.Parse(age);
            Console.WriteLine("Next year you will be " + (ageNr + 1) + "!");

            //=====

            Console.WriteLine(enterNumberQuestion);
            string nr1 = Console.ReadLine();
            int nr1int = int.Parse(nr1);

            Console.WriteLine(enterNumber2Question);
            string nr2 = Console.ReadLine();
            int nr2int = int.Parse(nr2);

            int largerstNr = Math.Max(nr1int, nr2int);

            Console.WriteLine(largerstNr + " is bigger.");

            //=====

            Console.WriteLine(enterNumberQuestion);
            string nr3 = Console.ReadLine();
            int nr3int = int.Parse(nr3);

            Console.WriteLine(enterNumber2Question);
            string nr4 = Console.ReadLine();
            int nr4int = int.Parse(nr4);

            int smallestNr = Math.Min(nr3int, nr4int);

            Console.WriteLine(smallestNr + " is smaller.");

            //=====

            Console.WriteLine(enterNumberQuestion);
            string d1 = Console.ReadLine();
            int d1int = int.Parse(d1);

            Console.WriteLine(enterNumber2Question);
            string d2 = Console.ReadLine();
            int d2int = int.Parse(d2);

            Console.WriteLine("This is what is left over: " + d1int % d2int);

            //=====

            Console.WriteLine(enterNumberQuestion);
            string oddEvenNr = Console.ReadLine();
            int oddEvenint = int.Parse(oddEvenNr);
            bool isOdd = oddEvenint % 2 != 0;
            string type = isOdd ? "odd" : "even";

            Console.WriteLine("Your number is " + type);

            //=====

            Console.WriteLine("Enter rectangle length");
            string rectLength = Console.ReadLine();
            decimal rectLInt = decimal.Parse(rectLength);

            Console.WriteLine("Enter rectangle width");
            string rectWidth = Console.ReadLine();
            decimal rectWInt = decimal.Parse(rectWidth);

            decimal rectArea = rectLInt * rectWInt;
            float answer = (float)System.Math.Round(rectArea, 2);
            Console.WriteLine($"Rectangle area is: {answer}");

            //=====

            Console.WriteLine("Enter triangle side length");
            float side = float.Parse(Console.ReadLine());
            float root = (float)Math.Sqrt(3) / 4;
            float area = root * side * side;

            Console.WriteLine("Area of Equilateral Triangle is:" + area);

            //=====

            // $"Hello {author} !";
            Console.WriteLine("How old are you?");
            string old = Console.ReadLine();
            Console.WriteLine($"Your name: {userName}; Your age: {old}");

        }
    }
}
