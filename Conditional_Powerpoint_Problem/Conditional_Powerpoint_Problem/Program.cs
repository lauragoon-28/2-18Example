using System;

namespace Conditional_Powerpoint_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
        
            do
            {
             Console.WriteLine($"Please enter the # of miles >>");
             answer = Console.ReadLine();
             //double miles = Convert.ToDouble(answer);
             double miles;
             bool isSuccessful = double.TryParse(answer, out miles);

              if (isSuccessful == false)
              {
                Console.WriteLine("Invalid input. Goodbye");
                //return;
                Environment.Exit(-1);
              }

             Console.WriteLine($"Please enter the weight of your shipment (in lbs) >>");
             answer = Console.ReadLine();
             //double miles = Convert.ToDouble(answer);
             double weight;

             if (double.TryParse(answer, out weight) == false)
             {
                Console.WriteLine("Invalid input. Goodbye");
                //return;
                Environment.Exit(-2);
             }
             Console.WriteLine("Does your shipment contain hazardous material? Yes or no.");
             answer = Console.ReadLine();

             double quote = .55 * miles + .73 * weight;
             double hazardousCost;

             if (answer.ToLower() == "yes")
             {
                hazardousCost = .015 * weight;
             }
             else
             {
                hazardousCost = 0;
             }
             double netTotal = quote + hazardousCost;

             double discount = 0;
             if (miles < 150 && weight > 500)
             {
                discount = 0.10 * netTotal;
             }

             double total = netTotal - discount;

             Console.WriteLine();
             Console.WriteLine($"Quote: \t{quote.ToString("C")}");

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine($"Hazardous Cost: \t{hazardousCost.ToString("C")}");

             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine($"Discount: \t{discount.ToString("C")}");

             Console.ForegroundColor = ConsoleColor.White;
             Console.WriteLine($"Total: \t{total.ToString("C")}");

                Console.WriteLine("would you like to run this again >>");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            Console.WriteLine("\n\nGoodbye");
        }
    }
}
