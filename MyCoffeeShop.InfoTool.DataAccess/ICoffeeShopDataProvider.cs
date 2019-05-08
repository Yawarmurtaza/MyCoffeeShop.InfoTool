﻿using MyCoffeeShop.InfoTool.Model;
using System;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    public interface ICoffeeShopDataProvider
    {
        IEnumerable<CoffeeShop> GetCoffeeShops();
    }

    public class DefaultCoffeeShopDataProvider : ICoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> GetCoffeeShops()
        {
            yield return new CoffeeShop { BeansStockKg = 100, Location = "Karachi" };
            yield return new CoffeeShop { BeansStockKg = 500, Location = "Thatta" };
            yield return new CoffeeShop { BeansStockKg = 200, Location = "Hyderabad" };
        }
    }
}
