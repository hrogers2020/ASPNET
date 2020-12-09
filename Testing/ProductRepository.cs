﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        //Constructor
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
                new { id = id });
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM product;");
        }
        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
                new { name = product.Name, price = product.Price, id = product.ProductID });

        }
        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO products (NAME, PRICE) VALUES (@name, @price);",
                new { name = productToInsert.Name, price = productToInsert.Price });
        }
        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM product;");
        }
        //public Product AssignCategory()
        //{
        //    var categoryList = GetCategories();
        //    var product = new Product();
        //    product.Categories = categoryList;

        //    return product;
        //}
        //public void DeleteProduct(Product product)
        //{
        //    _conn.Execute("DELETE FROM REVIEWS WHERE ProductID = @id;", new { id = product.ProductID });
        //    _conn.Execute("DELETE FROM Sales WHERE ProductID = @id;", new { id = product.ProductID });
        //    _conn.Execute("DELETE FROM Products WHERE ProductID = @id;", new { id = product.ProductID });
        //}


        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
