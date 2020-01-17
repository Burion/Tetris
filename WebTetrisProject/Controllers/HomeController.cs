using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using WebTetris.Data;
using WebTetris.Models;

namespace WebTetris.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext ctx;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _ctx)
        {
            _logger = logger;
            ctx = _ctx;
        }

        public IActionResult Index()
        {   
            ctx.Messages.Add(new Message(){ Text = "hello", Date = DateTime.Now });
            ctx.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
