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
    public class PeluquerosController : ControllerBase
    {
        private readonly ApiContext _context;

        public PeluquerosController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Peluqueros>> Get()
        {
            var complex = _context.Peluquerosdb
                .Include(x => x.Id_Peluquero)
                .ToList();

            return complex;
        }
        // GET: api/Peluqueros/5
        [HttpGet("{id}", Name = "ObtenerPeluqueroPorId")]
        public ActionResult<Peluqueros> Get(int id)
        {
            var peluquero = _context.Peluquerosdb.FirstOrDefault(p => p.Id_Peluquero == id);
            if (peluquero == null)
            {
                return NotFound();
            }
            return peluquero;
        }

        [HttpPost]
        public ActionResult<Peluqueros> Post([FromBody] Peluqueros peluquero)
        {
            _context.Peluquerosdb.Add(peluquero);
            _context.SaveChanges();
            return new CreatedAtRouteResult("Obtenerpeluqueroporid", new { id = peluquero.Id_Peluquero }, peluquero);
        }
        [HttpPut("{id}")]
        public ActionResult<Peluqueros> Put(int id, [FromBody] Peluqueros peluquero)
        {
            if (id != peluquero.Id_Peluquero)
            {
                return BadRequest();
            }
            _context.Entry(peluquero).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Peluqueros> Delete(int id)
        {
            try
            {
                var peluquero = _context.Peluquerosdb.FirstOrDefault(p => p.Id_Peluquero == id);
                if (peluquero == null)
                {
                    return NotFound();
                }
                _context.Peluquerosdb.Remove(peluquero);
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