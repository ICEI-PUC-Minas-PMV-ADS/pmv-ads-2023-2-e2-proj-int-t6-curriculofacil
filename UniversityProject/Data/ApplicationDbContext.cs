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
        public DbSet<Curriculo> Curriculo { get; set; }
        public DbSet<UniversityProject.Models.HistoricoProfissional>? HistoricoProfissional { get; set; }
        public DbSet<UniversityProject.Models.Formacao>? Formacao { get; set; }
    }
}
