﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstDemo.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Rating { get; set; }
        public string City { get; set; }
    }
}