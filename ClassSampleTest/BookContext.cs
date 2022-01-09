using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSampleTest
{
    class BookContext : DbContext
    {

        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Book> Books{ get; set; }

        public BookContext() : base("Rad301fe2019Connection-S00196895") { }

        public static BookContext Create()
        {
            return new BookContext();
        }

    }
}
