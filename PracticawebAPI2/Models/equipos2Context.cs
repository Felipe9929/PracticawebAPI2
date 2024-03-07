using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace PracticawebAPI2.Models
{
    public class equipos2Context: DbContext
    {
        public equipos2Context(DbContextOptions<equipos2Context> options) : base(options)
        {

        }

        public DbSet<equipos2> equipos2 { get; set; }

    }
}
