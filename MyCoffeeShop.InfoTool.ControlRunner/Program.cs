using MyCoffeeShop.InfoTool.DataAccess;
using MyCoffeeShop.InfoTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCoffeeShop.InfoTool.ControlRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******************\n");
            Console.WriteLine("Welcome to My Coffee Shop Info Tool! - Im sure you will enjoy this!");            
            Console.WriteLine("Type help to list available commands, write quit to exit application.");
            Console.WriteLine("\n******************\n");
            ICoffeeShopDataProvider provider = new UkCoffeeShopDataProvider();

            string inputLine = string.Empty;
            IEnumerable<CoffeeShop> coffeeShopData = provider.GetCoffeeShops();

            while (!string.Equals(inputLine, "quit", StringComparison.OrdinalIgnoreCase))
            {
                inputLine = Console.ReadLine();
                

                if (string.Equals("help", inputLine, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands");
                    foreach (CoffeeShop nextShop in coffeeShopData)
                    {
                        Console.WriteLine($"> {nextShop.Location}");
                    }
                }
                else
                {
                    IEnumerable<CoffeeShop> matchedCoffeeShops = coffeeShopData.Where(c => c.Location.ToLower().StartsWith(inputLine.ToLower()));
                    if (!matchedCoffeeShops.Any())
                    {
                        Console.WriteLine("No matching command found! Please try again");
                    }
                    else
                    {
                        foreach (CoffeeShop coffeeShop in matchedCoffeeShops)
                        {
                            Console.WriteLine($"\nBeans in stock: {coffeeShop.BeansStockKg}\n{coffeeShop.Location}");
                        }
                    }
                }
            }
        }
    }
}
