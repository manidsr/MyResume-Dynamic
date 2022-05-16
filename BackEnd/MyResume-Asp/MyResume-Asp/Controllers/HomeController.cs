using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyResume_Asp.Data;
using MyResume_Asp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume_Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyResume_AspContext _context;

        public HomeController(MyResume_AspContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                ViewData["AboutMe"] = _context.AboutMe.First();
            }
            catch (Exception)
            {
                _context.AboutMe.Add(new AboutMe());
                _context.SaveChanges();
            }
            try
            {
                ViewData["MyInfo"] = _context.MyInformation.First();
            }
            catch (Exception)
            {
                _context.MyInformation.Add(new MyInformation());
                _context.SaveChanges();
            }
            try
            {
                ViewData["Facts"] = _context.Facts.First();
            }
            catch (Exception)
            {
                _context.Facts.Add(new Facts());
                _context.SaveChanges();
            }
            try
            {
                ViewData["MySkills"] = _context.MySkills.Include(x => x.SkillsList).First();
            }
            catch (Exception)
            {
                _context.MySkills.Add(new MySkills());
                _context.SaveChanges();
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
