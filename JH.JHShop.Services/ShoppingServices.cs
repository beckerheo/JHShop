namespace JH.JHShop.Services
{
    using JH.JHShop.Data.Model;
    using JH.JHShop.Data.Operator;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="ShoppingServices" />
    /// </summary>
    public class ShoppingServices
    {
        /// <summary>
        /// Defines the _productOperator
        /// </summary>
        private readonly IProductOperator _productOperator = new MockProductOperator();

        /// <summary>
        /// Defines the _shoppingCartOperator
        /// </summary>
        private readonly IShoppingCartOperator _shoppingCartOperator = new MockShoppingCartOperator();
        private readonly IWishListOperator _wishListOperator = new MockWishListOperator();

        /// <summary>
        /// The GetAllProducts
        /// </summary>
        /// <returns>The <see cref="List{Product}"/></returns>
        public List<Product> GetAllProducts()
        {
            return _productOperator.GetProductAll();
        }

        /// <summary>
        /// The CreateShoppingCart
        /// </summary>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        public ShoppingCart CreateShoppingCart()
        {
            return _shoppingCartOperator.Create();
        }

        public void ListingShoppingCart()
        {
            var cartList = _shoppingCartOperator.GetList();
            Console.WriteLine("Your shopping cart has,");
            cartList.ForEach(si =>
            {
                var prod = _productOperator.GetProductById(si.ProductId);
                Console.WriteLine($"{prod.ProductId}:{prod.Name}--{si.UnitPrice}.each--Units={si.Units}--Total Price={si.TotalPrice}");
            });
        }

        /// <summary>
        /// The AddToCart
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <param name="units">The units<see cref="int"/></param>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        public ShoppingCart AddToCart(int productId, int units = 1)
        {
            Product product = _productOperator.GetProductById(productId);

            ShoppingItems item = new ShoppingItems()
            {
                ProductId = productId,
                Units = units,
                UnitPrice = product.RetailPrice
            };

            return _shoppingCartOperator.Update(item);
        }

        /// <summary>
        /// The UpdateCart
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <param name="units">The units<see cref="int"/></param>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        public ShoppingCart UpdateCart(int productId, int units = 1)
        {
            Product product = _productOperator.GetProductById(productId);

            List<ShoppingItems> cartList = _shoppingCartOperator.GetList();

            var old = cartList.FirstOrDefault(si => si.ProductId == productId);
            if (old != null)
            {
                old.Units = units;
            }
            else
            {
                throw new ArgumentException("This product has not been added to cart yet.");
            }

            return _shoppingCartOperator.Update(old);
        }

        /// <summary>
        /// The RemoveFromCart
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        public ShoppingCart RemoveFromCart(int productId)
        {
            ShoppingItems item = new ShoppingItems()
            {
                ProductId = productId,
                Units = 0
            };

            return _shoppingCartOperator.Update(item);
        }

        public void ListingWishList()
        {
            var wishList = _wishListOperator.GetList();
            Console.WriteLine("Your wish List has,");
            wishList.ForEach(si =>
            {
                var prod = _productOperator.GetProductById(si.ProductId);
                Console.WriteLine($"{prod.ProductId},{prod.Name},{si.RetailPrice}");
            });
        }

        /// <summary>
        /// The AddToWishList
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <returns>The <see cref="WishList"/></returns>
        public List<Product> AddToWishList(int productId)
        {
            Product product = _productOperator.GetProductById(productId);

            if(product!=null)
            {
                _wishListOperator.Update(product);
            }
            return _wishListOperator.GetList();
        }

        /// <summary>
        /// The RemoveFromWishList
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool RemoveFromWishList(int productId)
        {
            var list = _wishListOperator.GetList();
            if (list.Exists(p => p.ProductId == productId))
            {
                _wishListOperator.Update(new Product() { ProductId = productId });
            }
            return true;
        }
    }
}
