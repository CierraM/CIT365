using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Name
            string name = "Cierra";
            string location = "Idaho";
            Console.WriteLine($"My name is {name}. I am from {location}.");

            ///Current Data
            var currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate.ToString("d")}");

            ///Days until Christmas
            var year = currentDate.Year;
            var christmas = new DateTime(year, 12, 25);
            var daysTilChristmas = Math.Round((christmas - currentDate).TotalDays);
            Console.WriteLine($"There are {daysTilChristmas} days until Christmas.");

            //GlazerCalc
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("What is the width of the wood in feet?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("What is the height of the wood in feet?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            ///Keep console open
            Console.Write("Press any key to quit.");
            Console.ReadKey();

        }
    }
}
