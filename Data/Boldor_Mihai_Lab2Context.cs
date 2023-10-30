using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Boldor_Mihai_Lab2.Models;

namespace Boldor_Mihai_Lab2.Data
{
    public class Boldor_Mihai_Lab2Context : DbContext
    {
        public Boldor_Mihai_Lab2Context (DbContextOptions<Boldor_Mihai_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Boldor_Mihai_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Boldor_Mihai_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
