using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Domain
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]

        public string CategoryName { get; set; }

        public virtual IEnumerable<Motor> Motors { get; set; } = new List<Motor>();
    }
}
