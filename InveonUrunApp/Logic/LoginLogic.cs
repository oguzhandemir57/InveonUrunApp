using InveonUrunApp.Context;
using InveonUrunApp.Entities;
using InveonUrunApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Logic
{
    public class LoginLogic
    {
        private InveonContext context = null;

        public LoginLogic()
        {
            context = new InveonContext();
        }
        public User UserCheck(User user)
        {
            try
            {
                var userCheck = context.User.Where(x=> x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
                return userCheck;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ResponseBaseEntity AdminCheck(string userName)
        {
            ResponseBaseEntity result = new ResponseBaseEntity();
            try
            {
                var userCheck = context.User.Where(x => x.UserName == userName).FirstOrDefault();
                result.Success =Convert.ToBoolean(userCheck.Role);

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}