using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiEticaret.Models;

namespace WebApiEticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        Context context = new Context();
        [HttpGet("Getlist")]
        public IActionResult GetList()
        {
            List<Sepet> sepetlerim = new List<Sepet>();
            sepetlerim = context.Sepet.ToList();
            return Ok(sepetlerim);
        }
        [HttpPost]
        public IActionResult Add(Sepet sepet)
        {
            context.Add(sepet);
            context.SaveChanges();
            return Ok("eklendi");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var sepet = context.Sepet.FirstOrDefault(s => s.Id == id);
            context.Remove(sepet);
            context.SaveChanges();
            return Ok("silindi");

        }
    }
}
