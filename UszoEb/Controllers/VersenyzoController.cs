using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UszoEb.Models;

namespace UszoEb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersenyzoController : ControllerBase
    {
        [HttpGet("GetVersenyzoNev")]
        public ActionResult GetVersenyzoNev()
        {
            using(var context=new uszoebContext())
            {
                try
                {
                    return Ok(context.Versenyzoks.ToList());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpGet("GetVersenyzokSzama")]
        public IActionResult GetVersenyzokSzama()
        {
            using(var context=new uszoebContext())
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

        [HttpPost("AddVersenyzo/{uid}")]
        public IActionResult AddVersenyzo([FromBody] Versenyzok versenyzok, string uid)
        {
            using(var context=new uszoebContext())
            {
                try
                {
                    if (uid=="FEB3F4FEA09CE43E")
                    {
                        context.Versenyzoks.Add(versenyzok);
                        context.SaveChanges();
                        return StatusCode(201, "Versenyző hozzáadása sikeresen megtörtént.");
                    }
                    else
                    {
                        return NotFound("Nincs jogosultsága új versenzyő felvételéhez.");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpPut("UpdateVersenyzo/{uid}")]
        public IActionResult UpdateVersenyzo([FromBody] Versenyzok versenyzok, string uid)
        {
            using(var context=new uszoebContext())
            {
                try
                {
                    if (uid== "FEB3F4FEA09CE43E")
                    {
                        context.Versenyzoks.Update(versenyzok);
                        context.SaveChanges();
                        return StatusCode(201, "Versenyző adatainak módosítása sikeresen megtörtént.");
                    }
                    else
                    {
                        return NotFound("Nincs jogosultsága a versenyzők adatainak módosítására.");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpDelete("DeleteVersenyzo/{uid}")]
        public IActionResult DeleteVersenyo([FromBody] Versenyzok versenyzo,string uid)
        {
            using (var context = new uszoebContext())
            {
                try
                {
                    if (uid== "FEB3F4FEA09CE43E")
                    {
                        context.Versenyzoks.Remove(versenyzo);
                        context.SaveChanges();
                        return StatusCode(201, "Versenyző adatainak törlése sikeresen megtörtént.");
                    }
                    else
                    {
                        return NotFound("Nincs jogosultsága a versenyzők adatainak törléséhez");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
