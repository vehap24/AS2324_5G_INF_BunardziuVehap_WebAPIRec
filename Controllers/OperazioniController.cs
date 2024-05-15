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
        [HttpGet("CylinderVolume")]
        public JsonResult CylinderVolume(float H, float R)
        {
            if(H > 0 &&  R > 0)
            {
                return Json(new { message = "Calcolo eseguito", status = "OK", output = (((R*R) * 3.14) * H) });
            }
            else
            {
                return Json(new { message = "Valore negativo inserito", status = "KO", output = 0 });
            }
            
        }
    }
}
