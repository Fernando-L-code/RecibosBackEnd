using Microsoft.EntityFrameworkCore;
using recibosBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recibosBack.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
     
        public DbSet<Recibos_Bd> RECIBOS { get; set; }
        public DbSet<Proveedores_Bd> PROVEEDORES { get; set; }
        public DbSet<Monedas_Bd> MONEDAS { get; set; }
        public DbSet<Usuarios_Bd> USUARIOS { get; set; }
    }
}
