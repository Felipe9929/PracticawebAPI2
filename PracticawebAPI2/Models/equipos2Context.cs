using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace PracticawebAPI2.Models
{
    public class equipos2Context: DbContext
    {
        public equipos2Context(DbContextOptions<equipos2Context> options) : base(options)
        {

        }

        public DbSet<equipos> equipos { get; set; }
        public DbSet<estados_equipo> estados_equipo { get; set; }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
    }
}
