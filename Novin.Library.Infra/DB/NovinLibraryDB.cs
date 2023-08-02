using Microsoft.EntityFrameworkCore;
using Novin.Library.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novin.Library.Infra.DB
{
    public class NovinLibraryDB : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=NLibraryDB;Trusted_Connection=True");
        }
    }
}
