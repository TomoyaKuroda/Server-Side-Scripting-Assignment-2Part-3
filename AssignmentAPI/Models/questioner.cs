using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentAPI.Models
{
    public class questioner
    {
        [Key]
        [Display(Name = "Questioner ID")]
        public int questioner_id { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string last_name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Phone Number")]
        public string phone_number { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Email Address")]
        public string email_address { get; set; }
    }
}
