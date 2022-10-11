using Microsoft.AspNetCore.Mvc;

namespace Tuns_Bianca_Lab1.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Newindex()
        {
            return View();
        }

        public string Indexp(string nume, int varsta)
        {
            return "mesaj:"+nume+ "varsta:"+varsta;
        }

        
    }
}
