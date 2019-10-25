using Microsoft.AspNetCore.Mvc;
using SweetSavory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;
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
