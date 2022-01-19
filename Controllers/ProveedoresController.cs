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
    public class ProveedoresController : Controller
    {
        private readonly AppDbContext context;
        public ProveedoresController(AppDbContext context)
        {
            this.context = context; 
        }

        // GET: api/<PROVEEDORESController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

                return Ok(context.PROVEEDORES.ToList());

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<PROVEEDORESController>/5
        [HttpGet("{id}", Name = "GetProveedor")]
        public ActionResult Get(int id)
        {
            try
            {
                var recibo = context.PROVEEDORES.FirstOrDefault(g => g.CLA_PROVEEDOR ==id);
                return Ok(recibo);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<PROVEEDORESController>
        [HttpPost]
        public ActionResult Post([FromBody] Proveedores_Bd provedor)
        {
            try
            {
                if (!ModelState.IsValid) {
                    return BadRequest();
                   }
                else
                {
                
                context.PROVEEDORES.Add(provedor);
                context.SaveChanges();

                return CreatedAtRoute("GetProveedor", new {id = provedor.CLA_PROVEEDOR}, provedor);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PROVEEDORESController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Proveedores_Bd provedor)
        {
            try
            {
                if (provedor.CLA_PROVEEDOR == id)
                {
                    context.Entry(provedor).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetProveedor", new { id = provedor.CLA_PROVEEDOR }, provedor);
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

        // DELETE api/<PROVEEDORESController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var provedor = context.PROVEEDORES.FirstOrDefault(g => g.CLA_PROVEEDOR == id);
                if (provedor != null)
                {
                    context.PROVEEDORES.Remove(provedor);
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
