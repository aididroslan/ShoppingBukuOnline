using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingBukuOnline.Models
{
    public class User
    {
        public string email { set; get; }
        public string password { set; get; }
        public string userType { set; get; }
    }
}