using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Repository.EFCore;

namespace TokenAPI.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            //configurationBuilder -> appsetting.json dosyasına erişim izni verir
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            //DbContextOptionsBuilder -> appsetting.json dosyasındaki 'sqlConnection' alanına
            //erişir ve Migration kaydını 'TokeAPI' projesi içine yapar
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                prj => prj.MigrationsAssembly("TokenAPI"));

            return new RepositoryContext(builder.Options);
        }
    }
}
