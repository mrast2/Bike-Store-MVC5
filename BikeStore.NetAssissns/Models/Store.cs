using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BikeStore.NetAssissns.Models
{
    public class Store
    {
        [Key]
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<Employee> ListOfEmployee { get; set; }
        public string TelephoneNumber { get; set; }
        public List<Inventory> StoreInventory { get; set; }

        public bool AddEmployee(Employee emp)
        {
            if (ListOfEmployee.Exists(x=>x.SocialSecurityNumber == emp.SocialSecurityNumber))
            {
                return false;
            }
            else
            {
                this.ListOfEmployee.Add(emp);
                return true;
            }
            
        }

        public bool RemoveEmployee(Employee emp)
        {
            if (ListOfEmployee.Exists(x => x.SocialSecurityNumber == emp.SocialSecurityNumber))
            {
                this.ListOfEmployee.Remove(emp);
                return true;
            }
            else
            {                
                return false;
            }
        }

        public Boolean AddInventory(Inventory newBicycle)
        {
            if (StoreInventory.Exists(x => x.SerialNumber == newBicycle.SerialNumber))
            {
                return false; 
            }
            else
            {
                this.StoreInventory.Add(newBicycle);
                return true;
            }
        }

        public Boolean RemoveInventory(Inventory newBicycle)
        {
            if (StoreInventory.Exists(x => x.SerialNumber == newBicycle.SerialNumber))
            {
                this.StoreInventory.Remove(newBicycle);
                return true;
            }
            else
            { 
                return false; 
            }
        }
    }
}