using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities.ProductDependency
{
    public class ProductFactory : IProductsFactory 
    {
        public IProducts Products()
        {
            return new ProductManager();
        }

        public IUsers Users()
        {
            return new UserManager();
        }
    }
}