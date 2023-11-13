

using GrpcMantenance.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcMantenance.Data
{
    public class GrpcDbContext : DbContext
    {
        public GrpcDbContext(DbContextOptions<GrpcDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}