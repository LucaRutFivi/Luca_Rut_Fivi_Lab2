using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Luca_Rut_Fivi_Lab2.Models;

namespace Luca_Rut_Fivi_Lab2.Data
{
    public class Luca_Rut_Fivi_Lab2Context : DbContext
    {
        public Luca_Rut_Fivi_Lab2Context (DbContextOptions<Luca_Rut_Fivi_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Luca_Rut_Fivi_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Luca_Rut_Fivi_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Luca_Rut_Fivi_Lab2.Models.Author> Authors { get; set; } = default!;
    }
}
