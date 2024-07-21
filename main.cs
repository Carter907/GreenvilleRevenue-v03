using System;

class Program
{
    public static void Main(string[] args)
    {

        string input;
        do
        {
            printMenu();
            input = Console.ReadLine();

            if (input == "1")
            {
                printResults();
            }

        } while (input != "2");

        Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
    }
    static void printMenu()
    {
        Console.WriteLine(
                      @"************************************
*  The stars shine in Greenville.  *
************************************

Please Enter the following number below from the following menu:

1. CALCULATE Greenville Revenue Year-Over-Year
2. Exit
      ");

    }
    static void printResults()
    {
        Console.WriteLine("Please enter the contestants for the previous year");
        var previousYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the contestants for this year");
        var currYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", previousYear, currYear);
        Console.WriteLine("Revenue expected this year is {0:C0}", currYear * 25);

        if (currYear > previousYear) {
            if (currYear > 2 * previousYear) {
              Console.WriteLine("The competition is more than twice as big this year!");
            }
            Console.WriteLine("The competition is bigger than ever!");
          } else {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
          }
    }
}