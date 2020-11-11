using ProAgil.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace ProAgil.Data
{
    public class DataContext : DbContext
    {        
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }      
          
        public DbSet<Evento> Eventos { get; set; }
        
    }
}
