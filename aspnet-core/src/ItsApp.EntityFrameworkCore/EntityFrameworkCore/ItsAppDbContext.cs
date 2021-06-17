using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ItsApp.Authorization.Roles;
using ItsApp.Authorization.Users;
using ItsApp.MultiTenancy;

namespace ItsApp.EntityFrameworkCore
{
    public class ItsAppDbContext : AbpZeroDbContext<Tenant, Role, User, ItsAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ItsAppDbContext(DbContextOptions<ItsAppDbContext> options)
            : base(options)
        {
        }
    }
}
