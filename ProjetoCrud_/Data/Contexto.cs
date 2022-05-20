using Microsoft.EntityFrameworkCore;
using ProjetoCrud_.Models;

namespace ProjetoCrud_.Data
{
    public class Contexto : DbContext
    {
        internal readonly object Movie;

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Usuarios> Usuario { get; set; }

        public DbSet<Operadoras> Operadoras { get; set; }

        public DbSet<Avaliacao> Avaliacao { get; set; }     
       
    }
}
