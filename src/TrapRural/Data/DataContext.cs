using Microsoft.EntityFrameworkCore;
using TrapRural.Models;

namespace TrapRural.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
            
        }
        public DbSet<Usuario> Usuarios {get;set;}
        public DbSet<ProriedadeModel> Proriedades {get;set;}
    }
}