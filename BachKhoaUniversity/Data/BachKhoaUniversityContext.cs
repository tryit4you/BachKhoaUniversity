using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BachKhoaUniversity.Models
{
    public class BachKhoaUniversityContext : DbContext
    {
        public BachKhoaUniversityContext (DbContextOptions<BachKhoaUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<BachKhoaUniversity.Models.Student> Student { get; set; }
    }
}
