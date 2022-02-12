using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities.ProductDependency
{
    public interface IProductsFactory
    {
        IProducts Products();
        IUsers Users();
    }
    public interface IUsers
    {
        ResponseBaseEntity UsersAdd(User user);
        User UsersCheck(User user);
        ResponseBaseEntity AdminCheck(string userName);
    }

    public interface IProducts
    {
        Product ProductsAdd(Product product);
        ResponseBaseEntity ProductsDetailAdd(ProductDetail productDetail);
        ResponseBaseEntity UpdateProductDetail(ProductDetail productDetail);
        List<Product> GetProductList();
        ProductDetail GetProductDetail(int Id);
        ResponseBaseEntity DeleteProduct(int Id);

    }
}