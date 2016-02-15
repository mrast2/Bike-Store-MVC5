using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BikeStore.NetAssissns.Models
{
    public class OrderItem
    {
        [Key]
        public int ID { get; set; }
        public Inventory BicycleOrdered { get; set; }
        public decimal PriceSold { get; set; }
        public enum Flag
        { 
            Online = 1,
            Store = 2
        };
        public Flag PurchaseType { get; set; }
    }
}