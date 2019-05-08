using MyCoffeeShop.InfoTool.Model;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    public class UkCoffeeShopDataProvider : ICoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> GetCoffeeShops()
        {
            yield return new CoffeeShop { BeansStockKg = 1000, Location = "Peterborough" };
            yield return new CoffeeShop { BeansStockKg = 2000, Location = "Cambridge" };
            yield return new CoffeeShop { BeansStockKg = 3000, Location = "Reading" };
            yield return new CoffeeShop { BeansStockKg = 4000, Location = "London" };
        }
    }
}
