using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities.ProductDependency
{
    public class ProductService
    {
        IProductsFactory _productFactory;

        public ProductService(IProductsFactory productsFactory)
        {
            _productFactory = productsFactory;
        }

        public Product ProductsAdd(Product product)
        {
            var products = _productFactory.Products();
            var result = products.ProductsAdd(product);

            return result;
        }

        public ResponseBaseEntity ProductsDetailAdd(ProductDetail productDetail)
        {
            var productDetails = _productFactory.Products();
            var result = productDetails.ProductsDetailAdd(productDetail);
            return result;
        }
         public ResponseBaseEntity UpdateProductDetail(ProductDetail productDetail)
        {
            var productDetails = _productFactory.Products();
            var result = productDetails.UpdateProductDetail(productDetail);
            return result;
        }

        public List<Product> GetProductList()
        {
            var productDetails = _productFactory.Products();
            var result = productDetails.GetProductList();
            return result;
        }
        
        public ProductDetail GetProductDetail(int Id)
        {
            var product = _productFactory.Products();
            var result = product.GetProductDetail(Id);
            return result;
        }

        public ResponseBaseEntity UsersAdd(User user)
        {
            var users = _productFactory.Users();
            return users.UsersAdd(user);
        }

        public User UserCheck(User user)
        {
            var users = _productFactory.Users();
            return users.UsersCheck(user);
        }

        public ResponseBaseEntity AdminCheck(string userName)
        {
            var users = _productFactory.Users();
            return users.AdminCheck(userName);
        }

        public ResponseBaseEntity DeleteProduct(int Id)
        {
            var product = _productFactory.Products();
            var result = product.DeleteProduct(Id);
            return result;
        }
    }
}