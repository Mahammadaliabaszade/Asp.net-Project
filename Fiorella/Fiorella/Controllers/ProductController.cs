using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.DAL;
using Fiorella.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.ProductCount=(_context.Products.Where(p => p.IsDeleted == false).Count());
            return View(_context.Products.Where(p=>p.IsDeleted==false).Take(8).ToList());
        }

        public IActionResult LoadMore(int skip)
        {
            int productCount= (_context.Products.Where(p => p.IsDeleted == false).Count());
            if(skip >= productCount)
            {
                return Json("");
            }
            // return Json(_context.Products.Skip(8).Take(8).ToList());
            List<Product> model= (_context.Products.Where(p=>p.IsDeleted==false).Skip(skip).Take(8).ToList());
            return PartialView("_ProductPartial", model);
        }
    }
}
