using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Domain
{
    public class Motor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Name")]
        public string Model { get; set; }
        [Required]

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        [Required]

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public string TypeEngine { get; set; }


        public string Picture { get; set; }
        [Required]
        [Range(0,5000)]

        public int Quantity { get; set; }
        [Required]
        [Range(0, 100000)]

        public decimal Price { get; set; }
        [Range(0, 100)]
        public decimal Discount { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();

    }
}
