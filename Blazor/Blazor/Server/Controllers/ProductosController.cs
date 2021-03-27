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
    public class ProductosController : ControllerBase
    {
        private readonly ApiContext _context;

        public ProductosController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Productos>> Get()
        {
            var complex = _context.Productosdb
                .Include(x => x.Id_Producto)
                .ToList();

            return complex;
        }
        // GET: api/Productos/5
        [HttpGet("{id}", Name = "ObtenerproductoPorId")]
        public ActionResult<Productos> Get(int id)
        {
            var producto = _context.Productosdb.FirstOrDefault(p => p.Id_Producto == id);
            if (producto == null)
            {
                return NotFound();
            }
            return producto;
        }

        [HttpPost]
        public ActionResult<Productos> Post([FromBody] Productos producto)
        {
            _context.Productosdb.Add(producto);
            _context.SaveChanges();
            return new CreatedAtRouteResult("Obtenerproductoporid", new { id = producto.Id_Producto }, producto);
        }
        [HttpPut("{id}")]
        public ActionResult<Productos> Put(int id, [FromBody] Productos producto)
        {
            if (id != producto.Id_Producto)
            {
                return BadRequest();
            }
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Productos> Delete(int id)
        {
            try
            {
                var producto = _context.Productosdb.FirstOrDefault(p => p.Id_Producto == id);
                if (producto == null)
                {
                    return NotFound();
                }
                _context.Productosdb.Remove(producto);
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