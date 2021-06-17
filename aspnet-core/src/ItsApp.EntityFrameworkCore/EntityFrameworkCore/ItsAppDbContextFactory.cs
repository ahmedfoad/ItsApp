using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ItsApp.Configuration;
using ItsApp.Web;

namespace ItsApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ItsAppDbContextFactory : IDesignTimeDbContextFactory<ItsAppDbContext>
    {
        public ItsAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ItsAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ItsAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ItsAppConsts.ConnectionStringName));

            return new ItsAppDbContext(builder.Options);
        }
    }
}
