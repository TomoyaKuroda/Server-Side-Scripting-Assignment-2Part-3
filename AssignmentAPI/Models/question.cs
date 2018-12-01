using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentAPI.Models
{
    [Table("question")]
    public class question
    {
        [Key]
        public int question_id { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        [Required]
        [StringLength(50)]
        public string contents_of_question { get; set; }

        public DateTime? date { get; set; }

        public int questioner_id { get; set; }
    }
}
