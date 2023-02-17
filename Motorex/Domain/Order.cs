﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Domain
{
    public class Order
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required]

        public DateTime OrderDate { get; set; }
        [Required]

        public int MotorId { get; set; }

        public virtual Motor Motor { get; set; }
        [Required]

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Range(0, 100000)]
        public decimal Price {get;set;}
        [Range(0, 100)]
        public decimal Discount { get; set; }

        public decimal TotalPrice 
        {
            get 
            {
                return Quantity * Price - Quantity * Price * Discount / 100;
            }
        }
        

    }
}
