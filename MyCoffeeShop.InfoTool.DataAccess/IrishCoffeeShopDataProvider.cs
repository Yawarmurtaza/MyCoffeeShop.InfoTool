using MyCoffeeShop.InfoTool.Model;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    public class IrishCoffeeShopDataProvider : ICoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> GetCoffeeShops()
        {
            yield return new CoffeeShop { BeansStockKg = 1000, Location = "Dublin", PaperCupsInStock = 50 };
            yield return new CoffeeShop { BeansStockKg = 2000, Location = "Cork", PaperCupsInStock = 95 };
            yield return new CoffeeShop { BeansStockKg = 3000, Location = "Galway", PaperCupsInStock = 102 };
            yield return new CoffeeShop { BeansStockKg = 4000, Location = "Thurles", PaperCupsInStock = 120 };
            yield return new CoffeeShop { BeansStockKg = 3000, Location = "Dingle", PaperCupsInStock = 500 };
            yield return new CoffeeShop { BeansStockKg = 2500, Location = "Naas", PaperCupsInStock = 250 };
        }
    }
}
