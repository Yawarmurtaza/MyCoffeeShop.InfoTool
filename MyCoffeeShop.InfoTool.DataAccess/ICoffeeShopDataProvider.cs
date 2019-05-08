using MyCoffeeShop.InfoTool.Model;
using System;
using System.Collections.Generic;

namespace MyCoffeeShop.InfoTool.DataAccess
{
    /// <summary>
    /// Provides the coffee shop's data. It supports all type of data for a coffee shop.
    /// </summary>
    public interface ICoffeeShopDataProvider
    {
        /// <summary>
        /// Gets the coffee shops with the data.
        /// </summary>
        /// <returns>Coffee shop collections.</returns>
        IEnumerable<CoffeeShop> GetCoffeeShops();
    }
}
