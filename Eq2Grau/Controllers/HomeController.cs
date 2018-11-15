using Eq2Grau.Models;
using System.Web.Mvc;

namespace Eq2Grau.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Resultado = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(Parametros parametros)
        {
            if (ModelState.IsValid)
            {
                Calculos calc = new Calculos();
                               
                ViewBag.Resultado = "Raiz de a: " + calc.CalcRaiz1(parametros) + " Raiz de b: " + calc.CalcRaiz2(parametros);
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}