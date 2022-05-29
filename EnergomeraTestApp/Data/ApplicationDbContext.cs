using EnergomeraTestApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <Item> Items { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
    }
}
