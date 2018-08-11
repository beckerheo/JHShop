namespace JH.JHShop.Data.Model
{
    /// <summary>
    /// Defines the <see cref="ShoppingItems" />
    /// </summary>
    public class ShoppingItems
    {
        /// <summary>
        /// Gets or sets the ProductId
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the Units
        /// </summary>
        public int Units { get; set; }

        /// <summary>
        /// Gets or sets the UnitPrice
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets the TotalPrice
        /// </summary>
        public decimal TotalPrice
        {
            get
            {
                return UnitPrice * Units;   //Calculated by the UnitPrice and Units all the time.
            }
        }
    }
}
