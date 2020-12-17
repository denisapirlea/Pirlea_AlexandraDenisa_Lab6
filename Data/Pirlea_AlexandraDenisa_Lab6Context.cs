using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pirlea_AlexandraDenisa_Lab6.Models;

namespace Pirlea_AlexandraDenisa_Lab6.Data
{
    public class Pirlea_AlexandraDenisa_Lab6Context : DbContext
    {
        public Pirlea_AlexandraDenisa_Lab6Context (DbContextOptions<Pirlea_AlexandraDenisa_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Pirlea_AlexandraDenisa_Lab6.Models.Book> Book { get; set; }
    }
}
