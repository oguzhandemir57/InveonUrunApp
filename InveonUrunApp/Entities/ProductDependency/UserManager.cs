using InveonUrunApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities.ProductDependency
{
    public class UserManager : IUsers
    {
        public ResponseBaseEntity UsersAdd(User user)
        {
            // logic business 

            return null;
        }

        public User UsersCheck(User user)
        {
            var userCheck = new LoginLogic().UserCheck(user);
            
            return userCheck;
        }

        public ResponseBaseEntity AdminCheck(string userName)
        {
            var adminCheck = new LoginLogic().AdminCheck(userName);

            return adminCheck;
        }
    }
}