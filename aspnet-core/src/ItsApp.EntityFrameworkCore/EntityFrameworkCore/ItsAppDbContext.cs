using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ItsApp.Authorization.Roles;
using ItsApp.Authorization.Users;
using ItsApp.EntityFrameworkCore.Mapping;
using ItsApp.Models;
using ItsApp.MultiTenancy;

namespace ItsApp.EntityFrameworkCore
{
    public class ItsAppDbContext : AbpZeroDbContext<Tenant, Role, User, ItsAppDbContext>
    {
        public ItsAppDbContext(DbContextOptions<ItsAppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Information> Informations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("", "Infrastructure");
            modelBuilder.ApplyConfiguration(new InformationMap());
        }
    }
}
