using Microsoft.EntityFrameworkCore;
using ContactManagerMvc.Models; 

namespace ContactManagerMvc.Data
{

    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
