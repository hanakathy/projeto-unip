using ProjetoUnip.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoUnip.Data
{
    public class ProjetoUnipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(@"Server=(localhost)\root;Database=projetounip;Trusted_Connection=True");
            }
        }

        public ProjetoUnipContext(DbContextOptions<ProjetoUnipContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<TipoTelefone> TipoTelefone { get; set; }
    }
}
