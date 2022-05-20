using APICatalogo_v3._1.Context;
using APICatalogo_v3._1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace APICatalogo_v3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            try
            {
                return _context.Categorias.AsNoTracking().ToList();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }
           
        }



        [HttpGet("{id}", Name = "GetByCategoriaId")]
        public ActionResult<Produto> GetById(int id)
        {
            try
            {
                var categoria = _context.Categorias.AsNoTracking().FirstOrDefault(p => p.CategoriaId == id);
                if (categoria == null)
                {
                    return NotFound();
                }

                return Ok(categoria);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }

        }

        [HttpPost]
        public ActionResult<Produto> Update(Categoria categoria)
        {
            try
            {
                if (categoria == null)
                {
                    return BadRequest();
                }

                _context.Add(categoria);
                _context.SaveChanges();
                return new CreatedAtRouteResult("GetByCategoriaId", new { categoria.CategoriaId }, categoria);

            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }
           
        }

        [HttpPut("{id}")]

        public ActionResult<Categoria> Update(int id, Categoria categoria)
        {
            try
            {
                if (id != categoria.CategoriaId)
                {
                    return BadRequest();
                }

                _context.Update(categoria);
                _context.SaveChanges();
                return Ok(categoria);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }
           
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
                if (categoria == null)
                {
                    return NotFound();
                }

                _context.Categorias.Remove(categoria);
                _context.SaveChanges();
                return Ok("Categoria removida!");
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }
           
        }


    }
}
