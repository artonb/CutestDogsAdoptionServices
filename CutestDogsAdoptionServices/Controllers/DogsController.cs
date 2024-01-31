using Microsoft.AspNetCore.Mvc;

namespace CutestDogsAdoptionServices.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
