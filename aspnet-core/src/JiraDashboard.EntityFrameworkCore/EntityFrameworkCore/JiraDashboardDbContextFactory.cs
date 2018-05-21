using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using JiraDashboard.Configuration;
using JiraDashboard.Web;

namespace JiraDashboard.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class JiraDashboardDbContextFactory : IDesignTimeDbContextFactory<JiraDashboardDbContext>
    {
        public JiraDashboardDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<JiraDashboardDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            JiraDashboardDbContextConfigurer.Configure(builder, configuration.GetConnectionString(JiraDashboardConsts.ConnectionStringName));

            return new JiraDashboardDbContext(builder.Options);
        }
    }
}
