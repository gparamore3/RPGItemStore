using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int gold = 100;
        Dictionary<string, int> storeItems = new Dictionary<string, int>()
        {
            { "Sword", 50 },
            { "Health Potion", 25 },
            { "Shield", 40 },
            { "Magic Ring", 70 }
        };

        Console.WriteLine("Welcome to the Adventurer's Item Shop!");
        Console.WriteLine($"You have {gold} gold.\n");

        while (true)
        {
            Console.WriteLine("Available items:");
            foreach (var item in storeItems)
            {
                Console.WriteLine($"{item.Key} - {item.Value} gold");
            }

            Console.WriteLine("\nType the name of the item to buy it, or type 'exit' to leave.");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "exit")
                break;

            if (storeItems.ContainsKey(choice))
            {
                int cost = storeItems[choice];
                if (gold >= cost)
                {
                    gold -= cost;
                    Console.WriteLine($"You bought a {choice}! Gold remaining: {gold}\n");
                }
                else
                {
                    Console.WriteLine("Not enough gold!\n");
                }
            }
            else
            {
                Console.WriteLine("That item is not in the shop.\n");
            }
        }

        Console.WriteLine("Thanks for visiting the shop!");
    }
}