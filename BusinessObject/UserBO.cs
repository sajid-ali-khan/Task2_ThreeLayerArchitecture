using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserBO
    {
        public int userId { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User name is required.")]
        public string userName { get; set; }

        [Display(Name = "User Address")]
        [Required(ErrorMessage = "User address is required.")]
        public string userAddress { get; set; }

        [Display(Name = "User Email")]
        [Required(ErrorMessage = "Enter a valid email address.")]
        [EmailAddress(ErrorMessage = "Please enter valid email address.")]
        public string userEmail { get; set; }

        [Display(Name = "User Phone")]
        [Required(ErrorMessage = "Phone number is required.")]
        public string userMobile { get; set; }
    }
}
