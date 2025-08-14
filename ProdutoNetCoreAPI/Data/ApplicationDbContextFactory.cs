using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ProdutoNetCoreAPI.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Aqui você coloca a connection string do Azure SQL ou local para desenvolvimento
            optionsBuilder.UseSqlServer("Server=tcp:srv-dvp.database.windows.net,1433;Initial Catalog=Tab_Produtos;Persist Security Info=False;User ID=azureAdmin;Password=srvazure@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
