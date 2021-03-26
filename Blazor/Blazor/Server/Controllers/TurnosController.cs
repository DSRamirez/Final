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
    public class TurnosController : ControllerBase
    {
        private readonly ApiContext _context;

        public TurnosController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Turnos>> Get()
        {
            var complex = _context.ControlTurnos
                .Include(x => x.Id_Turno)
                .ThenInclude(x => x.)
                .ThenInclude(p => p.Posts)
                .Single(x => x.Id == Id);

            return complex;
        }
        // GET: api/Turnos/5
        [HttpGet("{id}", Name = "ObtenerTurnoPorId")]
        public ActionResult<Turnos> Get(int id)
        {
            var turno = _context.ControlTurnos.FirstOrDefault(p => p.Id_Turno == id);
            if (turno == null)
            {
                return NotFound();
            }
            return turno;
        }

        [HttpPost]
        public ActionResult<Turnos> Post([FromBody] Turnos turno)
        {
            _context.ControlTurnos.Add(turno);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerTurnoporid", new { id = turno.Id_Turno }, turno);
        }
        [HttpPut("{id}")]
        public ActionResult<Turnos> Put(int id, [FromBody] Turnos turno)
        {
            if (id != turno.Id_Turno)
            {
                return BadRequest();
            }
            _context.Entry(turno).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Turnos> Delete(int id)
        {
            try
            {
                var turno = _context.ControlTurnos.FirstOrDefault(p => p.Id_Turno == id);
                if (turno == null)
                {
                    return NotFound();
                }
                _context.ControlTurnos.Remove(turno);
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