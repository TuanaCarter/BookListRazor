using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Model
{
    public class ApplicationDbContext : DbContext 
    {
        //Constructor; dependency injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Add book model
        public DbSet<Book> Book { get; set; }
    }
}
