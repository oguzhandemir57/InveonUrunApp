using InveonUrunApp.Entities;
using InveonUrunApp.Entities.ProductDependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.BusinessOperators
{
    public class HomeOperator
    {
        ProductService product = new ProductService(new ProductFactory());

        public List<Product> GetProductList()
        {
           var productList = product.GetProductList();
            return productList;
        } 
        
        public ResponseBaseEntity AdminCheck(string userName)
        {
            var adminCheck = product.AdminCheck(userName);
            return adminCheck;
        }

        public ProductDetail GetProductDetail(int Id)
        {
            var products = product.GetProductDetail(Id);
            return products;
        }

        public Product InsertProduct(Product products)
        {
            var result = product.ProductsAdd(products);
            return result;
        }

        public ResponseBaseEntity ProductsDetailAdd(ProductDetail products)
        {
            var result = product.ProductsDetailAdd(products);
            return result;
        }
        public ResponseBaseEntity UpdateProductDetail(ProductDetail products)
        {
            var result = product.UpdateProductDetail(products);
            return result;
        }
        public ResponseBaseEntity DeleteProduct(int Id)
        {
            var products = product.DeleteProduct(Id);
            return products;
        }
    }
}