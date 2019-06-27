using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.DatabaseLayer.Model;

namespace Test.DatabaseLayer
{
    public class ContosoDbContext : IdentityDbContext<User>
    {
        public ContosoDbContext(DbContextOptions<ContosoDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Server=DESKTOP-8MEVUBJ\\SQLEXPRESS;Database=Contoso;User ID=sa;Password=magic;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connection, x => x.MigrationsAssembly("Test.DatabaseLayer"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
