using Microsoft.AspNetCore.Mvc;
using SweetSavory.Models;
using System.Linq;
namespace SweetSavory.Controllers
{
    public class HomeController : Controller
    {
        private readonly SweetSavoryContext _db;

        public HomeController(SweetSavoryContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            ViewBag.Treats = _db.Treats.ToList();
            ViewBag.Flavors = _db.Flavors.ToList();
            return View();
        }
    }
}
