using System;

class PizzaShop
{
    static Random random = new Random();

    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PlainPizza();
                    break;
                case "2":
                    CheesePizza();
                    break;
                case "3":
                    PepPizza();
                    break;
                case "4":
                    Console.WriteLine("Thank you for visiting Crimson Crust. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Crimson Crust Pizza Shop!");
        Console.WriteLine("1. Display a plain topping-less pizza slice");
        Console.WriteLine("2. Display cheese pizza slice");
        Console.WriteLine("3. Display pepperoni pizza slice");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    static void PlainPizza()
    {
        int rows = random.Next(8, 13);
        Console.WriteLine($"\nPlain Pizza Slice ({rows} rows):");

        for (int i = rows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void CheesePizza()
    {
        int rows = random.Next(8, 13);
        Console.WriteLine($"\nCheese Pizza Slice ({rows} rows):");

        for (int i = rows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (i == rows || j == 0 || j == i - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }

    static void PepPizza()
    {
        int rows = random.Next(8, 13);
        Console.WriteLine($"\nPepperoni Pizza Slice ({rows} rows):");

        for (int i = rows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (i == rows || j == 0 || j == i - 1)
                {
                    Console.Write("* ");
                }
                else if (random.Next(0, 5) == 0) 
                {
                    Console.Write("[] ");
                }
                else
                {
                    Console.Write("# ");
                }
            }
            Console.WriteLine();
        }
    }
}