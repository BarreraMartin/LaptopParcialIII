using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MartinParcialII.AppContext
{
    class AppDBContext:DbContext
    {

        public AppDBContext() : base("conn")
        {

        }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
    }
}
