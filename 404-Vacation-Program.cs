using System;
using System.Collections.Generic;

namespace AdventureTourApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- STEP 1: WELCOME MESSAGE AND TOUR SELECTION ---
            Console.WriteLine("WELCOME TO WILD TRAILS ADVENTURES");
            Console.WriteLine("\nChoose your adventure:");
            Console.WriteLine("1. City Walking Tour      $40");
            Console.WriteLine("2. Mountain Hiking Tour   $85");
            Console.WriteLine("3. Kayaking Tour         $110");
            Console.WriteLine("4. Wildlife Safari       $160");
            Console.Write("\nSelection: ");

            // Read what the user types on the keyboard (using string? to fix warnings)
            string? tourChoice = Console.ReadLine();

            string selectedTourName = "";
            double selectedTourPrice = 0;

            if (tourChoice == "1")
            {
                selectedTourName = "City Walking Tour";
                selectedTourPrice = 40.00;
            }
            else if (tourChoice == "2")
            {
                selectedTourName = "Mountain Hiking Tour";
                selectedTourPrice = 85.00;
            }
            else if (tourChoice == "3")
            {
                selectedTourName = "Kayaking Tour";
                selectedTourPrice = 110.00;
            }
            else if (tourChoice == "4")
            {
                selectedTourName = "Wildlife Safari";
                selectedTourPrice = 160.00;
            }
            else
            {
                selectedTourName = "City Walking Tour";
                selectedTourPrice = 40.00;
            }


            // --- STEP 2: UPGRADE SELECTION LOOP ---
            // DECLARE THESE HERE so the compiler knows they exist!
            List<string> selectedUpgrades = new List<string>();
            List<double> upgradePrices = new List<double>();
            int upgradeChoice = 0;

            // A 'while' loop keeps asking the user for upgrades until they choose '7' to finish.
            while (upgradeChoice != 7)
            {
                Console.Clear(); // Clears the screen to keep things clean
                Console.WriteLine("Customize your adventure:");
                Console.WriteLine("1. Professional Photographer  +$75");
                Console.WriteLine("2. Private Guide               +$100");
                Console.WriteLine("3. Lunch Package               +$25");
                Console.WriteLine("4. Equipment Rental            +$40");
                Console.WriteLine("5. Transportation              +$35");
                Console.WriteLine("6. Travel Insurance            +$20");
                Console.WriteLine("7. Finish");
                Console.Write("\nSelection: ");

                string? input = Console.ReadLine();
                int.TryParse(input, out upgradeChoice);

                // Add the right upgrade based on their choice and pause so you can see it
                if (upgradeChoice == 1)
                {
                    selectedUpgrades.Add("Professional Photographer");
                    upgradePrices.Add(75.00);
                    Console.WriteLine("Added: Professional Photographer!");
                    System.Threading.Thread.Sleep(1000);
                }
                else if (upgradeChoice == 2)
                {
                    selectedUpgrades.Add("Private Guide");
                    upgradePrices.Add(100.00);
                    Console.WriteLine("Added: Private Guide!");
                    System.Threading.Thread.Sleep(1000);
                }
                else if (upgradeChoice == 3)
                {
                    selectedUpgrades.Add("Lunch Package");
                    upgradePrices.Add(25.00);
                    Console.WriteLine("Added: Lunch Package!");
                    System.Threading.Thread.Sleep(1000);
                }
                else if (upgradeChoice == 4)
                {
                    selectedUpgrades.Add("Equipment Rental");
                    upgradePrices.Add(40.00);
                    Console.WriteLine("Added: Equipment Rental!");
                    System.Threading.Thread.Sleep(1000);
                }
                else if (upgradeChoice == 5)
                {
                    selectedUpgrades.Add("Transportation");
                    upgradePrices.Add(35.00);
                    Console.WriteLine("Added: Transportation!");
                    System.Threading.Thread.Sleep(1000);
                }
                else if (upgradeChoice == 6)
                {
                    selectedUpgrades.Add("Travel Insurance");
                    upgradePrices.Add(20.00);
                    Console.WriteLine("Added: Travel Insurance!");
                    System.Threading.Thread.Sleep(1000);
                }
            }


            // --- STEP 3: PRINT THE FINAL RECEIPT / RESULT ---
            Console.Clear();
            Console.WriteLine("YOUR ADVENTURE\n");

            Console.WriteLine(selectedTourName);

            foreach (string upgrade in selectedUpgrades)
            {
                Console.WriteLine(" + " + upgrade);
            }

            Console.WriteLine();

            Console.WriteLine($"{selectedTourName,-25} ${selectedTourPrice:F2}");

            double totalCost = selectedTourPrice;

            for (int i = 0; i < selectedUpgrades.Count; i++)
            {
                Console.WriteLine($"{selectedUpgrades[i],-25} ${upgradePrices[i]:F2}");
                totalCost += upgradePrices[i];
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"TOTAL:                    ${totalCost:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 