using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Security.Principal;

class Program
{
    /* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            // Please write down your name first. 
            Console.WriteLine("My name is Briana England. My OU 4x4 is engl0104, and my GitHub account name is @BrianaEngland. \n");

            Console.WriteLine("=== While Loop, Do-while Loop, For Loop ===");
            Console.WriteLine("1) Smart Checkout System");
            Console.WriteLine("2) Password Cracker");
            Console.WriteLine("3) Rocket Launch Pad");
            Console.WriteLine("0) Exit");
            Console.Write("\nSelect an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                grocery_checkout();
            }
            else if (input == "2")
            {
                password_cracker();
            }
            else if (input == "3")
            {
                launchpad();
            }
            else if (input == "0")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }

    // --- Question 1 ---
    static void grocery_checkout()
    {
        Console.Clear();
        Console.WriteLine("--- Smart Checkout System ---");

        // Part 1: Declare variables
        double totalPrice = 0;
        double itemPrice;
        int managerPin = 1234;
        int enteredPin;

        // Ask for first item price
        Console.Write("Enter item price (enter 0 to finish): ");
        itemPrice = Convert.ToDouble(Console.ReadLine());

        // Part 2: While loop
        while (itemPrice != 0)
        {
            // Check if item requires manager approval
            if (itemPrice >= 100)
            {
                Console.WriteLine("Manager approval required for high-value item.");
                Console.Write("Manager, please enter your 4-digit override code: ");
                enteredPin = Convert.ToInt32(Console.ReadLine());

                if (enteredPin == managerPin)
                {
                    totalPrice = totalPrice + itemPrice;
                    Console.WriteLine("Correct PIN. Item is approved and added.");
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Item is rejected and not added.");
                }
            }
            else
            {
                totalPrice = totalPrice + itemPrice;
            }

            // Ask for next item price
            Console.Write("\nEnter item price (enter 0 to finish): ");
            itemPrice = Convert.ToDouble(Console.ReadLine());
        }

        // Part 3: Display total
        Console.WriteLine($"\nFinal receipt total: ${totalPrice:F2}");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Question 2 ---
    static void password_cracker()
    {
        Console.Clear();
        Console.WriteLine("--- Password Cracker ---");

        // Part 1: Declare variables
        string correctPassword = "mis3013isgreat!";
        string enteredPassword;
        int attemptsUsed = 0;
        int maxAttempts = 3;
        bool isAccessGranted = false;

        // Part 2: Do-while loop
        do
        {
            Console.Write("Enter password: ");
            enteredPassword = Console.ReadLine();

            if (enteredPassword == correctPassword)
            {
                Console.WriteLine("Access Granted.");
                isAccessGranted = true;
            }
            else
            {
                attemptsUsed++;

                if (attemptsUsed < maxAttempts)
                {
                    Console.WriteLine($"Incorrect password. Attempts remaining: {maxAttempts - attemptsUsed}");
                }
            }

        } while (!isAccessGranted && attemptsUsed < maxAttempts);

        // Part 3: Lockdown message if failed all attempts
        if (!isAccessGranted)
        {
            Console.WriteLine("Security Lockdown Initiated!");
        }

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Question 3 ---
    static void launchpad()
    {
        Console.Clear();
        Console.WriteLine("---  Launchpad ---\n");

        // Part 1: Countdown loop
        for (int counter = 10; counter >= 1; counter--)
        {
            Console.WriteLine(counter);

            if (counter == 7)
            {
                Console.WriteLine("[SYSTEM]: Checking fuel levels... OK.");
            }

            if (counter == 4)
            {
                Console.WriteLine("[SYSTEM]: Oxygen pressure... stabilized.");
            }

            if (counter == 1)
            {
                Console.WriteLine("[SYSTEM]: Ignition sequence... START.");
            }

            // Small delay so countdown looks realistic
            System.Threading.Thread.Sleep(500);
        }

        // Blast off message
        Console.WriteLine("0 - BLAST OFF!");

        // Part 2: Draw rocket
        Console.WriteLine("   |   ");
        Console.WriteLine("  / \\  ");
        Console.WriteLine(" / _ \\ ");
        Console.WriteLine(" | | | ");
        Console.WriteLine(" |(R)| ");
        Console.WriteLine(" |___| ");
        Console.WriteLine("  V V  ");

        // Part 3: Rocket animation loop
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("   |   ");
            Console.WriteLine("  / \\  ");
            Console.WriteLine(" / _ \\ ");
            Console.WriteLine(" | | | ");
            Console.WriteLine(" |(R)| ");
            Console.WriteLine(" |___| ");
            Console.WriteLine("  V V  ");

            Console.WriteLine("\n\n"); // pushes rocket upward visually
            System.Threading.Thread.Sleep(100);
        }

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}

