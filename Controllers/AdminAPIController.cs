using FeyzaNurYilmazHafta2WebAPI.DAL.ApiContext;
using FeyzaNurYilmazHafta2WebAPI.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeyzaNurYilmazHafta2WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAPIController : ControllerBase
    {
        [HttpGet]
        public IActionResult BootcampList()
        {
            var c = new Context();
            return Ok(c.Bootcamps.ToList());
        }


        [HttpPost]
        public IActionResult BootcampAdd(Bootcamp p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }

        [HttpDelete]
        public IActionResult BootcampDelete(int id)
        {
            using var c = new Context();
            var value = c.Bootcamps.Find(id);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }

        
    }
}
