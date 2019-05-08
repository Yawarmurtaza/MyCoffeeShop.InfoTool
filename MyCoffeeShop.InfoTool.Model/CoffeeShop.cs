using System;

namespace MyCoffeeShop.InfoTool.Model
{
    /// <summary>
    /// Defines the coffee shop.
    /// </summary>
    public class CoffeeShop
    {
        /// <summary>
        /// Gets or sets the location of the coffee shop.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or set the coffee beans in stock in KG.
        /// </summary>
        public int BeansStockKg { get; set; }

        /// <summary>
        /// Gets or sets the number of paper cups in stock.
        /// </summary>
        public int PaperCupsInStock { get; set; }

        public CoffeeShopRating Rating { get; set; }
    }
}
