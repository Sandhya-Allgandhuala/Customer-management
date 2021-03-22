using Microsoft.EntityFrameworkCore;
using PM_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Data
{
    public class PMContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }

        public PMContext(DbContextOptions options ):base(options)
        {

        }

    }
}
