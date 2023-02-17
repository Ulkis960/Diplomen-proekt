using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Domain
{
    public class ApplicationUser :IdentityUser
    {
       
        [Required]
        [MaxLength(30)]

        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]

       
        public string Adress { get; set; }
    }
}
