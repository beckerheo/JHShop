namespace JH.JHShop.Data.Operator
{
    using JH.JHShop.Data.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="MockProductOperator" />
    /// </summary>
    public class MockProductOperator : IProductOperator
    {
        /// <summary>
        /// Defines the _products
        /// </summary>
        private readonly List<Product> _products = new List<Product>()
        {
            new Product{Name="Apple", ProductId=1, Description="This is an apple", RetailPrice=1m, WholesalePrice=0.8m},
            new Product{Name="Banana", ProductId=2, Description="This is a Banana", RetailPrice=1.2m, WholesalePrice=1m },
            new Product{Name="Orange", ProductId=3, Description="This is an Orange", RetailPrice=3m, WholesalePrice=1.5m },
            new Product{Name="Watermelon", ProductId=4, Description="This is a watermelon", RetailPrice=9m, WholesalePrice=7m },
            new Product{Name="Avocado", ProductId=5, Description="This is a Avocado", RetailPrice=2.7m, WholesalePrice=2m },
        };

        /// <summary>
        /// The AddProduct
        /// </summary>
        /// <param name="newProduct">The newProduct<see cref="Product"/></param>
        /// <returns>The <see cref="Product"/></returns>
        public Product AddProduct(Product newProduct)
        {
            if (newProduct == null)
            {
                throw new ArgumentNullException("No Product added!");
            }

            if (_products.Any(p => p.ProductId == newProduct.ProductId))
            {
                throw new ArgumentException($"Product Id:{newProduct.ProductId} already exists");
            }

            _products.Add(newProduct);

            return newProduct;
        }

        /// <summary>
        /// The CreateDiscount
        /// </summary>
        /// <param name="start">The start<see cref="DateTimeOffset"/></param>
        /// <param name="end">The end<see cref="DateTimeOffset"/></param>
        /// <param name="discountProducts">The discountProducts<see cref="List{Product}"/></param>
        public void CreateDiscount(DateTimeOffset start, DateTimeOffset end, List<Product> discountProducts)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="item">The item<see cref="Product"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool Delete(Product item)
        {
            if (_products.Any(p => p.ProductId == item.ProductId))
            {
                _products.RemoveAll(p => p.ProductId == item.ProductId);
                return true;
            }
            return false;
        }

        /// <summary>
        /// The DeleteById
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool DeleteById(int Id)
        {
            if (_products.Any(p => p.ProductId == Id))
            {
                _products.RemoveAll(p => p.ProductId == Id);
                return true;
            }
            return false;
        }

        /// <summary>
        /// The GetProductAll
        /// </summary>
        /// <returns>The <see cref="List{Product}"/></returns>
        public List<Product> GetProductAll()
        {
            return _products;
        }

        /// <summary>
        /// The GetProductById
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="Product"/></returns>
        public Product GetProductById(int Id)
        {
            return _products.First(p => p.ProductId == Id);
        }

        /// <summary>
        /// The UpdateProduct
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <param name="newProduct">The newProduct<see cref="Product"/></param>
        /// <returns>The <see cref="Product"/></returns>
        public Product UpdateProduct(int Id, Product newProduct)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == Id);
            PropertyInfo[] properties = newProduct.GetType().GetProperties();
            foreach (var pro in properties)
            {
                pro.SetValue(product, pro.GetValue(newProduct)); 
            }
            return product;
        }
    }
}
