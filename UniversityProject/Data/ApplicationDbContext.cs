using Microsoft.EntityFrameworkCore;
using UniversityProject.Models;

namespace UniversityProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Usuario> Usuario { get; set; }
    }
}
