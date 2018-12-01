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
        public int questioner_id { get; set; }


        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_number { get; set; }

        [Required]
        [StringLength(50)]
        public string email_address { get; set; }
    }
}
