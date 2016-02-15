using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BikeStore.NetAssissns.Models
{
    public class Inventory
    {
        public enum Size
        {
            Sm,Md,Lg,XtraLg
        };
        public enum Type
        {
            BMX,
            MountainBike,
            Hybrid,
            Road,
            Children
        };
        public enum Status
        {
            Pending_Sale,
            Available
        };
        public Size InventorySize { get; set; }
        public Type InventoryType { get; set; }
        public Status InventoryStatus { get; set; }
        [Key]
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal InventoryCost { get; set; }
        public decimal RecSellPrice { get; set; }
        public Store StoreName { get; set; }
        
        public void ReserveInventory(List<Inventory> ListOfInverntory)
        {
            foreach(var item in ListOfInverntory)
            {
                item.InventoryStatus = Status.Pending_Sale;
            }
        }
    }
}