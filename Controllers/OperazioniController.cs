using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_BunardziuVehap_WebAPIRec.Controllers
{
    public class OperazioniController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("CelsiusToFahrenheit")]
        public JsonResult CelsiusToFahrenheit(float A)
        {
            return Json(new { message = "Conversione fatta", status = "OK", output = (A*1.8)+32 });
        }
    }
}
