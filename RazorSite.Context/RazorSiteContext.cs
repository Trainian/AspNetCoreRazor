using System;
using Microsoft.EntityFrameworkCore;
using RazorSite.Entites;

namespace RazorSite.Context
{
    public class RazorSiteContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public RazorSiteContext(DbContextOptions<RazorSiteContext> options) : base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
