using InveonUrunApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Context
{
    public class InveonContext : DbContext
    {
        public InveonContext() 
            : base("database")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDetail> ProductDetail{ get; set; }
    }
}