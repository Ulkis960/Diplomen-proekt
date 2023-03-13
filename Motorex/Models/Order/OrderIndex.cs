﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Models.Order
{
    public class OrderIndexVM
    {
        public int Id { get; set; }
        public string OrderDate { get; set; }
        public int MotorId { get; set; }
        public string MotorName { get; set; }
        public string UserId { get; set; }
        public string User { get; set; }
        public string Picture { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
