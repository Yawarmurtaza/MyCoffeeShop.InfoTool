using MyCoffeeShop.InfoTool.Model;
using System;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    public interface ICoffeeShopDataProvider
    {
        IEnumerable<CoffeeShop> GetCoffeeShops();
    }
}
