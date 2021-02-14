using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL;
using Fiorella.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Sliders = _context.Sliders.ToList(),
               FlowerMainText= _context.FlowerMainText.FirstOrDefault(),
               Categories= _context.Categories.Where(c=>c.IsDeleted==false).ToList(),
               Products= _context.Products.Where(p=>p.IsDeleted==false).Include(p=>p.Category).Take(8).ToList(),
                Banner = _context.Banner.FirstOrDefault(),
                Experts = _context.Experts.ToList(),
                Search= _context.Searches.FirstOrDefault(),
                Blogs = _context.Blogs.ToList(),
                Minislides= _context.Minislides.ToList(),
                Instagrams= _context.Instagrams.ToList()
            };
            return View(homeVm);
        }
    }
}
