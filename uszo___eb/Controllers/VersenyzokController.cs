using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uszo___eb.Models;

namespace uszo___eb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VersenyzokController : ControllerBase
    {
        [HttpGet]
        [Route("GetVersenyzokSzama")]
        public IActionResult GetVersenyzokSzama()
        {
            using (var context = new uszoebContext())
            {
                try
                {
                    return Ok(context.Versenyzoks.Count());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
        [HttpPost]

        public IActionResult Post([FromBody] Versenyzok versenyzo)
        {
            using(var context=new uszoebContext())
            { 
                try
                {
                    context.Versenyzoks.Add(versenyzo);
                    context.SaveChanges();
                    return Ok("Adat siker");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
        [HttpPut("UpdateVersenyzo")]
        public IActionResult PutUpdateVersenyzo(Versenyzok versenyzo)
        {
            using (var context = new uszoebContext())
            {
                try
                {
                    context.Versenyzoks.Update(versenyzo);
                    context.SaveChanges();
                    return StatusCode(200, "Versenyző adatainak módosítása sikeresen megtörtént");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
