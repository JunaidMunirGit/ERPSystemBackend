using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ERPSystem.Authorization.Roles;
using ERPSystem.Authorization.Users;
using ERPSystem.MultiTenancy;

namespace ERPSystem.EntityFrameworkCore
{
    public class ERPSystemDbContext : AbpZeroDbContext<Tenant, Role, User, ERPSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ERPSystemDbContext(DbContextOptions<ERPSystemDbContext> options)
            : base(options)
        {
        }
    }
}
