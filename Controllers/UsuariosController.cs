using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using recibosBack.Context;
using recibosBack.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace recibosBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly AppDbContext context;
        public UsuariosController(AppDbContext context)
        {
            this.context = context; 
        }

        // GET: api/<USUARIOSController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.USUARIOS.ToList());

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<USUARIOSController>/5
        [HttpGet("{id}", Name = "GetUsuario")]
        public ActionResult Get(int id)
        {
            try
            {
                var usuario = context.USUARIOS.FirstOrDefault(g => g.CLA_USUARIO == id);
                return Ok(usuario);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<USUARIOSController>
        [HttpPost]
        public ActionResult Post([FromBody]Usuarios_Bd usuario)
        {
            try
            {
                if (!ModelState.IsValid) {
                    return BadRequest();
                   }
                else
                {
                
                context.USUARIOS.Add(usuario);
                context.SaveChanges();

                return CreatedAtRoute("GetUsuario", new {id = usuario.CLA_USUARIO }, usuario);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<RecibosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Usuarios_Bd usuario)
        {
            try
            {
                if (usuario.CLA_USUARIO == id)
                {
                    context.Entry(usuario).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetUsuario", new { id = usuario.CLA_USUARIO }, usuario);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<RecibosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var usuario = context.USUARIOS.FirstOrDefault(g => g.CLA_USUARIO == id);
                if (usuario != null)
                {
                    context.USUARIOS.Remove(usuario);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
