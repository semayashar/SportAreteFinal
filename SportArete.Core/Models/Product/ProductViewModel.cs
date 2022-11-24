﻿namespace SportArete.Core.Models.Product
{
    public class ProductViewModel
    {
        /// <summary>
        /// View model for visualizing products while browsing the app.
        /// </summary>
        public int Id { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string ImageData { get; set; } //change to byte[]

        public string Category { get; set; }

        public string Brand { get; set; }
    }
}
