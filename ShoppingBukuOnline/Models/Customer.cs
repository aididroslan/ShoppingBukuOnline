using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingBukuOnline.Models
{
    public class Customer
    {
        public string id { set; get; }
        public string name { set; get; }
        public string phone { set; get; }
        public string address { set; get; }
        public string city { set; get; }
        public string state { set; get; }
        public string postcode { set; get; }
    }
}