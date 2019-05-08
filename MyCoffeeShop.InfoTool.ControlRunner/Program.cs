using MyCoffeeShop.InfoTool.DataAccess;
using MyCoffeeShop.InfoTool.Model;
using System;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.ControlRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******************\n");
            Console.WriteLine("Welcome to My Coffee Shop Info Tool!");            
            Console.WriteLine("Type help to list available commands, write quit to exit application.");
            Console.WriteLine("\n******************\n");
            ICoffeeShopDataProvider provider = new DefaultCoffeeShopDataProvider();

            string inputLine = string.Empty;
            while (!string.Equals(inputLine, "quit", StringComparison.OrdinalIgnoreCase))
            {
                inputLine = Console.ReadLine();
                IEnumerable<CoffeeShop> coffeeShopData = provider.GetCoffeeShops();

                if (string.Equals("help", inputLine, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands");
                    foreach (CoffeeShop nextShop in coffeeShopData)
                    {
                        Console.WriteLine($"> {nextShop.Location}");
                    }
                }
            }
        }
    }
}
