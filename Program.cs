using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert to Inches or Feet?");
            String typeOfItem = Console.ReadLine();
            Console.WriteLine("How many?");
            String amount = Console.ReadLine();
            int convertedNumber = 0;
            Int32.TryParse(amount, out convertedNumber);

            bool inchesResult = typeOfItem.Equals("Inches", StringComparison.OrdinalIgnoreCase);
            bool feetResult= typeOfItem.Equals("Feet", StringComparison.OrdinalIgnoreCase);


            if(inchesResult == true)
            {
                Console.WriteLine("Turning " + convertedNumber + " Inches to Feet...");
                Console.WriteLine(FeetToInches(convertedNumber));
            }
            else if (feetResult == true)
            {
                Console.WriteLine("Turning " + convertedNumber + " Feet to Inches");
                Console.WriteLine(InchesToFeet(convertedNumber));
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
            Console.WriteLine("Thanks for using this!");
        }
        static double FeetToInches(double feet)
        {
            return feet * 12;
        }
        static double InchesToFeet(double inches)
        {
            return inches / 12;
        }
    }
}
