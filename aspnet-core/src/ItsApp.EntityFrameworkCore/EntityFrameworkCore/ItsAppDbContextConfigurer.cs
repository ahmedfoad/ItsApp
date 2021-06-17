using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ItsApp.EntityFrameworkCore
{
    public static class ItsAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ItsAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ItsAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
