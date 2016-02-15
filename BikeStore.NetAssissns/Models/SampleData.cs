using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BikeStore.NetAssissns.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BikeStoreEntities>
    {
        protected override void Seed(BikeStoreEntities context)
        {
            var stores = new List<Store>
            {
                new Store { Name = "Store 1", City = "Cincinnati" , Address = "Cincinnati, Ohio", TelephoneNumber = "5131122234"},      
                new Store { Name = "Store 2", City = "Boston" , Address = "Boston,Massachusetts", TelephoneNumber = "5131122234"},
                new Store { Name = "Store 3", City = "Maryland" , Address = "Maryland, Washington", TelephoneNumber = "5131122234"},
            };

            new List<Employee>
            {
               new Employee { FirstName = "Debasmita", LastName = "Basak", DateOfBirth = new DateTime(1990,11,23), SocialSecurityNumber = "12345", AssignedStores = stores.Where(s => s.Name == "Store 1" || s.Name =="Store 3").ToList(), EmpType= "Regular"},
               new Employee { FirstName = "Mayank", LastName = "Rastogi", DateOfBirth = new DateTime(1991,10,12), SocialSecurityNumber = "23456", AssignedStores = stores.Where(s => s.Name == "Store 1" || s.Name =="Store 2").ToList(), EmpType= "Manager"},
               new Employee { FirstName = "Karishma", LastName = "Kavle", DateOfBirth = new DateTime(1989,09,09), SocialSecurityNumber = "34567", AssignedStores = stores.Where(s => s.Name == "Store 2" || s.Name =="Store 3").ToList(), EmpType= "Regular"},
               new Employee { FirstName = "Shreaysi", LastName = "Parkhi", DateOfBirth = new DateTime(1990,01,01), SocialSecurityNumber = "45678", AssignedStores = stores.Where(s => s.Name == "Store 2" || s.Name =="Store 1").ToList(), EmpType= "Manager"},
               new Employee { FirstName = "Divya", LastName = "Dikshit", DateOfBirth = new DateTime(1990,02,02), SocialSecurityNumber = "56789", AssignedStores = stores.Where(s => s.Name == "Store 3" || s.Name =="Store 2").ToList(), EmpType= "Regular"},
               new Employee { FirstName = "Rohan", LastName = "Vashist", DateOfBirth = new DateTime(1990,03,03), SocialSecurityNumber = "67890", AssignedStores = stores.Where(s => s.Name == "Store 3" || s.Name =="Store 1").ToList(), EmpType= "Manager"}
            }.ForEach(a => context.Employees.Add(a));

            new List<Inventory>
            {
                new Inventory { InventorySize = Inventory.Size.Sm, InventoryType = Inventory.Type.BMX, InventoryStatus = Inventory.Status.Available, SerialNumber="A1234", Brand="Trek", Model = "Trail Blazer", Description="The most powerful bike of 2014", InventoryCost=50.00m,RecSellPrice=80.00m, StoreName = stores.Single(s => s.Name == "Store 1")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.MountainBike, InventoryStatus = Inventory.Status.Available, SerialNumber="A2345", Brand="Salsa", Model = "Model 2", Description="The most sturdy bike of 2014", InventoryCost=55.00m,RecSellPrice=100.00m, StoreName = stores.Single(s => s.Name == "Store 1")},
                new Inventory { InventorySize = Inventory.Size.Lg, InventoryType = Inventory.Type.Hybrid, InventoryStatus = Inventory.Status.Available, SerialNumber="A3456", Brand="Jamis", Model = "Model 3", Description="The most preffered bike of 2014", InventoryCost=100.00m,RecSellPrice=150.00m, StoreName = stores.Single(s => s.Name == "Store 1")},
                new Inventory { InventorySize = Inventory.Size.XtraLg, InventoryType = Inventory.Type.Hybrid, InventoryStatus = Inventory.Status.Available, SerialNumber="A4567", Brand="Specialised", Model = "Model 4", Description="Features 6 levels of gears! Zoooommmm!", InventoryCost=75.00m,RecSellPrice=120.00m, StoreName = stores.Single(s => s.Name == "Store 1")},
                new Inventory { InventorySize = Inventory.Size.Sm, InventoryType = Inventory.Type.Children, InventoryStatus = Inventory.Status.Available, SerialNumber="A5678", Brand="Surly", Model = "Model 5", Description="Features height adjustable seat!Wow!", InventoryCost=130.00m,RecSellPrice=200.00m, StoreName = stores.Single(s => s.Name == "Store 2")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.Road, InventoryStatus = Inventory.Status.Available, SerialNumber="A6789", Brand="Giant", Model = "Model 6", Description="The fastest bike of 2014", InventoryCost=120.00m,RecSellPrice=199.00m, StoreName = stores.Single(s => s.Name == "Store 2")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.BMX, InventoryStatus = Inventory.Status.Available, SerialNumber="A7890", Brand="Bianchi", Model = "Model 7", Description="Blah Blah Blah", InventoryCost=25.00m,RecSellPrice=120.00m, StoreName = stores.Single(s => s.Name == "Store 2")},
                new Inventory { InventorySize = Inventory.Size.XtraLg, InventoryType = Inventory.Type.Hybrid, InventoryStatus = Inventory.Status.Available, SerialNumber="A8901", Brand="Cannondale", Model = "Model 8", Description="I have no description left", InventoryCost=140.00m,RecSellPrice=185.00m, StoreName = stores.Single(s => s.Name == "Store 3")},
                new Inventory { InventorySize = Inventory.Size.Md, InventoryType = Inventory.Type.MountainBike, InventoryStatus = Inventory.Status.Available, SerialNumber="A9012", Brand="Cervelo", Model = "Model 9", Description="Best Mountain Bike of the year", InventoryCost=80.00m,RecSellPrice=110.00m, StoreName = stores.Single(s => s.Name == "Store 3")}

            }.ForEach(a => context.StoreInventory.Add(a));
        }
    }
}