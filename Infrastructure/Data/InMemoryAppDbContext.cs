using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Infrastructure.Data
{
    public class InMemoryAppDbContext : DbContext, IApplicationDbContext
    {

        public InMemoryAppDbContext(DbContextOptions<InMemoryAppDbContext> options) : base(options)
        {
            
        }

        public DbSet<CompanyInfo> CompanyInfos { get; set; }

    }
}
