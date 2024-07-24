using System;

class Program
{
    public static void Main(string[] args)
    {
        const int TicketPrice = 25;

        // Display Greenville motto
        Console.WriteLine("**********************************");
        Console.WriteLine("* The stars shine in Greenville. *");
        Console.WriteLine("**********************************\n");

        // Display menu
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Calculate Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit\n");

        // Get user's choice
        Console.Write("Please enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // Get number of contestants for this year and last year
            Console.Write("Enter the number of contestants this year: ");
            int thisYearContestants = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of contestants last year: ");
            int lastYearContestants = int.Parse(Console.ReadLine());

            // Calculate expected revenue
            int expectedRevenue = thisYearContestants * TicketPrice;
            Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
            Console.WriteLine($"Revenue expected this year is ${expectedRevenue}");

            // Compare number of contestants
            if (thisYearContestants > 2 * lastYearContestants)
            {
                Console.WriteLine("The competition is more than twice as big this year!");
            }
          else if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("The competition is bigger than ever!");
            }
          else if (thisYearContestants < lastYearContestants)
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            }
          else
            {
              Console.WriteLine("This year's competition has the same number of contestants as last year.");
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please run the program again.");
        }
  }
}
