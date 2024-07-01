using s5fchamorro.Models;
using s5fchamorro.Utils;
using Microsoft.EntityFrameworkCore;

namespace s5fchamorro.DataAcces
{
    class PersonaDbContext:DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDB = $"Filename={ConexionDB.devolverRuta("personas.db")}";
            //optionsBuilder.UseSqlite(conexionDB);   
        }
    }
}
