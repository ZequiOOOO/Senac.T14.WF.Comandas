

using Microsoft.EntityFrameworkCore;

namespace Comandas
{
      //Classe que representa o banco de dados
    public class AppDbContext : DbContext
    {
        //propriedade que representa a tabela UsuáSrios
        public DbSet<Usuario> Usuarios { get; set; }
        //métodos que configura informando para o EF que o banco será SQlite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }

}
