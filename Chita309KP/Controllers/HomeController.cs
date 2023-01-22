using Chita309KP.Models;
using Chita309KP.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chita309KP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Phone.ToList());
        }

        [HttpGet]
        public IActionResult Positions()
        {
            return View(context.Position.ToList());
        }
        [HttpGet]
        public IActionResult Sales()
        {
            return View(context.Sales.ToList());
        }
        [HttpGet]
        public IActionResult Suppliers()
        {
            return View(context.Supplier.ToList());
        }
        [HttpGet]
        public IActionResult Workers()
        {
            return View(context.Worker.ToList());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phone phone)
        {
            context.Phone.Add(phone);
            context.SaveChanges();
            return View("Index", context.Phone.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Phone phone = new Phone();
            context.Phone.ToList().ForEach(
                p => { if (p.Id == id) phone = p; }
                );
            return View(phone);
        }
        [HttpPost]
        public IActionResult Edit(Phone phone)
        {
            context.Update(phone);
            context.SaveChanges();
            return View("Index", context.Phone.ToList());
        }
        public IActionResult Delete(int id)
        {
            Phone phone = new Phone();
            context.Phone.ToList().ForEach(
                p => { if (p.Id == id) phone = p; }
                );
            context.Phone.Remove(phone);
            context.SaveChanges();
            return View("Index", context.Phone.ToList());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}