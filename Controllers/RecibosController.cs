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
    public class RecibosController : Controller
    {
        private readonly AppDbContext context;
        public RecibosController(AppDbContext context)
        {
            this.context = context; 
        }

        // GET: api/<RecibosController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

                return Ok(context.RECIBOS.ToList());

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<RecibosController>/5
        [HttpGet("{id}", Name = "GetRecibo")]
        public ActionResult Get(int id)
        {
            try
            {
                var recibo = context.RECIBOS.FirstOrDefault(g => g.CLA_RECIBO ==id);
                return Ok(recibo);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<RecibosController>
        [HttpPost]
        public ActionResult Post([FromBody] Recibos_Bd recibo)
        {
            try
            {
                if (!ModelState.IsValid) {
                    return BadRequest();
                   }
                else
                {
                
                context.RECIBOS.Add(recibo);
                context.SaveChanges();

                return CreatedAtRoute("GetRecibo", new {id = recibo.CLA_RECIBO}, recibo);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<RecibosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Recibos_Bd recibo)
        {
            try
            {
                if (recibo.CLA_RECIBO == id)
                {
                    context.Entry(recibo).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetRecibo", new { id = recibo.CLA_RECIBO }, recibo);
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
                var recibo = context.RECIBOS.FirstOrDefault(g => g.CLA_RECIBO == id);
                if (recibo != null)
                {
                    context.RECIBOS.Remove(recibo);
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
