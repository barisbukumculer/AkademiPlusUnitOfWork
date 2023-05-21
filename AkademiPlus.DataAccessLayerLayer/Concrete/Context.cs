using AkademiPlus.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlus.DataAccessLayerLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5SF4DGP\\SQLEXPRESS;initial catalog=AkademiPlusUnitofWorkDb;integrated security=true");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }    
    }
}
