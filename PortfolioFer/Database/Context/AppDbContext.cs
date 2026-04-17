using Microsoft.EntityFrameworkCore;
using PortfolioFer.Database.Entities;
using System.Collections.Generic;

namespace PortfolioFer.Database.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}