using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BikeStore.NetAssissns.Models 
{
    public class BikeStoreEntities : DbContext
    {
        public DbSet<Inventory> StoreInventory { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public System.Data.Entity.DbSet<BikeStore.NetAssissns.Models.Order> Orders { get; set; }
    }
}