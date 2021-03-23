using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blazor.Server.Models;
using Blazor.Server.Data;
using Microsoft.EntityFrameworkCore.Internal;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        private readonly ApiContext _context;

        public TurnosController(ApiContext context){
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Turnos>> Get()
        {
            return _context.Turnos.Include(p => p).ToList();
        }
        //Get: api/Turnos/5
        [HttpGet("{id}", Name = "ObtenerTurnoPorId")]
        public ActionResult<Turnos> Get(int id)
        {
            var turno = _context.Turnos.FirstOrDefault(p => p.Id_Turno == id);
            if (turno == null)
            {
                return NotFound();
            }
            return turno;
        }

        [HttpPost]
        public ActionResult<Turnos> Post([FromBody] Turnos turnos)
        {
            _context.Turnos.Add(turnos);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerProductoPorId", new { id = turnos.Id_Turno }, turnos);
        }

        [HttpPut("{id}")]
        public ActionResult<Turnos> Put(int id, [FromBody] Turnos turnos)
        {
            if (id != turnos.Id_Turno)
            {
                return BadRequest();
            }
            _context.Entry(turnos).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Turnos> Delete(int id)
        {
            try
            {
                var turnos = _context.Turnos.FirstOrDefault(p => p.Id_Turno == id);
                if (turnos == null)
                {
                    return NotFound();
                }
                _context.Turnos.Remove(turnos);
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
