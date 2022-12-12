using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using budnar_pavel_lab2.Models;

namespace budnar_pavel_lab2.Data
{
    public class budnar_pavel_lab2Context : DbContext
    {
        public budnar_pavel_lab2Context (DbContextOptions<budnar_pavel_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<budnar_pavel_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<budnar_pavel_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<budnar_pavel_lab2.Models.BookCategory> BookCategory { get; set; }

        public DbSet<budnar_pavel_lab2.Models.Category> Category { get; set; }
    }
}
