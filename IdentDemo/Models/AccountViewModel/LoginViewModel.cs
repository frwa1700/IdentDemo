using System;
using System.ComponentModel.DataAnnotations;

namespace IdentDemo.Models.AccountViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-postadress")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }

        [Display(Name = "Kom ihåg?")]
        public bool RememberMe { get; set; }
    }
}
