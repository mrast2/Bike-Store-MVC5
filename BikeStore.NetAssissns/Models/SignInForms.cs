using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.NetAssissns.Models
{
    public class SignInForms
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Reset()
        {
            Password = "";
        }
    }
}