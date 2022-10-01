using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEticaret.Models;

namespace WebApiEticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        Context context = new Context();
        [HttpGet("Getlist")]
        public IActionResult GetList()
        {
            List<Urun> urunlerim = new List<Urun>();
            urunlerim = context.Urunler.ToList();
            return Ok(urunlerim);
        }
        [HttpPost]
        public IActionResult Add(Urun urun)
        {
            context.Add(urun);
            context.SaveChanges();
            return Ok("eklendi");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var urun = context.Urunler.FirstOrDefault(u=>u.Id==id);
            context.Remove(urun);
            context.SaveChanges();
            return Ok("silindi");
             
        }
    }
}
