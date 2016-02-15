using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BikeStore.NetAssissns.Models
{
    public class Order
    {
        public enum MethodPayment
        {
            Cash,
            Cheque,
            CreditCard
        };
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Customer Name")]
        public string CustName { get; set; }
        [DisplayName("Order Date")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Pickup Date")]
        public DateTime PickupDate { get; set; }
        [DisplayName("Employee Bonus")]
        public decimal EmpBonusPayable { get; set; }
        public string SerialNumber { get; set; }
        public string store { get; set; }
        public MethodPayment paymentMethod { get; set; }

        //public void PlaceOrder(List<OrderItem> ListOfItems, string custName, Store store, MethodPayment paymentMethod)
        //{
        //    this.ListOfOrderItems = ListOfItems;
        //    this.CustName = custName;
        //    this.OrderDate = DateTime.Today;
        //    this.store = store;
        //    //this.EmpBonusPayable = CalcEmpBonus();
        //    this.paymentMethod = paymentMethod;
        //    this.PickupDate = DateTime.Today.AddDays(7);
        //}

    //    private decimal CalcEmpBonus()
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}