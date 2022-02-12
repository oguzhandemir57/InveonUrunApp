using InveonUrunApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities.ProductDependency
{
    public class ProductManager : IProducts
    {
        public Product ProductsAdd(Product product)
        {
            var products = new HomeLogic().ProductsAdd(product);
            return products;
        }

        public ResponseBaseEntity ProductsDetailAdd(ProductDetail productDetail)
        {
            var products = new HomeLogic().ProductsDetailAdd(productDetail);
            return products;
        }

        public List<Product> GetProductList()
        {
            var productList = new HomeLogic().GetProductList();
            return productList;
        }

        public ProductDetail GetProductDetail(int Id)
        {
            var product= new HomeLogic().GetProductDetail(Id);
            return product;
        }

        public ResponseBaseEntity UpdateProductDetail(ProductDetail product)
        {
            var products = new HomeLogic().UpdateProductDetail(product);
            return products;
        }
        public ResponseBaseEntity DeleteProduct(int id)
        {
            var products = new HomeLogic().DeleteProduct(id);
            return products;
        }
    }
}