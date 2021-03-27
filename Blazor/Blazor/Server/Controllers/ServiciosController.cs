using Blazor.Server.Data;
using Blazor.Shared.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private readonly ApiContext _context;

        public ServiciosController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Servicios>> Get()
        {
            var complex = _context.Serviciosdb
                .Include(x => x.Id_Servicio)
                .ToList();

            return complex;
        }
        // GET: api/Servicios/5
        [HttpGet("{id}", Name = "ObtenerservicioPorId")]
        public ActionResult<Servicios> Get(int id)
        {
            var servicio = _context.Serviciosdb.FirstOrDefault(p => p.Id_Servicio == id);
            if (servicio == null)
            {
                return NotFound();
            }
            return servicio;
        }

        [HttpPost]
        public ActionResult<Servicios> Post([FromBody] Servicios servicio)
        {
            _context.Serviciosdb.Add(servicio);
            _context.SaveChanges();
            return new CreatedAtRouteResult("Obtenerservicioporid", new { id = servicio.Id_Servicio }, servicio);
        }
        [HttpPut("{id}")]
        public ActionResult<Servicios> Put(int id, [FromBody] Servicios servicio)
        {
            if (id != servicio.Id_Servicio)
            {
                return BadRequest();
            }
            _context.Entry(servicio).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Servicios> Delete(int id)
        {
            try
            {
                var servicio = _context.Serviciosdb.FirstOrDefault(p => p.Id_Servicio == id);
                if (servicio == null)
                {
                    return NotFound();
                }
                _context.Serviciosdb.Remove(servicio);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
                throw;
            }
        }
    }
}
