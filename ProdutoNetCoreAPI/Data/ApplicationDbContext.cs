using Microsoft.EntityFrameworkCore;
using ProdutoNetCoreAPI.Entities;

namespace ProdutoNetCoreAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        #region DbSet's 

        /// <summary>
        /// Obs: Nome deve ser seguido de acordo ao environment do Banco de dados
        /// </summary>
        public DbSet<Produto> Produtos { get; set; }

        #endregion  

    }
}
