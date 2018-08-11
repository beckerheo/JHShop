namespace JH.JHShop.Data.Operator
{
    using JH.JHShop.Data.Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="MockShoppingCartOperator" />
    /// </summary>
    public class MockShoppingCartOperator : IShoppingCartOperator
    {
        /// <summary>
        /// Defines the _shoppingCart
        /// </summary>
        private ShoppingCart _shoppingCart = new ShoppingCart();

        /// <summary>
        /// The Create
        /// </summary>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        public ShoppingCart Create()
        {
            if (_shoppingCart == null)
            {
                _shoppingCart = new ShoppingCart();
            }
            return _shoppingCart;
        }

        /// <summary>
        /// The GetList
        /// </summary>
        /// <returns>The <see cref="List{ShoppingItems}"/></returns>
        public List<ShoppingItems> GetList()
        {
            return _shoppingCart.Items;
        }

        /// <summary>
        /// The Update
        /// </summary>
        /// <param name="item">The item<see cref="ShoppingItems"/></param>
        /// <returns>The <see cref="ShoppingCart"/></returns>
        public ShoppingCart Update(ShoppingItems item)
        {
            var cartItem = _shoppingCart.Items.FirstOrDefault(i => i.ProductId == item.ProductId);

            if (cartItem != null)
            {
                PropertyInfo[] properties = item.GetType().GetProperties();
                foreach (var pro in properties)
                {
                    pro.SetValue(cartItem, pro.GetValue(item));
                }

                if (cartItem.Units == 0)
                {
                    _shoppingCart.Items.Remove(cartItem);
                }
            }
            else
            {
                var newItem = new ShoppingItems();
                PropertyInfo[] properties = item.GetType().GetProperties();
                foreach (var pro in properties)
                {
                    if (pro.CanWrite)
                    {
                        pro.SetValue(newItem, pro.GetValue(item));
                    }
                }
                _shoppingCart.Items.Add(newItem);
            }
            return _shoppingCart;
        }
    }
}
