using FinlexApp.DataLibrary.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinlexApp.DataLibrary
{
    public class DbOrderContext : DbContext
    {
        public DbOrderContext(DbContextOptions<DbOrderContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
