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
    public class MonedasController : Controller
    {
        private readonly AppDbContext context;
        public MonedasController(AppDbContext context)
        {
            this.context = context; 
        }

        // GET: api/<MONEDASController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.MONEDAS.ToList());

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<MONEDASController>/5
        [HttpGet("{id}", Name = "GetMoneda")]
        public ActionResult Get(int id)
        {
            try
            {
                var moneda = context.MONEDAS.FirstOrDefault(g => g.CLA_MONEDA == id);
                return Ok(moneda);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<MONEDASController>
        [HttpPost]
        public ActionResult Post([FromBody] Monedas_Bd moneda)
        {
            try
            {
                if (!ModelState.IsValid) {
                    return BadRequest();
                   }
                else
                {
                
                context.MONEDAS.Add(moneda);
                context.SaveChanges();

                return CreatedAtRoute("GetMoneda", new {id = moneda.CLA_MONEDA }, moneda);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<RecibosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Monedas_Bd moneda)
        {
            try
            {
                if (moneda.CLA_MONEDA == id)
                {
                    context.Entry(moneda).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetMoneda", new { id = moneda.CLA_MONEDA }, moneda);
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
                var moneda = context.MONEDAS.FirstOrDefault(g => g.CLA_MONEDA == id);
                if (moneda != null)
                {
                    context.MONEDAS.Remove(moneda);
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
