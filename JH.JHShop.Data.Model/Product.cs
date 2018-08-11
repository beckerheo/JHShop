namespace JH.JHShop.Data.Model
{
    /// <summary>
    /// Defines the <see cref="Product" />
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ProductId
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the WholesalePrice
        /// </summary>
        public decimal WholesalePrice { get; set; }

        /// <summary>
        /// Gets or sets the RetailPrice
        /// </summary>
        public decimal RetailPrice { get; set; }

        public override string ToString()
        {
            return $"{ProductId}:{Name},--{Description}--, {RetailPrice}/each";
        }
    }
}
