using Microsoft.AspNetCore.Mvc;

namespace Todean_Daiana_Lab1.Controllers
{
    public class FirstController : Controller
    {
       // public IActionResult Index()
        //{
        //    return View();
       // }

        public String Index() {
            return "Bine ati venit!";
        }

        public String Welcome() {
            return "Salut, utilizatorule!";
        }

        public String Mesaj(String nume, int varsta) {
            return $"Salut, {nume}! Aveti {varsta} ani.";
        }

    }
}
