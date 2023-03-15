using Motorex.Models.Brand;
using Motorex.Models.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Models.Motor
{
    public class MotorCreateVM
    {
        public MotorCreateVM()
        {
            Brands = new List<BrandPairVM>();
            Categories = new List<CategoryPairVM>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public virtual List<BrandPairVM> Brands { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual List<CategoryPairVM> Categories { get; set; }

        [Required]
        [Display(Name = "EngineType")]
        public string TypeEngine { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Required]
        [Range(0, 5000)]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }
    }
}
