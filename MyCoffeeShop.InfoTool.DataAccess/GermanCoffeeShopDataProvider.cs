using MyCoffeeShop.InfoTool.Model;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    public class GermanCoffeeShopDataProvider : ICoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> GetCoffeeShops()
        {
            yield return new CoffeeShop { BeansStockKg = 100, Location = "Barlin", PaperCupsInStock = 89, Rating = CoffeeShopRating.Satisfacotry };
            yield return new CoffeeShop { BeansStockKg = 500, Location = "Hamburg", PaperCupsInStock = 99, Rating = CoffeeShopRating.VeryGood };
            yield return new CoffeeShop { BeansStockKg = 200, Location = "Frankfurt", PaperCupsInStock = 55, Rating = CoffeeShopRating.Good };
        }
    }
}
