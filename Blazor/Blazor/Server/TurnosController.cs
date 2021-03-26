using Blazor.Server.Data;
using Blazor.Shared.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace Blazor.Server
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

        //Get: api/Turnos
        [HttpGet]
        public ActionResult<IEnumerable<Turnos>> GetTurnosItems()
        {
            return _context.ControlTurnos.ToList();
        }


    }
}
