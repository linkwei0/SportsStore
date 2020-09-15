using System;
using Microsoft.EntityFrameworkCore;

namespace Metanit_SportStore.Models
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
