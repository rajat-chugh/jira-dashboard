using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using JiraDashboard.Authorization.Roles;
using JiraDashboard.Authorization.Users;
using JiraDashboard.MultiTenancy;

namespace JiraDashboard.EntityFrameworkCore
{
    public class JiraDashboardDbContext : AbpZeroDbContext<Tenant, Role, User, JiraDashboardDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public JiraDashboardDbContext(DbContextOptions<JiraDashboardDbContext> options)
            : base(options)
        {
        }
    }
}
