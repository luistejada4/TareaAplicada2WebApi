using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaAplicada.Models;

namespace TareaAplicada.DAL
{
    public class Context : DbContext
    {
        public DbSet<Cobro> Cobros { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
