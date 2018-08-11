namespace JH.JHShop.Data.Operator
{
    using JH.JHShop.Data.Model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IProductOperator" />
    /// </summary>
    public interface IProductOperator
    {
        /*
         * Include all operations related to Products.
         */
        /// <summary>
        /// The GetProductById
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="Product"/></returns>
        Product GetProductById(int Id);

        /// <summary>
        /// The GetProductAll
        /// </summary>
        /// <returns>The <see cref="List{Product}"/></returns>
        List<Product> GetProductAll();

        /// <summary>
        /// The AddProduct
        /// </summary>
        /// <param name="newProduct">The newProduct<see cref="Product"/></param>
        /// <returns>The <see cref="Product"/></returns>
        Product AddProduct(Product newProduct);

        /// <summary>
        /// The UpdateProduct
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <param name="newProduct">The newProduct<see cref="Product"/></param>
        /// <returns>The <see cref="Product"/></returns>
        Product UpdateProduct(int Id, Product newProduct);

        /// <summary>
        /// The DeleteById
        /// </summary>
        /// <param name="Id">The Id<see cref="int"/></param>
        /// <returns>The <see cref="bool"/></returns>
        bool DeleteById(int Id);

        /// <summary>
        /// The Delete
        /// </summary>
        /// <param name="item">The item<see cref="Product"/></param>
        /// <returns>The <see cref="bool"/></returns>
        bool Delete(Product item);

        /// <summary>
        /// The CreateDiscount
        /// </summary>
        /// <param name="start">The start<see cref="DateTimeOffset"/></param>
        /// <param name="end">The end<see cref="DateTimeOffset"/></param>
        /// <param name="discountProducts">The discountProducts<see cref="List{Product}"/></param>
        void CreateDiscount(DateTimeOffset start, DateTimeOffset end, List<Product> discountProducts);
    }
}
