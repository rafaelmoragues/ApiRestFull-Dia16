using ApiRestFull.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libros> Libros { get; set; }
    }
}
