namespace JH.JHShop.Data.Operator
{
    using JH.JHShop.Data.Model;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="MockWishListOperator" />
    /// </summary>
    public class MockWishListOperator : IWishListOperator
    {
        /// <summary>
        /// Defines the _wishList
        /// </summary>
        private WishList _wishList = new WishList();

        /// <summary>
        /// The Create
        /// </summary>
        /// <returns>The <see cref="WishList"/></returns>
        public WishList Create()
        {
            if (_wishList == null)
            {
                _wishList = new WishList();
            }
            return _wishList;
        }

        /// <summary>
        /// The GetList
        /// </summary>
        /// <returns>The <see cref="List{Product}"/></returns>
        public List<Product> GetList()
        {
            return _wishList.ProductList;
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="item">The item<see cref="Product"/></param>
        /// <returns>The <see cref="WishList"/></returns>
        public WishList Update(Product item)
        {
            if (_wishList.ProductList.Exists(p => p.ProductId == item.ProductId))
            {
                var wishProduct = _wishList.ProductList.FirstOrDefault(p => p.ProductId == item.ProductId);
                _wishList.ProductList.Remove(wishProduct);
            }
            else
            {
                _wishList.ProductList.Add(item);
            }

            return _wishList;
        }
    }
}
