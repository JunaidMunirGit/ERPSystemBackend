using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ERPSystem.EntityFrameworkCore
{
    public static class ERPSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ERPSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ERPSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
