using Microsoft.EntityFrameworkCore;
using PortfolioFer.Features.Profile.Entities;
using PortfolioFer.Features.Projects.Entities;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PortfolioFer.Database
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