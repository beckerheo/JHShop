namespace JH.JHShop.Data.Operator
{
    using JH.JHShop.Data.Model;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IWishListOperator" />
    /// </summary>
    public interface IWishListOperator
    {
        /*
         * Include all operations related to wish list.
         */
        /// <summary>
        /// The Create
        /// </summary>
        /// <returns>The <see cref="WishList"/></returns>
        WishList Create();

        /// <summary>
        /// The GetList
        /// </summary>
        /// <returns>The <see cref="List{Product}"/></returns>
        List<Product> GetList();

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="item">The item<see cref="Product"/></param>
        /// <returns>The <see cref="WishList"/></returns>
        WishList Update(Product item);
    }
}
