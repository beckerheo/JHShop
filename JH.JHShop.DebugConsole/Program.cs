using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JH.JHShop.Services;

namespace JH.JHShop.DebugConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShoppingServices ss = new ShoppingServices();

            var allProducts = ss.GetAllProducts();

            var shoppingCart = ss.CreateShoppingCart();

            do
            {
                allProducts.ForEach(p => { Console.WriteLine(p.ToString()); });

                ss.AddToCart(2, 4);
                ss.ListingShoppingCart();

                ss.AddToWishList(4);
                ss.ListingWishList();

                break;
            } while (true);

            Console.ReadLine();
        }
    }
}
