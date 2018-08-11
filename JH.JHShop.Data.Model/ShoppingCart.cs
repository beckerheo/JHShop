namespace JH.JHShop.Data.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ShoppingCart" />
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the Items
        /// </summary>
        public List<ShoppingItems> Items { get; set; } = new List<ShoppingItems>();

        /// <summary>
        /// Gets or sets the CreateTime
        /// </summary>
        public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;
    }
}
