using MyCoffeeShop.InfoTool.Model;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    public class SpanishCoffeeShopDataProvider : ICoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> GetCoffeeShops()
        {
            yield return new CoffeeShop { BeansStockKg = 1000, Location = "Madrid", PaperCupsInStock = 50 };
            yield return new CoffeeShop { BeansStockKg = 2000, Location = "Barcelona", PaperCupsInStock = 95 };            
        }
    }
}
