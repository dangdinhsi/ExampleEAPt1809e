using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Example_wcf_t1809e.Data
{
    public class Example_wcf_t1809eContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Example_wcf_t1809eContext() : base("name=Example_wcf_t1809eContext")
        {
        }
        public DbSet<Example_wcf_t1809e.Models.Customer> Customers { get; set; }
    }
}
