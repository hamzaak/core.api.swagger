using Core.Api.Swagger.Data.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Core.Api.Swagger.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
