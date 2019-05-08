using MyCoffeeShop.InfoTool.Model;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    public class UkCoffeeShopDataProvider : ICoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> GetCoffeeShops()
        {
            yield return new CoffeeShop { BeansStockKg = 1000, Location = "Peterborough", PaperCupsInStock= 50 };
            yield return new CoffeeShop { BeansStockKg = 2000, Location = "Cambridge", PaperCupsInStock = 95 };
            yield return new CoffeeShop { BeansStockKg = 3000, Location = "Reading", PaperCupsInStock= 102 };
            yield return new CoffeeShop { BeansStockKg = 4000, Location = "London", PaperCupsInStock= 120 };
            yield return new CoffeeShop { BeansStockKg = 3000, Location = "Manchester", PaperCupsInStock = 500 };
            yield return new CoffeeShop { BeansStockKg = 2500, Location = "New Castle", PaperCupsInStock = 250 };
        }
    }
}
