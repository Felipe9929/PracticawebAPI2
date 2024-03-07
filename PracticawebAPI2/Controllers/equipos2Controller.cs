using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using PracticawebAPI2.Models;

namespace PracticawebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equipos2Controller : ControllerBase
    {
        private readonly equipos2Context _equipos2Contexto;
        public equipos2Controller(equipos2Context equipos2Contexto)
        {
            _equipos2Contexto = equipos2Contexto;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<equipos> ListadoEquipo2 = (from e in _equipos2Contexto.equipos
                                           select e).ToList();
            if (ListadoEquipo2.Count == 0)
            { return NotFound(); }

            return Ok(ListadoEquipo2);
        }

        [HttpGet]
        [Route("GetAllConJoin")]
        public IActionResult GetJoin() {
            var listadoEquipo = (from e in _equipos2Contexto.equipos
                                 join t in _equipos2Contexto.tipo_equipo
                                 on e.tipo_equipo_id equals t.id_tipo_eq
                                 join m in _equipos2Contexto.marcas
                                 on e.marca_id equals m.id_marcas
                                 join es in _equipos2Contexto.estados_equipo
                                 on e.estado_equipo_id equals es.id_estados_equipo
                                 select new
                                 {
                                     e.id_equipos,
                                     e.nombre,
                                     e.descripcion,
                                     e.tipo_equipo_id,
                                     tipo_equipo = t.descripcion,
                                     e.marca_id,
                                     marca = m.nombre_marca,
                                     e.estado_equipo_id,
                                     estados_equipo = es.descripcion,
                                     e.estado
                                 }).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoEquipo);
        }


    }
}
