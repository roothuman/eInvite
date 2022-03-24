using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eInvite.Models
{
    public class GetResponse
    {
        [Required (ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Kindly specify if you will attend")]
        public bool? WillAttend { get; set; }
    }
}
