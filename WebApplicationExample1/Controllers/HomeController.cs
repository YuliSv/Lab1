using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationExample1.Models.Home;

namespace WebApplicationExample1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            var indexModel = new IndexModel();

            return View(indexModel);
        }

        public ActionResult Privacy()
        {
            var indexModel = new PrivacyModel();

            return View(indexModel);
        }
    }
}
