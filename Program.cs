using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // No 2
            string myName = "Anu Lama";
            string myAddress = "Rexburg, ID";

            // No3
            Console.WriteLine($"my name is {myName} I live in {myAddress}");

            // No4
            var currentDate = DateTime.Now;
            Console.WriteLine($"Today's date is {currentDate.ToString("ddd, dd MMM yyy")}");

            // No5
            var christmasDay = new DateTime(currentDate.Year, 12, 25);
            var dayTillChristmas = currentDate - christmasDay;
            Console.WriteLine($"Days till christmass is {dayTillChristmas.ToString("dd")}");


            // No6
            double width, height, woodLength, glassArea; string widthString, heightString;
            Console.WriteLine("Please enter the width ");
            widthString = Console.ReadLine(); width = double.Parse(widthString);
            Console.WriteLine("Please enter the hight ");
            heightString = Console.ReadLine(); height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet"); Console.WriteLine("The area of the glass is " + glassArea + " square metres");


            // No 7
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
