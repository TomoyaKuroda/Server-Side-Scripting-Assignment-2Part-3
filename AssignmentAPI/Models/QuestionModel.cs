using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentAPI.Models
{
    public class QuestionModel : DbContext
    {
        public QuestionModel(DbContextOptions<QuestionModel> options) : base(options)
        {
        }

        // reference  the question model for CRUD
        public virtual DbSet<question> question { get; set; }

    }

}
