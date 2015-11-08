using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ECommerce.Models;

namespace ECommerce.DataContexts
{
    public class ECommerceDb:DbContext
    {
        public ECommerceDb()
            : base("DefaultConnection") //Default Connection is the connection string
        { 
        }

        public DbSet<Product> Products { get; set; }
    }
}