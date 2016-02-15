using BikeStore.NetAssissns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeStore.NetAssissns.Controllers
{
    public class StoreController : Controller
    {
        BikeStoreEntities storeDB = new BikeStoreEntities();
        string store;
        // GET: Store
        public ActionResult Index(string storeName)
        {
            return View();
        }
        public ActionResult InventoryDetails(string storeName)
        {
            try 
            { 
                store = storeName;
                var employees = storeDB.Employees.ToList();
                var storeModel = storeDB.Stores.Include("StoreInventory").Single(s => s.Name == storeName);
                return View(storeModel);
            }
            catch(Exception ex)
            {
                return Content("Please Enter valid Arguments!");
            }
        }

        public ActionResult ContactDetails()
        {
            var stores = storeDB.Stores.ToList();
            return View(stores);
        }
        public ActionResult AddToCart(string serialNumber, string store)
        {
            Inventory inventory = storeDB.StoreInventory.Find(serialNumber);            
            if(ModelState.IsValid)
            { 
                inventory.InventoryStatus = Inventory.Status.Pending_Sale;
                storeDB.Entry(inventory).State = System.Data.Entity.EntityState.Modified;
                storeDB.SaveChanges();
            }
            return RedirectToAction("InventoryDetails", "Store", new { storeName = store });
            //return View(inventory);
        }

        [Authorize(Roles="Manager")]
        public ActionResult CalcStats()
        {
            List<Order> orders = storeDB.Orders.ToList();
            decimal totalInventoryCost = 0.0M;
            decimal totalSales = 0.0M;
            int totalInventorySold = 0;
            decimal totalEmployeeBonus =0.0M;
            decimal totalProfits = 0.0M;
            foreach(var order in orders)
            {
                string inventoryID = order.SerialNumber;
                Inventory inventory = storeDB.StoreInventory.Find(inventoryID);
                totalInventorySold = totalInventorySold + 1;
                totalSales = totalSales + inventory.RecSellPrice;
                totalInventoryCost = totalInventoryCost + inventory.InventoryCost;
                totalEmployeeBonus = totalEmployeeBonus + order.EmpBonusPayable;
            }
            totalProfits = totalSales - totalInventoryCost;
            ViewBag.totalInventorySold = totalInventorySold;
            ViewBag.totalSales = totalSales;
            ViewBag.totalEmployeeBonus = totalEmployeeBonus;
            ViewBag.totalProfits = totalProfits;
            return View();
        }
    }
}