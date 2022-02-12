using InveonUrunApp.Entities;
using InveonUrunApp.Entities.ProductDependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.BusinessOperators
{
    public class LoginOperator
    {
        ProductService product = new ProductService(new ProductFactory());

        public User UserCheck(User user)
        {
            var userCheck = product.UserCheck(user);

            HttpContext.Current.Session.Add("ActiveUser", user.UserName);
            return userCheck;
        }
    }
}