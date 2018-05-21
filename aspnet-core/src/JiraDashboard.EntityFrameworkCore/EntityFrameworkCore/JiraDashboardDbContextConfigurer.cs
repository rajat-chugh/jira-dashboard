using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace JiraDashboard.EntityFrameworkCore
{
    public static class JiraDashboardDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<JiraDashboardDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<JiraDashboardDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
