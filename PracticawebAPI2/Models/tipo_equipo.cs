using System.ComponentModel.DataAnnotations;
namespace PracticawebAPI2.Models
{
    public class tipo_equipo
    {
        [Key]
        public int id_tipo_eq { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}
