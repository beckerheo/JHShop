namespace JH.JHShop.Data.Operator
{
    using JH.JHShop.Data.Model;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IShoppingCartOperator" />
    /// </summary>
    public interface IShoppingCartOperator
    {
        /*
         * Include all shopping cart related operations.
         */
        /// <summary>
        /// The Create
        /// </summary>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        ShoppingCart Create();

        /// <summary>
        /// The GetList
        /// </summary>
        /// <returns>The <see cref="List{ShoppingItems}"/></returns>
        List<ShoppingItems> GetList();

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="item">The item<see cref="ShoppingItems"/></param>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        ShoppingCart Update(ShoppingItems item);
    }
}
