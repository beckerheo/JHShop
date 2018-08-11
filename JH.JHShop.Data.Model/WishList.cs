namespace JH.JHShop.Data.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="WishList" />
    /// </summary>
    public class WishList
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ProductList
        /// </summary>
        public List<Product> ProductList { get; set; } = new List<Product>();

        /// <summary>
        /// Gets or sets the AddTime
        /// </summary>
        public DateTimeOffset AddTime { get; set; }
    }
}
