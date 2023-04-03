using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Motorex.Domain;

namespace Motorex.Models.Order
{
    public class OrderIndexVM
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OrderDate { get; set; }
        public string UserId { get; set; }
        public string User { get; set; }
        public int MotorId { get; set; }
        public string Motor { get; set; }
        public string Picture { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
