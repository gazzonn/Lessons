using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lesson4.Models;

namespace lesson4.Data
{
    public class lesson4Context : DbContext
    {
        public lesson4Context (DbContextOptions<lesson4Context> options)
            : base(options)
        {
        }

        public DbSet<lesson4.Models.Book> Book { get; set; } = default!;
    }
}
