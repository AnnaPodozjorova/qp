using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestsWeb.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email not specified")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [StringLength(50, ErrorMessage = " {0} Must be 2 to 1 symbols", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}
