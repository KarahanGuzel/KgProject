using KgProject.Data;
using KgProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Numerics;

namespace KgProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MVCDemoDbContext _mVCDemoDbContext;
        public HomeController(ILogger<HomeController> logger,MVCDemoDbContext mVCDemoDbContext)
        {
            _logger = logger;
            _mVCDemoDbContext= mVCDemoDbContext;   
        }

        public IActionResult Login(String Email, String Password)
        {
            var p = _mVCDemoDbContext.Admins.FirstOrDefault(x => x.Mail == Email && x.PW == Password);
            var e = _mVCDemoDbContext.Employees.FirstOrDefault(x => x.Email == Email && x.Pw == Password);
            if (p == null && e==null) 
            {
                
                return RedirectToAction(nameof(Index));
            }
            if (p!=null)
            {
                HttpContext.Session.SetInt32("id", p.Id);
                return RedirectToAction("View", "Employees");
            }
            else
            {
                HttpContext.Session.SetInt32("id", e.Id);
                return RedirectToAction("EmpInfo", "Employees");
            }

            
         

            
        }

        public IActionResult Index()
        {
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