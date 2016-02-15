using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BikeStore.NetAssissns.Models
{
    public class Employee
    {
        public Employee()
        {
            ListOfInventorySold = new List<Inventory>();
            AssignedStores = new List<Store>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Key]
        [Index(IsUnique = true)]
        public string SocialSecurityNumber { get; set; }
        public List<Store> AssignedStores { get; set; }
        public List<Inventory> ListOfInventorySold { get; set; }
        public enum Type
        {
            Regular,
            Manager
        };
        public string EmpType { get; set; }
        
        public Boolean AddSoldInventory(Inventory bicycleSold)
        {
            if(bicycleSold.Equals(null))
            { 
                this.ListOfInventorySold.Add(bicycleSold);
                return true;
            }
            else
                return false;
        }
        public Boolean AddAssignedStore(Store storeToAdd)
        {
            if (storeToAdd.Equals(null))
            {
                return false;
            }
            else
            { 
                if(AssignedStores.Contains(storeToAdd))
                { 
                    return false;
                }
                else 
                { 
                    this.AssignedStores.Add(storeToAdd);
                    return true;
                }
            }
        }
        public Boolean RemoveAssignedStore(Store storeToRemove)
        {
            if (storeToRemove.Equals(null))
            {
                return false;
            }
            else
            {
                this.AssignedStores.Remove(storeToRemove);
                return true;
            }
        }
    }
}