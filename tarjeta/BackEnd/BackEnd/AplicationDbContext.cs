using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext (DbContext <AplicationDbContext> options):base(options) 
        {
            
        }
        public DbSet<TarjetaCredito> TarjetaCredito { get; set;}
    }
}
